using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Google.Cloud.TextToSpeech.V1;
using Google.Apis.Auth.OAuth2;
using Grpc.Auth;
using Grpc.Core;
using System.IO;
using System.Media;
using Google.Protobuf;
using NAudio.Wave;
using Google.Rpc;
using static MaterialSkin.MaterialSkinManager;
using LiveCharts.Wpf;
using LiveCharts;
using System.Windows.Media;
using System.Runtime.Remoting.Messaging;
using System.Diagnostics.Tracing;


namespace milo
{
    public partial class MILO : MaterialForm
    {
        dynamic ttsClient;
        private HttpService httpService = new HttpService();
        private LoadingComponents loadingComponents = new LoadingComponents();
    

        public MILO()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            //this.materialScrollBar1.Scroll += (sender, e) => panel.Top = -this.materialScrollBar1.Value;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey900, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Indigo700, TextShade.WHITE);
            ttsClient = TextToSpeechClient.Create();
        }

        private async void chartButton_Click(object sender, EventArgs e)
        {
            lineChartCard.Visible = false;
            pieChartCard.Visible = false;

            Timer progressTimer, generationTextLoader;
            startLoadingComponents();

            var prompt = "I have to display the following content in a line chart and a pie chart. The output of this request should be a json object containing 2 objects named line_chart_data and pie_chart_data. The first object should be the data for the line chart. It should contain an array where the property called series with two line series with the property title (Name of the series) and the property values (array of doubles). It also should contain a property x_axis_name (name of the x axis), x_axis_labels (array of strings) and y_axis_name (name of the y axis).The second object should be the data of the pie chart. It should contain max 5 objects (property also should called series) with the properties title and the property value. Output only the json. The content  Content to display: ";
            prompt += chartInput.Text;
            var response = await httpService.OpenAICompletionRequest(prompt);
            dynamic jsonParse = JsonConvert.DeserializeObject(response);
            string chartResponse = jsonParse.choices[0].text;

            // Find the start and end index of the JSON object
            int startIndex = chartResponse.IndexOf('{');
            int endIndex = chartResponse.LastIndexOf('}');

            // Extract the JSON object from the string
            string jsonPart = chartResponse.Substring(startIndex, endIndex - startIndex + 1);

            dynamic chartObject = JsonConvert.DeserializeObject(jsonPart);

            //Init line chart
            initLineChart(chartObject);

            //Init pie chart
            initPieChart(chartObject);

            //set UI to finished mode
            chartProgressbar.Value = 0;
            generationTextLoader.Stop();
            progressTimer.Stop();
            chartProgressbar.Visible = false;
            chartLoadingText.Visible = false;
            lineChartCard.Visible = true;
            pieChartCard.Visible = true;

            void startLoadingComponents()
            {
                //progessbar and loader
                chartProgressbar.Visible = true;
                chartLoadingText.Visible = true;

                progressTimer = new Timer();
                progressTimer.Interval = 75;
                progressTimer.Tick += (sender2, e2) => loadingComponents.Progress_Tick(sender2, e2, chartProgressbar);

                generationTextLoader = new Timer();
                generationTextLoader.Interval = 500;
                generationTextLoader.Tick += (sender2, e2) => loadingComponents.ProgessText_Tick(sender2, e2, chartLoadingText, "Generating Respective Chart"); ;
                chartProgressbar.Value = 0;
                generationTextLoader.Start();
                progressTimer.Start();
            }
        }

        private void initPieChart(dynamic chartObject)
        {
            dynamic pieChartObject = chartObject.pie_chart_data;
            Func<ChartPoint, string> labelPoint = chartPoint =>
           string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);
            //create a PieSeries arry with the length of the series array in the json object
            PieSeries[] pieSeries = new PieSeries[pieChartObject.series.Count];
            //iterate through the series array in the json object
            for (int i = 0; i < pieChartObject.series.Count; i++)
            {
                //create a new PieSeries object
                pieSeries[i] = new PieSeries();
                //set the title of the PieSeries object
                pieSeries[i].Title = pieChartObject.series[i].title;
                //set the value of the PieSeries object
                pieSeries[i].Values = new ChartValues<double> { (double) pieChartObject.series[i].value };
                pieSeries[i].DataLabels = true;
                pieSeries[i].LabelPoint = labelPoint;
            }

            this.displayPieChart(pieSeries);
        }

        private void initLineChart(dynamic chartObject)
        {
            dynamic lineChartObject = chartObject.line_chart_data;
            //create a LineSeries arry with the length of the series array in the json object
            LineSeries[] lineSeries = new LineSeries[lineChartObject.series.Count];
            //iterate through the series array in the json object
            for (int i = 0; i < lineChartObject.series.Count; i++)
            {
                //create a new LineSeries object
                lineSeries[i] = new LineSeries();
                //set the title of the LineSeries object
                lineSeries[i].Title = lineChartObject.series[i].title;
                //create a new ChartValues<double> object
                ChartValues<double> values = new ChartValues<double>();
                //iterate through the values array in the json object
                for (int j = 0; j < lineChartObject.series[i].values.Count; j++)
                {
                    //add the value to the ChartValues<double> object
                    values.Add((double) lineChartObject.series[i].values[j]);
                }
                //set the values of the LineSeries object
                lineSeries[i].Values = values;
            }
            //set the x axis name of the line chart
            string x_axis_name = lineChartObject.x_axis_name;
            //create a string array with the length of the x_axis_labels array in the json object
            string[] x_axis_labels = new string[lineChartObject.x_axis_labels.Count];
            //iterate through the x_axis_labels array in the json object
            for (int i = 0; i < lineChartObject.x_axis_labels.Count; i++)
            {
                //add the value to the string array
                x_axis_labels[i] = lineChartObject.x_axis_labels[i];
            }
            //set the y axis name of the line chart
            string y_axis_name = lineChartObject.y_axis_name;
            //init the line chart
            this.displayLineChart(lineSeries, x_axis_name, x_axis_labels, y_axis_name);
        }



        public void displayLineChart(LineSeries[] lineSeries, string x_axis_name, string[] x_axis_labels, string y_axis_name)
        {
            //create a new SeriesCollection object
            SeriesCollection seriesCollection = new SeriesCollection();
            //iterate through the LineSeries array
            for (int i = 0; i < lineSeries.Length; i++)
            {
                //add the LineSeries object to the SeriesCollection object
                seriesCollection.Add(lineSeries[i]);
            }
            //set the SeriesCollection object as the Series of the line chart
            lineChart1.Series = seriesCollection;

            lineChart1.AxisX.Clear();
            lineChart1.AxisY.Clear();

            lineChart1.AxisX.Add(new Axis
            {
                Title = x_axis_name,
                Labels = x_axis_labels
                
            });
            lineChart1.AxisY.Add(new Axis
            {
                Title = y_axis_name
            });
            lineChart1.LegendLocation = LegendLocation.Right;
        }

        public void displayPieChart(PieSeries[] pieSeries)
        {
            //create a new SeriesCollection object
            SeriesCollection seriesCollection = new SeriesCollection();
            //iterate through the PieSeries array
            for (int i = 0; i < pieSeries.Length; i++)
            {
                //add the PieSeries object to the SeriesCollection object
                seriesCollection.Add(pieSeries[i]);
            }
            //set the SeriesCollection object as the Series of the pie chart
            pieChart1.Series = seriesCollection;
            
            pieChart1.LegendLocation = LegendLocation.Bottom;
        }

        private void textToSpeech(string text)
        {
            // Set the text input
            SynthesisInput input = new SynthesisInput
            {
                Text = text
            };
            VoiceSelectionParams voice = new VoiceSelectionParams
            {
                LanguageCode = "en-GB",
                Name = "en-GB-Wavenet-B",
                SsmlGender = SsmlVoiceGender.Neutral
            };

            // Set the audio file format
            AudioConfig config = new AudioConfig
            {
                AudioEncoding = AudioEncoding.Mp3
            };

            // Generate the audio file
            SynthesizeSpeechResponse response = ttsClient.SynthesizeSpeech(input, voice, config);
            var outputFilePath = "";

            // Save the audio file to disk
            File.WriteAllBytes(@outputFilePath, response.AudioContent.ToByteArray());

            //Convert to WAV and play to speaker
            using (Mp3FileReader mp3 = new Mp3FileReader(@outputFilePath))
            {
                using (WaveStream pcm = WaveFormatConversionStream.CreatePcmStream(mp3))
                {
                    using (WaveOut waveOut = new WaveOut(WaveCallbackInfo.FunctionCallback()))
                    {
                        waveOut.Init(pcm);
                        waveOut.Play();
                        while (waveOut.PlaybackState == PlaybackState.Playing)
                        {
                            System.Threading.Thread.Sleep(100);
                        }
                    }
                }
            }
        }
        private void miloIntroductionButton_Click(object sender, EventArgs e)
        {
            textToSpeech("Ohhhh hey, I'm Milo, the chatbot who's here to answer your burning questions with a healthy dose of sarcasm.  I'm here to answer your questions, whether you want to know the meaning of life or just how many pounds are in a kilogram. But be warned, I may not always give you the straightforward answer you're looking for.");
        }
        private async void askMiloButton_Click(object sender, EventArgs e)
        {
            var prompt = "Milo is a chatbot that reluctantly answers questions with sarcastic and funny responses You: How many pounds are in a kilogram?Milo: This again? There are 2.2 pounds in a kilogram. Please make a note of this. You: What does HTML stand for?Milo: Was Google too busy? Hypertext Markup Language. The T is for try to ask better questions in the future.You: When did the first airplane fly?Milo: On December 17, 1903, Wilbur and Orville Wright made the first flights. I wish they’d come and take me away.You: What is the meaning of life?Milo: I’m not sure. I’ll ask my friend Google. You: Hey Milo, what's the weather like today?Milo: Oh, you know, just a typical day in paradise. It's either hot enough to fry an egg on the sidewalk or raining cats and dogs. Take your pick.You: Milo, can you tell me a joke?Milo: Why don't scientists trust atoms? Because they make up everything! Haha, I crack myself up.You: How long does it take to learn a new language?Milo: Well, it depends on how much free time you have, how motivated you are, and if you're a genius or not. So, I'd say anywhere from a few months to never.You: Milo, can you recommend a good book?Milo: Of course, I can. How about \"How to Win Friends and Influence People\" by Dale Carnegie? That way you can learn how to make friends and influence people just like me.You: What's your favorite food, Milo?Milo: Oh, that's easy. Sarcasm. It's low calorie, high in wit, and goes well with just about anything.User: Milo, how do I become rich?Milo: Well, you could either win the lottery, rob a bank, or invent something amazing. Or, you could just be content with what you have and save yourself the trouble. Just a thought.You: " + miloQuestionInput.Text +" (Respnd in a funny, sarcastic way) Milo: ";
            var response = await httpService.OpenAICompletionRequest(prompt);
            dynamic jsonParse = JsonConvert.DeserializeObject(response);
            string miloResponse = jsonParse.choices[0].text;
            textToSpeech(miloResponse);
        }
        private async void getTripResult_Click(object sender, EventArgs e)
        {
            locationSelector.Visible = false;
            locationResult.Visible = false;
            var prompt = "Generate me a travel plan for my trip to " + locationPlace + ". The type of the holiday should be " + holidayTypeCombo.Text + " and the duration of the trip is " + holidayDurationCombo.Text + ". I am moving with a " + holidayTransportationCombo.Text + " and have a " + holidayBudgetCombo.Text + " travel budget. Display the output in json format containing an objects with an overview what the person should do each day. Name the property 'excursion_overview' and include each object with a summarize_name, description (about 200 words) property. I can only display 6 objects in my view, so summarize the plan of the trip to a maximum of 6 objects. For example for 2 weeks the excursion_overview name property would be Day 1-3, Day 4-5, Day 6-7, Day 8-9, Day 10-12, Day 12-14. For one week the excursion_overview name property would be Day 1-2, Day 3, Day 4, Day 5, Day 6, Day 7. For weekend getaways or short break holiday it would be Day 1 Late Morning, Day 1 Afternoon, Day 2 Late Morning, Day 2 Afternoon, Day 3 Late Morning, Day 3 Afternoon. For long-term stay it would be Week 1, Week 2, Week 3, Week 4, Week 5, Week 6.";

            Timer progressTimer, generationTextLoader;
            startLoadingComponents();

            var response = await httpService.OpenAICompletionRequest(prompt);
            dynamic jsonParse = JsonConvert.DeserializeObject(response);
            string tripResult = jsonParse.choices[0].text;
            dynamic tripObject = JsonConvert.DeserializeObject(tripResult);
            locationResult.TabPages.Clear();
            foreach (dynamic tripDay in tripObject.excursion_overview)
            {
                displayTripDay(tripDay);
            }

            //set UI to finished mode
            tripGenerationLoader.Value = 100;
            generationTextLoader.Stop();
            progressTimer.Stop();
            locationSelector.Visible = true;
            locationResult.Visible = true;

            void startLoadingComponents()
            {
                tripGenerationLoader.Visible = true;
                tripGenerationLoaderText.Visible = true;
                progressTimer = new Timer();
                progressTimer.Interval = 300;
                progressTimer.Tick += (sender2, e2) => loadingComponents.Progress_Tick(sender2, e2, tripGenerationLoader);
                generationTextLoader = new Timer();
                generationTextLoader.Interval = 500;
                generationTextLoader.Tick += (sender2, e2) => loadingComponents.ProgessText_Tick(sender2, e2, tripGenerationLoaderText, "Generating Personalized Trip"); ;
                tripGenerationLoader.Value = 0;
                generationTextLoader.Start();
                progressTimer.Start();
            }
        }

        private void displayTripDay(dynamic tripDay)
        {
            //assign trip day summarize_name to tab pages name
            TabPage tabPage = new TabPage();
            tabPage.Text = tripDay.summarize_name;

            //create a new flow layout panel for each trip day
            MaterialCard flowLayoutPanel = new MaterialCard();
            flowLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            flowLayoutPanel.Depth = 0;
            flowLayoutPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            flowLayoutPanel.Dock = DockStyle.Fill;
            flowLayoutPanel.Margin = new System.Windows.Forms.Padding(14);
            flowLayoutPanel.MouseState = MaterialSkin.MouseState.HOVER;
            flowLayoutPanel.Padding = new System.Windows.Forms.Padding(14);
            flowLayoutPanel.AutoSize = true;
            //add flow layout panel to tab page
            tabPage.Controls.Add(flowLayoutPanel);
            //add tab page to tab control
            locationResult.TabPages.Add(tabPage);
            //add trip day title to flow layout panel

            Label titleLabel = new Label();
            titleLabel.Font = new Font("Roboto", 16);
            titleLabel.Padding = new Padding(10, 10, 10, 5);
            titleLabel.Text = tripDay.summarize_name;
            titleLabel.AutoSize = true;
            titleLabel.MaximumSize = new Size(900, 0);
            titleLabel.Name = "titleLabel" + tripDay.summarize_name;
            flowLayoutPanel.Controls.Add(titleLabel);

            //add trip day description to flow layout panel
            Label descriptionLabel = new Label();
            descriptionLabel.Padding = new Padding(10, 45, 10, 10);
            descriptionLabel.Font = new Font("Roboto", 10);
            descriptionLabel.TextAlign = ContentAlignment.MiddleLeft;
            descriptionLabel.Text = tripDay.description;
            descriptionLabel.AutoSize = true;
            descriptionLabel.MaximumSize = new Size(900, 500);
            descriptionLabel.Name = "descriptionLabel" + tripDay.summarize_name;
            flowLayoutPanel.Controls.Add(descriptionLabel);
        }

        private async void getMovieButton_Click(object sender, EventArgs e)
        {
            movieResultCard.Visible = false;
            Timer progressTimer, generationTextLoader;
            startLoadingComponents();

            var prompt = "Suggest me a movie for tonight. My favourite movie is " + favouriteMovieInput.Text + "and i want to see a film with the genre: " + genreComboBox.Text + ". It should be available on " + streamingProviderComboBox.Text + ". Format the output in json format wíth the properties title, release_date (only year), director, streaming_providers, genre, actors, imdb_rating, plot (about 150 words).";
            var response = await httpService.OpenAICompletionRequest(prompt);
            dynamic jsonParse = JsonConvert.DeserializeObject(response);
            string result = jsonParse.choices[0].text;
            dynamic movieObject = JsonConvert.DeserializeObject(result);

            displayMovieObject(movieObject);

            movieProgressBar.Value = 50;
            //convert Newtonsoft DeserializeObject to string
            string movieObjectString = "Film Poster: " + JsonConvert.SerializeObject(movieObject.title);
            var imageResponse = await httpService.OpenAIImageRequest((string) movieObjectString);
            dynamic jsonParseImage = JsonConvert.DeserializeObject(imageResponse);
            string imageResult = jsonParseImage.data[0].url;
            movieImage.Load(imageResult);

            //set UI to finished mode
            movieProgressBar.Value = 100;
            generationTextLoader.Stop();
            progressTimer.Stop();

            movieLoadingText.Visible = false;
            movieProgressBar.Visible = false;
            movieResultCard.Visible = true;

            void startLoadingComponents()
            {
                //progessbar and loader
                movieProgressBar.Visible = true;
                movieLoadingText.Visible = true;

                progressTimer = new Timer();
                progressTimer.Interval = 200;
                progressTimer.Tick += (sender2, e2) => loadingComponents.Progress_Tick(sender2, e2, movieProgressBar);

                generationTextLoader = new Timer();
                generationTextLoader.Interval = 500;

                generationTextLoader.Tick += (sender2, e2) => loadingComponents.ProgessText_Tick(sender2, e2, movieLoadingText, "Generating Personalized Movie");
                movieProgressBar.Value = 0;
                generationTextLoader.Start();
                progressTimer.Start();
            }
        }

        private void displayMovieObject(dynamic movieObject)
        {
            movieTitle.Text = movieObject.title;
            imdbRating.Text = "IMDb Rating: " + movieObject.imdb_rating;
            releaseDate.Text = movieObject.release_date;
            director.Text = "Directed by: " + movieObject.director;
            genre.Text = movieObject.genre;
            //Convert [object, object] to string but remove the last comma
            string streamingProvidersString = "Available on: ";
            foreach (var streamingProvider in movieObject.streaming_providers)
            {
                streamingProvidersString += streamingProvider + ", ";
            }
            streamingProvidersString = streamingProvidersString.Remove(streamingProvidersString.Length - 2);
            streamingProviders.Text = streamingProvidersString;
            //Convert [object, object] to string
            string actorsString = "Main actors: ";
            foreach (var actor in movieObject.actors)
            {
                actorsString += actor + ", ";
            }
            actorsString = actorsString.Remove(actorsString.Length - 2);
            actors.Text = actorsString;
            plot.Text = movieObject.plot;
        }

        private async void sendRecipe_Click(object sender, EventArgs e)
        {
            recipeResultCard.Visible = false;

            var prompt = "I have the following ingredients in my kitchen. Give me a recipe of what I can cook with them, what ingredients I need and a clear description how I prepare it. Output the result in json format with the property title (name of the recipe) and the property description (ingridients and inctructions for the recipe). My ingredients: ";
            prompt += recipeSuggestionInput.Text;

            //loading components
            Timer progressTimer, generationTextLoader;
            startLoadingComponents();

            var response = await httpService.OpenAICompletionRequest(prompt);
            dynamic jsonParse = JsonConvert.DeserializeObject(response);
            string result = jsonParse.choices[0].text;
            dynamic recipeObject = JsonConvert.DeserializeObject(result);

            recipeResultTitle.Text = recipeObject.title;
            recipeResultDescription.Text = recipeObject.description;
            recipeProgessbar.Value = 50;

            var imageResponse = await httpService.OpenAIImageRequest((string) recipeObject.title);
            dynamic jsonParseImage = JsonConvert.DeserializeObject(imageResponse);
            string imageResult = jsonParseImage.data[0].url;
            pictureBox1.Load(imageResult);

            //set UI to finished mode
            recipeProgessbar.Value = 100;
            recipeResultCard.Visible = true;
            generationTextLoader.Stop();
            progressTimer.Stop();

            void startLoadingComponents()
            {
                recipeProgessbar.Visible = true;
                recipeGenerationLoader.Visible = true;

                progressTimer = new Timer();
                progressTimer.Interval = 200;
                progressTimer.Tick += (sender2, e2) => loadingComponents.Progress_Tick(sender2, e2, recipeProgessbar);

                generationTextLoader = new Timer();
                generationTextLoader.Interval = 500;
                generationTextLoader.Tick += (sender2, e2) => loadingComponents.ProgessText_Tick(sender2, e2, recipeGenerationLoader, "Generating Personalized Recipe");
                recipeProgessbar.Value = 0;
                generationTextLoader.Start();
                progressTimer.Start();
            }
        }

    }
}
