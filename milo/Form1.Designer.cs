
using MaterialSkin;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Drawing;
using System.Windows.Forms;
using MaterialSkin.Controls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace milo
{
    partial class MILO
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MILO));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.sarcasticMiloIntroduction = new System.Windows.Forms.TabPage();
            this.askMiloButton = new MaterialSkin.Controls.MaterialButton();
            this.miloQuestionInput = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.miloIntroductionButton = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.recipeSuggestion = new System.Windows.Forms.TabPage();
            this.recipeGenerationLoader = new MaterialSkin.Controls.MaterialLabel();
            this.recipeProgessbar = new MaterialSkin.Controls.MaterialProgressBar();
            this.recipeResultCard = new MaterialSkin.Controls.MaterialCard();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.recipeResultDescription = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.recipeResultTitle = new MaterialSkin.Controls.MaterialLabel();
            this.sendRecipe = new MaterialSkin.Controls.MaterialButton();
            this.recipeSuggestionInput = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.locationFinder = new System.Windows.Forms.TabPage();
            this.tripGenerationLoaderText = new MaterialSkin.Controls.MaterialLabel();
            this.tripGenerationLoader = new MaterialSkin.Controls.MaterialProgressBar();
            this.locationSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.locationResult = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.getTripResult = new MaterialSkin.Controls.MaterialButton();
            this.locationPlace = new MaterialSkin.Controls.MaterialTextBox();
            this.materialCard4 = new MaterialSkin.Controls.MaterialCard();
            this.holidayBudgetCombo = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.holidayTransportationCombo = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.holidayDurationCombo = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.holidayTypeCombo = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.filmRoulette = new System.Windows.Forms.TabPage();
            this.movieResultCard = new MaterialSkin.Controls.MaterialCard();
            this.imdbRating = new MaterialSkin.Controls.MaterialLabel();
            this.actors = new MaterialSkin.Controls.MaterialLabel();
            this.streamingProviders = new MaterialSkin.Controls.MaterialLabel();
            this.director = new MaterialSkin.Controls.MaterialLabel();
            this.genre = new MaterialSkin.Controls.MaterialLabel();
            this.releaseDate = new MaterialSkin.Controls.MaterialLabel();
            this.movieImage = new System.Windows.Forms.PictureBox();
            this.plot = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.movieTitle = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard6 = new MaterialSkin.Controls.MaterialCard();
            this.streamingProviderComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel18 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard5 = new MaterialSkin.Controls.MaterialCard();
            this.genreComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel17 = new MaterialSkin.Controls.MaterialLabel();
            this.movieLoadingText = new MaterialSkin.Controls.MaterialLabel();
            this.movieProgressBar = new MaterialSkin.Controls.MaterialProgressBar();
            this.getMovieButton = new MaterialSkin.Controls.MaterialButton();
            this.favouriteMovieInput = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel14 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel15 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel16 = new MaterialSkin.Controls.MaterialLabel();
            this.chartPresentation = new System.Windows.Forms.TabPage();
            this.chartButton = new MaterialSkin.Controls.MaterialButton();
            this.chartInput = new MaterialSkin.Controls.MaterialTextBox();
            this.pieChartCard = new MaterialSkin.Controls.MaterialCard();
            this.pieChart1 = new LiveCharts.WinForms.PieChart();
            this.lineChartCard = new MaterialSkin.Controls.MaterialCard();
            this.lineChart1 = new LiveCharts.WinForms.CartesianChart();
            this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel19 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel20 = new MaterialSkin.Controls.MaterialLabel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.chartLoadingText = new MaterialSkin.Controls.MaterialLabel();
            this.chartProgressbar = new MaterialSkin.Controls.MaterialProgressBar();
            this.materialTabControl1.SuspendLayout();
            this.sarcasticMiloIntroduction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.recipeSuggestion.SuspendLayout();
            this.recipeResultCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.locationFinder.SuspendLayout();
            this.locationResult.SuspendLayout();
            this.materialCard4.SuspendLayout();
            this.materialCard3.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.filmRoulette.SuspendLayout();
            this.movieResultCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movieImage)).BeginInit();
            this.materialCard6.SuspendLayout();
            this.materialCard5.SuspendLayout();
            this.chartPresentation.SuspendLayout();
            this.pieChartCard.SuspendLayout();
            this.lineChartCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.sarcasticMiloIntroduction);
            this.materialTabControl1.Controls.Add(this.recipeSuggestion);
            this.materialTabControl1.Controls.Add(this.locationFinder);
            this.materialTabControl1.Controls.Add(this.filmRoulette);
            this.materialTabControl1.Controls.Add(this.chartPresentation);
            this.materialTabControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 92);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1119, 654);
            this.materialTabControl1.TabIndex = 0;
            // 
            // sarcasticMiloIntroduction
            // 
            this.sarcasticMiloIntroduction.Controls.Add(this.askMiloButton);
            this.sarcasticMiloIntroduction.Controls.Add(this.miloQuestionInput);
            this.sarcasticMiloIntroduction.Controls.Add(this.miloIntroductionButton);
            this.sarcasticMiloIntroduction.Controls.Add(this.materialLabel12);
            this.sarcasticMiloIntroduction.Controls.Add(this.materialLabel11);
            this.sarcasticMiloIntroduction.Controls.Add(this.pictureBox2);
            this.sarcasticMiloIntroduction.ImageKey = "code.png";
            this.sarcasticMiloIntroduction.Location = new System.Drawing.Point(4, 32);
            this.sarcasticMiloIntroduction.Name = "sarcasticMiloIntroduction";
            this.sarcasticMiloIntroduction.Size = new System.Drawing.Size(1111, 618);
            this.sarcasticMiloIntroduction.TabIndex = 7;
            this.sarcasticMiloIntroduction.Text = "Sarcastic Milo";
            this.sarcasticMiloIntroduction.UseVisualStyleBackColor = true;
            // 
            // askMiloButton
            // 
            this.askMiloButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.askMiloButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.askMiloButton.Depth = 0;
            this.askMiloButton.HighEmphasis = true;
            this.askMiloButton.Icon = null;
            this.askMiloButton.Location = new System.Drawing.Point(598, 489);
            this.askMiloButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.askMiloButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.askMiloButton.Name = "askMiloButton";
            this.askMiloButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.askMiloButton.Size = new System.Drawing.Size(88, 36);
            this.askMiloButton.TabIndex = 5;
            this.askMiloButton.Text = "Ask Milo";
            this.askMiloButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.askMiloButton.UseAccentColor = false;
            this.askMiloButton.UseVisualStyleBackColor = true;
            this.askMiloButton.Click += new System.EventHandler(this.askMiloButton_Click);
            // 
            // miloQuestionInput
            // 
            this.miloQuestionInput.AllowPromptAsInput = true;
            this.miloQuestionInput.AnimateReadOnly = false;
            this.miloQuestionInput.AsciiOnly = false;
            this.miloQuestionInput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.miloQuestionInput.BeepOnError = false;
            this.miloQuestionInput.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.miloQuestionInput.Depth = 0;
            this.miloQuestionInput.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.miloQuestionInput.HidePromptOnLeave = false;
            this.miloQuestionInput.HideSelection = true;
            this.miloQuestionInput.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.miloQuestionInput.LeadingIcon = null;
            this.miloQuestionInput.Location = new System.Drawing.Point(337, 483);
            this.miloQuestionInput.Mask = "";
            this.miloQuestionInput.MaxLength = 32767;
            this.miloQuestionInput.MouseState = MaterialSkin.MouseState.OUT;
            this.miloQuestionInput.Name = "miloQuestionInput";
            this.miloQuestionInput.PasswordChar = '\0';
            this.miloQuestionInput.PrefixSuffixText = null;
            this.miloQuestionInput.PromptChar = '_';
            this.miloQuestionInput.ReadOnly = false;
            this.miloQuestionInput.RejectInputOnFirstFailure = false;
            this.miloQuestionInput.ResetOnPrompt = true;
            this.miloQuestionInput.ResetOnSpace = true;
            this.miloQuestionInput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.miloQuestionInput.SelectedText = "";
            this.miloQuestionInput.SelectionLength = 0;
            this.miloQuestionInput.SelectionStart = 0;
            this.miloQuestionInput.ShortcutsEnabled = true;
            this.miloQuestionInput.Size = new System.Drawing.Size(250, 48);
            this.miloQuestionInput.SkipLiterals = true;
            this.miloQuestionInput.TabIndex = 4;
            this.miloQuestionInput.TabStop = false;
            this.miloQuestionInput.Text = "How is the wheater today?";
            this.miloQuestionInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.miloQuestionInput.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.miloQuestionInput.TrailingIcon = null;
            this.miloQuestionInput.UseSystemPasswordChar = false;
            this.miloQuestionInput.ValidatingType = null;
            // 
            // miloIntroductionButton
            // 
            this.miloIntroductionButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.miloIntroductionButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.miloIntroductionButton.Depth = 0;
            this.miloIntroductionButton.HighEmphasis = true;
            this.miloIntroductionButton.Icon = null;
            this.miloIntroductionButton.Location = new System.Drawing.Point(441, 113);
            this.miloIntroductionButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.miloIntroductionButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.miloIntroductionButton.Name = "miloIntroductionButton";
            this.miloIntroductionButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.miloIntroductionButton.Size = new System.Drawing.Size(161, 36);
            this.miloIntroductionButton.TabIndex = 3;
            this.miloIntroductionButton.Text = "Introduce myself";
            this.miloIntroductionButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.miloIntroductionButton.UseAccentColor = false;
            this.miloIntroductionButton.UseVisualStyleBackColor = true;
            this.miloIntroductionButton.Click += new System.EventHandler(this.miloIntroductionButton_Click);
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel12.Location = new System.Drawing.Point(409, 88);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(225, 19);
            this.materialLabel12.TabIndex = 2;
            this.materialLabel12.Text = "an interactive, sarcastic chatbot";
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel11.FontType = MaterialSkin.MaterialSkinManager.fontType.H3;
            this.materialLabel11.Location = new System.Drawing.Point(378, 22);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(285, 58);
            this.materialLabel11.TabIndex = 1;
            this.materialLabel11.Text = "Hey, I\'m Milo.";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(389, 158);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(261, 312);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // recipeSuggestion
            // 
            this.recipeSuggestion.Controls.Add(this.recipeGenerationLoader);
            this.recipeSuggestion.Controls.Add(this.recipeProgessbar);
            this.recipeSuggestion.Controls.Add(this.recipeResultCard);
            this.recipeSuggestion.Controls.Add(this.sendRecipe);
            this.recipeSuggestion.Controls.Add(this.recipeSuggestionInput);
            this.recipeSuggestion.Controls.Add(this.materialLabel3);
            this.recipeSuggestion.Controls.Add(this.materialLabel2);
            this.recipeSuggestion.Controls.Add(this.materialLabel1);
            this.recipeSuggestion.ImageKey = "cake.png";
            this.recipeSuggestion.Location = new System.Drawing.Point(4, 32);
            this.recipeSuggestion.Name = "recipeSuggestion";
            this.recipeSuggestion.Size = new System.Drawing.Size(1111, 618);
            this.recipeSuggestion.TabIndex = 2;
            this.recipeSuggestion.Text = "Recipe Suggestion";
            this.recipeSuggestion.UseVisualStyleBackColor = true;
            // 
            // recipeGenerationLoader
            // 
            this.recipeGenerationLoader.AutoSize = true;
            this.recipeGenerationLoader.Depth = 0;
            this.recipeGenerationLoader.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.recipeGenerationLoader.Location = new System.Drawing.Point(774, 244);
            this.recipeGenerationLoader.MouseState = MaterialSkin.MouseState.HOVER;
            this.recipeGenerationLoader.Name = "recipeGenerationLoader";
            this.recipeGenerationLoader.Size = new System.Drawing.Size(224, 19);
            this.recipeGenerationLoader.TabIndex = 7;
            this.recipeGenerationLoader.Text = "Generating Personalized Recipe";
            this.recipeGenerationLoader.Visible = false;
            // 
            // recipeProgessbar
            // 
            this.recipeProgessbar.Depth = 0;
            this.recipeProgessbar.Location = new System.Drawing.Point(739, 236);
            this.recipeProgessbar.MouseState = MaterialSkin.MouseState.HOVER;
            this.recipeProgessbar.Name = "recipeProgessbar";
            this.recipeProgessbar.Size = new System.Drawing.Size(292, 5);
            this.recipeProgessbar.TabIndex = 6;
            this.recipeProgessbar.Visible = false;
            // 
            // recipeResultCard
            // 
            this.recipeResultCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.recipeResultCard.Controls.Add(this.pictureBox1);
            this.recipeResultCard.Controls.Add(this.recipeResultDescription);
            this.recipeResultCard.Controls.Add(this.recipeResultTitle);
            this.recipeResultCard.Depth = 0;
            this.recipeResultCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.recipeResultCard.Location = new System.Drawing.Point(20, 297);
            this.recipeResultCard.Margin = new System.Windows.Forms.Padding(14);
            this.recipeResultCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.recipeResultCard.Name = "recipeResultCard";
            this.recipeResultCard.Padding = new System.Windows.Forms.Padding(14);
            this.recipeResultCard.Size = new System.Drawing.Size(1011, 313);
            this.recipeResultCard.TabIndex = 5;
            this.recipeResultCard.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(368, 319);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // recipeResultDescription
            // 
            this.recipeResultDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.recipeResultDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.recipeResultDescription.Depth = 0;
            this.recipeResultDescription.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.recipeResultDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.recipeResultDescription.Location = new System.Drawing.Point(384, 49);
            this.recipeResultDescription.MouseState = MaterialSkin.MouseState.HOVER;
            this.recipeResultDescription.Name = "recipeResultDescription";
            this.recipeResultDescription.ReadOnly = true;
            this.recipeResultDescription.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.recipeResultDescription.Size = new System.Drawing.Size(621, 241);
            this.recipeResultDescription.TabIndex = 1;
            this.recipeResultDescription.Text = "asdf";
            // 
            // recipeResultTitle
            // 
            this.recipeResultTitle.AutoSize = true;
            this.recipeResultTitle.Depth = 0;
            this.recipeResultTitle.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.recipeResultTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.recipeResultTitle.Location = new System.Drawing.Point(385, 14);
            this.recipeResultTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.recipeResultTitle.Name = "recipeResultTitle";
            this.recipeResultTitle.Size = new System.Drawing.Size(68, 29);
            this.recipeResultTitle.TabIndex = 0;
            this.recipeResultTitle.Text = "Result";
            // 
            // sendRecipe
            // 
            this.sendRecipe.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sendRecipe.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.sendRecipe.Depth = 0;
            this.sendRecipe.HighEmphasis = true;
            this.sendRecipe.Icon = null;
            this.sendRecipe.Location = new System.Drawing.Point(739, 187);
            this.sendRecipe.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.sendRecipe.MouseState = MaterialSkin.MouseState.HOVER;
            this.sendRecipe.Name = "sendRecipe";
            this.sendRecipe.NoAccentTextColor = System.Drawing.Color.Empty;
            this.sendRecipe.Size = new System.Drawing.Size(102, 36);
            this.sendRecipe.TabIndex = 4;
            this.sendRecipe.Text = "Get Recipe";
            this.sendRecipe.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.sendRecipe.UseAccentColor = false;
            this.sendRecipe.UseVisualStyleBackColor = true;
            this.sendRecipe.Click += new System.EventHandler(this.sendRecipe_Click);
            // 
            // recipeSuggestionInput
            // 
            this.recipeSuggestionInput.AnimateReadOnly = false;
            this.recipeSuggestionInput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.recipeSuggestionInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.recipeSuggestionInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.recipeSuggestionInput.Depth = 0;
            this.recipeSuggestionInput.HideSelection = true;
            this.recipeSuggestionInput.Location = new System.Drawing.Point(20, 188);
            this.recipeSuggestionInput.MaxLength = 32767;
            this.recipeSuggestionInput.MouseState = MaterialSkin.MouseState.OUT;
            this.recipeSuggestionInput.Name = "recipeSuggestionInput";
            this.recipeSuggestionInput.PasswordChar = '\0';
            this.recipeSuggestionInput.ReadOnly = false;
            this.recipeSuggestionInput.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.recipeSuggestionInput.SelectedText = "";
            this.recipeSuggestionInput.SelectionLength = 0;
            this.recipeSuggestionInput.SelectionStart = 0;
            this.recipeSuggestionInput.ShortcutsEnabled = true;
            this.recipeSuggestionInput.Size = new System.Drawing.Size(701, 103);
            this.recipeSuggestionInput.TabIndex = 3;
            this.recipeSuggestionInput.TabStop = false;
            this.recipeSuggestionInput.Text = "Enter all the ingrients you have in your kitchen";
            this.recipeSuggestionInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.recipeSuggestionInput.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(20, 104);
            this.materialLabel3.MaximumSize = new System.Drawing.Size(750, 0);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(700, 80);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = resources.GetString("materialLabel3.Text");
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel2.Location = new System.Drawing.Point(20, 78);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(516, 24);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Get a Personalized Recipe Based on What\'s in Your Fridge";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H3;
            this.materialLabel1.Location = new System.Drawing.Point(20, 5);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(396, 58);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Recipe Suggestion";
            // 
            // locationFinder
            // 
            this.locationFinder.Controls.Add(this.tripGenerationLoaderText);
            this.locationFinder.Controls.Add(this.tripGenerationLoader);
            this.locationFinder.Controls.Add(this.locationSelector);
            this.locationFinder.Controls.Add(this.locationResult);
            this.locationFinder.Controls.Add(this.getTripResult);
            this.locationFinder.Controls.Add(this.locationPlace);
            this.locationFinder.Controls.Add(this.materialCard4);
            this.locationFinder.Controls.Add(this.materialCard3);
            this.locationFinder.Controls.Add(this.materialCard2);
            this.locationFinder.Controls.Add(this.materialCard1);
            this.locationFinder.Controls.Add(this.materialLabel6);
            this.locationFinder.Controls.Add(this.materialLabel5);
            this.locationFinder.Controls.Add(this.materialLabel4);
            this.locationFinder.ImageKey = "map-pin.png";
            this.locationFinder.Location = new System.Drawing.Point(4, 32);
            this.locationFinder.Name = "locationFinder";
            this.locationFinder.Padding = new System.Windows.Forms.Padding(3);
            this.locationFinder.Size = new System.Drawing.Size(1111, 618);
            this.locationFinder.TabIndex = 1;
            this.locationFinder.Text = "Location Finder";
            this.locationFinder.UseVisualStyleBackColor = true;
            // 
            // tripGenerationLoaderText
            // 
            this.tripGenerationLoaderText.AutoSize = true;
            this.tripGenerationLoaderText.Depth = 0;
            this.tripGenerationLoaderText.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tripGenerationLoaderText.Location = new System.Drawing.Point(592, 221);
            this.tripGenerationLoaderText.MouseState = MaterialSkin.MouseState.HOVER;
            this.tripGenerationLoaderText.Name = "tripGenerationLoaderText";
            this.tripGenerationLoaderText.Size = new System.Drawing.Size(205, 19);
            this.tripGenerationLoaderText.TabIndex = 14;
            this.tripGenerationLoaderText.Text = "Generating Personalized Trip";
            this.tripGenerationLoaderText.Visible = false;
            // 
            // tripGenerationLoader
            // 
            this.tripGenerationLoader.Depth = 0;
            this.tripGenerationLoader.Location = new System.Drawing.Point(557, 213);
            this.tripGenerationLoader.MouseState = MaterialSkin.MouseState.HOVER;
            this.tripGenerationLoader.Name = "tripGenerationLoader";
            this.tripGenerationLoader.Size = new System.Drawing.Size(292, 5);
            this.tripGenerationLoader.TabIndex = 13;
            this.tripGenerationLoader.Visible = false;
            // 
            // locationSelector
            // 
            this.locationSelector.BaseTabControl = this.locationResult;
            this.locationSelector.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.locationSelector.Depth = 0;
            this.locationSelector.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.locationSelector.Location = new System.Drawing.Point(19, 366);
            this.locationSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.locationSelector.Name = "locationSelector";
            this.locationSelector.Size = new System.Drawing.Size(1023, 48);
            this.locationSelector.TabIndex = 12;
            this.locationSelector.Text = "materialTabSelector1";
            this.locationSelector.Visible = false;
            // 
            // locationResult
            // 
            this.locationResult.Controls.Add(this.tabPage1);
            this.locationResult.Controls.Add(this.tabPage2);
            this.locationResult.Depth = 0;
            this.locationResult.Location = new System.Drawing.Point(19, 420);
            this.locationResult.MouseState = MaterialSkin.MouseState.HOVER;
            this.locationResult.Multiline = true;
            this.locationResult.Name = "locationResult";
            this.locationResult.SelectedIndex = 0;
            this.locationResult.Size = new System.Drawing.Size(1023, 164);
            this.locationResult.TabIndex = 11;
            this.locationResult.Visible = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1015, 128);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Day 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1015, 135);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Day 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // getTripResult
            // 
            this.getTripResult.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.getTripResult.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.getTripResult.Depth = 0;
            this.getTripResult.HighEmphasis = true;
            this.getTripResult.Icon = null;
            this.getTripResult.Location = new System.Drawing.Point(432, 206);
            this.getTripResult.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.getTripResult.MouseState = MaterialSkin.MouseState.HOVER;
            this.getTripResult.Name = "getTripResult";
            this.getTripResult.NoAccentTextColor = System.Drawing.Color.Empty;
            this.getTripResult.Size = new System.Drawing.Size(94, 36);
            this.getTripResult.TabIndex = 9;
            this.getTripResult.Text = "Plan trip";
            this.getTripResult.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.getTripResult.UseAccentColor = false;
            this.getTripResult.UseVisualStyleBackColor = true;
            this.getTripResult.Click += new System.EventHandler(this.getTripResult_Click);
            // 
            // locationPlace
            // 
            this.locationPlace.AnimateReadOnly = false;
            this.locationPlace.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.locationPlace.Depth = 0;
            this.locationPlace.Font = new System.Drawing.Font("Roboto", 9.6F);
            this.locationPlace.LeadingIcon = null;
            this.locationPlace.Location = new System.Drawing.Point(19, 201);
            this.locationPlace.MaxLength = 50;
            this.locationPlace.MouseState = MaterialSkin.MouseState.OUT;
            this.locationPlace.Multiline = false;
            this.locationPlace.Name = "locationPlace";
            this.locationPlace.Size = new System.Drawing.Size(395, 50);
            this.locationPlace.TabIndex = 8;
            this.locationPlace.Text = "Where you want to go?";
            this.locationPlace.TrailingIcon = null;
            // 
            // materialCard4
            // 
            this.materialCard4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard4.Controls.Add(this.holidayBudgetCombo);
            this.materialCard4.Controls.Add(this.materialLabel10);
            this.materialCard4.Depth = 0;
            this.materialCard4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard4.Location = new System.Drawing.Point(802, 260);
            this.materialCard4.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard4.Name = "materialCard4";
            this.materialCard4.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard4.Size = new System.Drawing.Size(240, 96);
            this.materialCard4.TabIndex = 7;
            // 
            // holidayBudgetCombo
            // 
            this.holidayBudgetCombo.AutoResize = false;
            this.holidayBudgetCombo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.holidayBudgetCombo.Depth = 0;
            this.holidayBudgetCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.holidayBudgetCombo.DropDownHeight = 174;
            this.holidayBudgetCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.holidayBudgetCombo.DropDownWidth = 121;
            this.holidayBudgetCombo.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.holidayBudgetCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.holidayBudgetCombo.FormattingEnabled = true;
            this.holidayBudgetCombo.IntegralHeight = false;
            this.holidayBudgetCombo.ItemHeight = 43;
            this.holidayBudgetCombo.Items.AddRange(new object[] {
            "Luxury",
            "Mid-range",
            "Budget-friendly",
            "All-inclusive",
            "Value for Money"});
            this.holidayBudgetCombo.Location = new System.Drawing.Point(9, 32);
            this.holidayBudgetCombo.MaxDropDownItems = 4;
            this.holidayBudgetCombo.MouseState = MaterialSkin.MouseState.OUT;
            this.holidayBudgetCombo.Name = "holidayBudgetCombo";
            this.holidayBudgetCombo.Size = new System.Drawing.Size(219, 49);
            this.holidayBudgetCombo.StartIndex = 0;
            this.holidayBudgetCombo.TabIndex = 5;
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel10.Location = new System.Drawing.Point(11, 8);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(51, 19);
            this.materialLabel10.TabIndex = 4;
            this.materialLabel10.Text = "Budget";
            // 
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.holidayTransportationCombo);
            this.materialCard3.Controls.Add(this.materialLabel9);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(541, 260);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(240, 96);
            this.materialCard3.TabIndex = 6;
            // 
            // holidayTransportationCombo
            // 
            this.holidayTransportationCombo.AutoResize = false;
            this.holidayTransportationCombo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.holidayTransportationCombo.Depth = 0;
            this.holidayTransportationCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.holidayTransportationCombo.DropDownHeight = 174;
            this.holidayTransportationCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.holidayTransportationCombo.DropDownWidth = 121;
            this.holidayTransportationCombo.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.holidayTransportationCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.holidayTransportationCombo.FormattingEnabled = true;
            this.holidayTransportationCombo.IntegralHeight = false;
            this.holidayTransportationCombo.ItemHeight = 43;
            this.holidayTransportationCombo.Items.AddRange(new object[] {
            "Rental car",
            "Public transport",
            "Rail",
            "Taxi"});
            this.holidayTransportationCombo.Location = new System.Drawing.Point(7, 32);
            this.holidayTransportationCombo.MaxDropDownItems = 4;
            this.holidayTransportationCombo.MouseState = MaterialSkin.MouseState.OUT;
            this.holidayTransportationCombo.Name = "holidayTransportationCombo";
            this.holidayTransportationCombo.Size = new System.Drawing.Size(219, 49);
            this.holidayTransportationCombo.StartIndex = 0;
            this.holidayTransportationCombo.TabIndex = 4;
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.Location = new System.Drawing.Point(8, 8);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(106, 19);
            this.materialLabel9.TabIndex = 3;
            this.materialLabel9.Text = "Transportation";
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.holidayDurationCombo);
            this.materialCard2.Controls.Add(this.materialLabel8);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(281, 260);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(240, 96);
            this.materialCard2.TabIndex = 5;
            // 
            // holidayDurationCombo
            // 
            this.holidayDurationCombo.AutoResize = false;
            this.holidayDurationCombo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.holidayDurationCombo.Depth = 0;
            this.holidayDurationCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.holidayDurationCombo.DropDownHeight = 174;
            this.holidayDurationCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.holidayDurationCombo.DropDownWidth = 121;
            this.holidayDurationCombo.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.holidayDurationCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.holidayDurationCombo.FormattingEnabled = true;
            this.holidayDurationCombo.IntegralHeight = false;
            this.holidayDurationCombo.ItemHeight = 43;
            this.holidayDurationCombo.Items.AddRange(new object[] {
            "Weekend Getaway",
            "Short Breaks",
            "One Week",
            "Two Weeks",
            "Long-Term Stays"});
            this.holidayDurationCombo.Location = new System.Drawing.Point(11, 32);
            this.holidayDurationCombo.MaxDropDownItems = 4;
            this.holidayDurationCombo.MouseState = MaterialSkin.MouseState.OUT;
            this.holidayDurationCombo.Name = "holidayDurationCombo";
            this.holidayDurationCombo.Size = new System.Drawing.Size(219, 49);
            this.holidayDurationCombo.StartIndex = 0;
            this.holidayDurationCombo.TabIndex = 3;
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.Location = new System.Drawing.Point(9, 8);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(115, 19);
            this.materialLabel8.TabIndex = 2;
            this.materialLabel8.Text = "Duration of stay";
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.holidayTypeCombo);
            this.materialCard1.Controls.Add(this.materialLabel7);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(20, 260);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(240, 96);
            this.materialCard1.TabIndex = 4;
            // 
            // holidayTypeCombo
            // 
            this.holidayTypeCombo.AutoResize = false;
            this.holidayTypeCombo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.holidayTypeCombo.Depth = 0;
            this.holidayTypeCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.holidayTypeCombo.DropDownHeight = 174;
            this.holidayTypeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.holidayTypeCombo.DropDownWidth = 121;
            this.holidayTypeCombo.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.holidayTypeCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.holidayTypeCombo.FormattingEnabled = true;
            this.holidayTypeCombo.IntegralHeight = false;
            this.holidayTypeCombo.ItemHeight = 43;
            this.holidayTypeCombo.Items.AddRange(new object[] {
            "Adventure",
            "Beach",
            "City break",
            "Family-friendly",
            "Romantic",
            "Relaxation",
            "Cultural"});
            this.holidayTypeCombo.Location = new System.Drawing.Point(10, 32);
            this.holidayTypeCombo.MaxDropDownItems = 4;
            this.holidayTypeCombo.MouseState = MaterialSkin.MouseState.OUT;
            this.holidayTypeCombo.Name = "holidayTypeCombo";
            this.holidayTypeCombo.Size = new System.Drawing.Size(219, 49);
            this.holidayTypeCombo.StartIndex = 0;
            this.holidayTypeCombo.TabIndex = 1;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.Location = new System.Drawing.Point(9, 10);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(111, 19);
            this.materialLabel7.TabIndex = 0;
            this.materialLabel7.Text = "Type of holiday";
            // 
            // materialLabel6
            // 
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(20, 104);
            this.materialLabel6.MaximumSize = new System.Drawing.Size(750, 0);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(700, 80);
            this.materialLabel6.TabIndex = 3;
            this.materialLabel6.Text = resources.GetString("materialLabel6.Text");
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel5.Location = new System.Drawing.Point(20, 78);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(417, 24);
            this.materialLabel5.TabIndex = 2;
            this.materialLabel5.Text = "Find your perfect holiday destination with ease";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H3;
            this.materialLabel4.Location = new System.Drawing.Point(20, 5);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(331, 58);
            this.materialLabel4.TabIndex = 1;
            this.materialLabel4.Text = "Location Finder";
            // 
            // filmRoulette
            // 
            this.filmRoulette.Controls.Add(this.movieResultCard);
            this.filmRoulette.Controls.Add(this.materialCard6);
            this.filmRoulette.Controls.Add(this.materialCard5);
            this.filmRoulette.Controls.Add(this.movieLoadingText);
            this.filmRoulette.Controls.Add(this.movieProgressBar);
            this.filmRoulette.Controls.Add(this.getMovieButton);
            this.filmRoulette.Controls.Add(this.favouriteMovieInput);
            this.filmRoulette.Controls.Add(this.materialLabel14);
            this.filmRoulette.Controls.Add(this.materialLabel15);
            this.filmRoulette.Controls.Add(this.materialLabel16);
            this.filmRoulette.ImageKey = "film.png";
            this.filmRoulette.Location = new System.Drawing.Point(4, 32);
            this.filmRoulette.Name = "filmRoulette";
            this.filmRoulette.Size = new System.Drawing.Size(1111, 618);
            this.filmRoulette.TabIndex = 5;
            this.filmRoulette.Text = "Film Roulette";
            this.filmRoulette.UseVisualStyleBackColor = true;
            // 
            // movieResultCard
            // 
            this.movieResultCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.movieResultCard.Controls.Add(this.imdbRating);
            this.movieResultCard.Controls.Add(this.actors);
            this.movieResultCard.Controls.Add(this.streamingProviders);
            this.movieResultCard.Controls.Add(this.director);
            this.movieResultCard.Controls.Add(this.genre);
            this.movieResultCard.Controls.Add(this.releaseDate);
            this.movieResultCard.Controls.Add(this.movieImage);
            this.movieResultCard.Controls.Add(this.plot);
            this.movieResultCard.Controls.Add(this.movieTitle);
            this.movieResultCard.Depth = 0;
            this.movieResultCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.movieResultCard.Location = new System.Drawing.Point(25, 307);
            this.movieResultCard.Margin = new System.Windows.Forms.Padding(14);
            this.movieResultCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.movieResultCard.Name = "movieResultCard";
            this.movieResultCard.Padding = new System.Windows.Forms.Padding(14);
            this.movieResultCard.Size = new System.Drawing.Size(997, 315);
            this.movieResultCard.TabIndex = 24;
            this.movieResultCard.Visible = false;
            // 
            // imdbRating
            // 
            this.imdbRating.AutoSize = true;
            this.imdbRating.Depth = 0;
            this.imdbRating.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.imdbRating.FontType = MaterialSkin.MaterialSkinManager.fontType.SubtleEmphasis;
            this.imdbRating.Location = new System.Drawing.Point(726, 55);
            this.imdbRating.MouseState = MaterialSkin.MouseState.HOVER;
            this.imdbRating.Name = "imdbRating";
            this.imdbRating.Size = new System.Drawing.Size(88, 14);
            this.imdbRating.TabIndex = 25;
            this.imdbRating.Text = "IMDb Rating: 7.8";
            // 
            // actors
            // 
            this.actors.AutoSize = true;
            this.actors.Depth = 0;
            this.actors.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.actors.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.actors.Location = new System.Drawing.Point(386, 118);
            this.actors.MouseState = MaterialSkin.MouseState.HOVER;
            this.actors.Name = "actors";
            this.actors.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.actors.Size = new System.Drawing.Size(350, 17);
            this.actors.TabIndex = 7;
            this.actors.Text = "Main Actors: Clint Eastwood, Lee Van Cleef, Eli Wallach";
            // 
            // streamingProviders
            // 
            this.streamingProviders.AutoSize = true;
            this.streamingProviders.Depth = 0;
            this.streamingProviders.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.streamingProviders.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.streamingProviders.Location = new System.Drawing.Point(385, 91);
            this.streamingProviders.MouseState = MaterialSkin.MouseState.HOVER;
            this.streamingProviders.Name = "streamingProviders";
            this.streamingProviders.Size = new System.Drawing.Size(130, 17);
            this.streamingProviders.TabIndex = 6;
            this.streamingProviders.Text = "Available on: Netflix";
            // 
            // director
            // 
            this.director.AutoSize = true;
            this.director.Depth = 0;
            this.director.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.director.FontType = MaterialSkin.MaterialSkinManager.fontType.SubtleEmphasis;
            this.director.Location = new System.Drawing.Point(549, 55);
            this.director.MouseState = MaterialSkin.MouseState.HOVER;
            this.director.Name = "director";
            this.director.Size = new System.Drawing.Size(135, 14);
            this.director.TabIndex = 5;
            this.director.Text = "Directed by: Sergio Leone";
            // 
            // genre
            // 
            this.genre.AutoSize = true;
            this.genre.Depth = 0;
            this.genre.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.genre.FontType = MaterialSkin.MaterialSkinManager.fontType.SubtleEmphasis;
            this.genre.Location = new System.Drawing.Point(461, 55);
            this.genre.MouseState = MaterialSkin.MouseState.HOVER;
            this.genre.Name = "genre";
            this.genre.Size = new System.Drawing.Size(43, 14);
            this.genre.TabIndex = 4;
            this.genre.Text = "Western";
            // 
            // releaseDate
            // 
            this.releaseDate.AutoSize = true;
            this.releaseDate.Depth = 0;
            this.releaseDate.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.releaseDate.FontType = MaterialSkin.MaterialSkinManager.fontType.SubtleEmphasis;
            this.releaseDate.Location = new System.Drawing.Point(387, 55);
            this.releaseDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.releaseDate.Name = "releaseDate";
            this.releaseDate.Size = new System.Drawing.Size(29, 14);
            this.releaseDate.TabIndex = 3;
            this.releaseDate.Text = "1966";
            // 
            // movieImage
            // 
            this.movieImage.Location = new System.Drawing.Point(0, 0);
            this.movieImage.Name = "movieImage";
            this.movieImage.Size = new System.Drawing.Size(368, 319);
            this.movieImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.movieImage.TabIndex = 2;
            this.movieImage.TabStop = false;
            // 
            // plot
            // 
            this.plot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.plot.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.plot.Depth = 0;
            this.plot.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.plot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.plot.Location = new System.Drawing.Point(384, 157);
            this.plot.MouseState = MaterialSkin.MouseState.HOVER;
            this.plot.Name = "plot";
            this.plot.ReadOnly = true;
            this.plot.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.plot.Size = new System.Drawing.Size(589, 141);
            this.plot.TabIndex = 1;
            this.plot.Text = resources.GetString("plot.Text");
            // 
            // movieTitle
            // 
            this.movieTitle.AutoSize = true;
            this.movieTitle.Depth = 0;
            this.movieTitle.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.movieTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.movieTitle.Location = new System.Drawing.Point(385, 19);
            this.movieTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.movieTitle.Name = "movieTitle";
            this.movieTitle.Size = new System.Drawing.Size(348, 29);
            this.movieTitle.TabIndex = 0;
            this.movieTitle.Text = "The Good, The Bad and The Ugly";
            // 
            // materialCard6
            // 
            this.materialCard6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard6.Controls.Add(this.streamingProviderComboBox);
            this.materialCard6.Controls.Add(this.materialLabel18);
            this.materialCard6.Depth = 0;
            this.materialCard6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard6.Location = new System.Drawing.Point(296, 209);
            this.materialCard6.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard6.Name = "materialCard6";
            this.materialCard6.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard6.Size = new System.Drawing.Size(259, 90);
            this.materialCard6.TabIndex = 23;
            // 
            // streamingProviderComboBox
            // 
            this.streamingProviderComboBox.AutoResize = false;
            this.streamingProviderComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.streamingProviderComboBox.Depth = 0;
            this.streamingProviderComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.streamingProviderComboBox.DropDownHeight = 174;
            this.streamingProviderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.streamingProviderComboBox.DropDownWidth = 121;
            this.streamingProviderComboBox.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.streamingProviderComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.streamingProviderComboBox.FormattingEnabled = true;
            this.streamingProviderComboBox.IntegralHeight = false;
            this.streamingProviderComboBox.ItemHeight = 43;
            this.streamingProviderComboBox.Items.AddRange(new object[] {
            "No preference",
            "Netflix ",
            "Amazon Prime Video",
            "Disney+",
            "Hulu",
            "Apple TV+",
            "YouTube TV",
            "ESPN+"});
            this.streamingProviderComboBox.Location = new System.Drawing.Point(11, 32);
            this.streamingProviderComboBox.MaxDropDownItems = 4;
            this.streamingProviderComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.streamingProviderComboBox.Name = "streamingProviderComboBox";
            this.streamingProviderComboBox.Size = new System.Drawing.Size(231, 49);
            this.streamingProviderComboBox.StartIndex = 0;
            this.streamingProviderComboBox.TabIndex = 3;
            // 
            // materialLabel18
            // 
            this.materialLabel18.AutoSize = true;
            this.materialLabel18.Depth = 0;
            this.materialLabel18.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel18.Location = new System.Drawing.Point(9, 8);
            this.materialLabel18.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel18.Name = "materialLabel18";
            this.materialLabel18.Size = new System.Drawing.Size(136, 19);
            this.materialLabel18.TabIndex = 2;
            this.materialLabel18.Text = "Streaming Provider";
            // 
            // materialCard5
            // 
            this.materialCard5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard5.Controls.Add(this.genreComboBox);
            this.materialCard5.Controls.Add(this.materialLabel17);
            this.materialCard5.Depth = 0;
            this.materialCard5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard5.Location = new System.Drawing.Point(24, 209);
            this.materialCard5.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard5.Name = "materialCard5";
            this.materialCard5.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard5.Size = new System.Drawing.Size(250, 90);
            this.materialCard5.TabIndex = 22;
            // 
            // genreComboBox
            // 
            this.genreComboBox.AutoResize = false;
            this.genreComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.genreComboBox.Depth = 0;
            this.genreComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.genreComboBox.DropDownHeight = 174;
            this.genreComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genreComboBox.DropDownWidth = 121;
            this.genreComboBox.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.genreComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.genreComboBox.FormattingEnabled = true;
            this.genreComboBox.IntegralHeight = false;
            this.genreComboBox.ItemHeight = 43;
            this.genreComboBox.Items.AddRange(new object[] {
            "Action",
            "Adventure",
            "Animation",
            "Comedy",
            "Crime",
            "Documentary",
            "Drama",
            "Family",
            "Fantasy",
            "Horror",
            "Musical",
            "Mystery",
            "Romance",
            "Science Fiction",
            "Thriller",
            "War",
            "Western"});
            this.genreComboBox.Location = new System.Drawing.Point(11, 32);
            this.genreComboBox.MaxDropDownItems = 4;
            this.genreComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.genreComboBox.Name = "genreComboBox";
            this.genreComboBox.Size = new System.Drawing.Size(222, 49);
            this.genreComboBox.StartIndex = 0;
            this.genreComboBox.TabIndex = 3;
            // 
            // materialLabel17
            // 
            this.materialLabel17.AutoSize = true;
            this.materialLabel17.Depth = 0;
            this.materialLabel17.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel17.Location = new System.Drawing.Point(9, 8);
            this.materialLabel17.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel17.Name = "materialLabel17";
            this.materialLabel17.Size = new System.Drawing.Size(120, 19);
            this.materialLabel17.TabIndex = 2;
            this.materialLabel17.Text = "Genre preference";
            // 
            // movieLoadingText
            // 
            this.movieLoadingText.AutoSize = true;
            this.movieLoadingText.Depth = 0;
            this.movieLoadingText.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.movieLoadingText.Location = new System.Drawing.Point(399, 408);
            this.movieLoadingText.MouseState = MaterialSkin.MouseState.HOVER;
            this.movieLoadingText.Name = "movieLoadingText";
            this.movieLoadingText.Size = new System.Drawing.Size(220, 19);
            this.movieLoadingText.TabIndex = 21;
            this.movieLoadingText.Text = "Generating Personalized Movie";
            this.movieLoadingText.Visible = false;
            // 
            // movieProgressBar
            // 
            this.movieProgressBar.Depth = 0;
            this.movieProgressBar.Location = new System.Drawing.Point(364, 400);
            this.movieProgressBar.MouseState = MaterialSkin.MouseState.HOVER;
            this.movieProgressBar.Name = "movieProgressBar";
            this.movieProgressBar.Size = new System.Drawing.Size(292, 5);
            this.movieProgressBar.TabIndex = 20;
            this.movieProgressBar.Visible = false;
            // 
            // getMovieButton
            // 
            this.getMovieButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.getMovieButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.getMovieButton.Depth = 0;
            this.getMovieButton.HighEmphasis = true;
            this.getMovieButton.Icon = null;
            this.getMovieButton.Location = new System.Drawing.Point(914, 228);
            this.getMovieButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.getMovieButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.getMovieButton.Name = "getMovieButton";
            this.getMovieButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.getMovieButton.Size = new System.Drawing.Size(97, 36);
            this.getMovieButton.TabIndex = 19;
            this.getMovieButton.Text = "Get movie";
            this.getMovieButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.getMovieButton.UseAccentColor = false;
            this.getMovieButton.UseVisualStyleBackColor = true;
            this.getMovieButton.Click += new System.EventHandler(this.getMovieButton_Click);
            // 
            // favouriteMovieInput
            // 
            this.favouriteMovieInput.AnimateReadOnly = false;
            this.favouriteMovieInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.favouriteMovieInput.Depth = 0;
            this.favouriteMovieInput.Font = new System.Drawing.Font("Roboto", 9.6F);
            this.favouriteMovieInput.LeadingIcon = null;
            this.favouriteMovieInput.Location = new System.Drawing.Point(572, 223);
            this.favouriteMovieInput.MaxLength = 50;
            this.favouriteMovieInput.MouseState = MaterialSkin.MouseState.OUT;
            this.favouriteMovieInput.Multiline = false;
            this.favouriteMovieInput.Name = "favouriteMovieInput";
            this.favouriteMovieInput.Size = new System.Drawing.Size(324, 50);
            this.favouriteMovieInput.TabIndex = 18;
            this.favouriteMovieInput.Text = "Write some of your favourite movies?";
            this.favouriteMovieInput.TrailingIcon = null;
            // 
            // materialLabel14
            // 
            this.materialLabel14.Depth = 0;
            this.materialLabel14.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel14.Location = new System.Drawing.Point(21, 115);
            this.materialLabel14.MaximumSize = new System.Drawing.Size(750, 0);
            this.materialLabel14.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel14.Name = "materialLabel14";
            this.materialLabel14.Size = new System.Drawing.Size(700, 80);
            this.materialLabel14.TabIndex = 17;
            this.materialLabel14.Text = resources.GetString("materialLabel14.Text");
            // 
            // materialLabel15
            // 
            this.materialLabel15.AutoSize = true;
            this.materialLabel15.Depth = 0;
            this.materialLabel15.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel15.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel15.Location = new System.Drawing.Point(21, 89);
            this.materialLabel15.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel15.Name = "materialLabel15";
            this.materialLabel15.Size = new System.Drawing.Size(272, 24);
            this.materialLabel15.TabIndex = 16;
            this.materialLabel15.Text = "Find your perfect movie match";
            // 
            // materialLabel16
            // 
            this.materialLabel16.AutoSize = true;
            this.materialLabel16.Depth = 0;
            this.materialLabel16.Font = new System.Drawing.Font("Roboto", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel16.FontType = MaterialSkin.MaterialSkinManager.fontType.H3;
            this.materialLabel16.Location = new System.Drawing.Point(21, 16);
            this.materialLabel16.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel16.Name = "materialLabel16";
            this.materialLabel16.Size = new System.Drawing.Size(283, 58);
            this.materialLabel16.TabIndex = 15;
            this.materialLabel16.Text = "Film Roulette";
            // 
            // chartPresentation
            // 
            this.chartPresentation.Controls.Add(this.chartLoadingText);
            this.chartPresentation.Controls.Add(this.chartProgressbar);
            this.chartPresentation.Controls.Add(this.chartButton);
            this.chartPresentation.Controls.Add(this.chartInput);
            this.chartPresentation.Controls.Add(this.pieChartCard);
            this.chartPresentation.Controls.Add(this.lineChartCard);
            this.chartPresentation.Controls.Add(this.materialLabel13);
            this.chartPresentation.Controls.Add(this.materialLabel19);
            this.chartPresentation.Controls.Add(this.materialLabel20);
            this.chartPresentation.ImageKey = "presentation-chart-bar.png";
            this.chartPresentation.Location = new System.Drawing.Point(4, 32);
            this.chartPresentation.Name = "chartPresentation";
            this.chartPresentation.Size = new System.Drawing.Size(1111, 618);
            this.chartPresentation.TabIndex = 8;
            this.chartPresentation.Text = "Chart Presentation";
            this.chartPresentation.UseVisualStyleBackColor = true;
            // 
            // chartButton
            // 
            this.chartButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.chartButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.chartButton.Depth = 0;
            this.chartButton.HighEmphasis = true;
            this.chartButton.Icon = null;
            this.chartButton.Location = new System.Drawing.Point(389, 214);
            this.chartButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.chartButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.chartButton.Name = "chartButton";
            this.chartButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.chartButton.Size = new System.Drawing.Size(134, 36);
            this.chartButton.TabIndex = 21;
            this.chartButton.Text = "Visualize data";
            this.chartButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.chartButton.UseAccentColor = false;
            this.chartButton.UseVisualStyleBackColor = true;
            this.chartButton.Click += new System.EventHandler(this.chartButton_Click);
            // 
            // chartInput
            // 
            this.chartInput.AnimateReadOnly = false;
            this.chartInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chartInput.Depth = 0;
            this.chartInput.Font = new System.Drawing.Font("Roboto", 9.6F);
            this.chartInput.LeadingIcon = null;
            this.chartInput.Location = new System.Drawing.Point(20, 205);
            this.chartInput.MaxLength = 500;
            this.chartInput.MouseState = MaterialSkin.MouseState.OUT;
            this.chartInput.Multiline = false;
            this.chartInput.Name = "chartInput";
            this.chartInput.Size = new System.Drawing.Size(353, 50);
            this.chartInput.TabIndex = 20;
            this.chartInput.Text = "What do you want to visualize?";
            this.chartInput.TrailingIcon = null;
            // 
            // pieChartCard
            // 
            this.pieChartCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pieChartCard.Controls.Add(this.pieChart1);
            this.pieChartCard.Depth = 0;
            this.pieChartCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pieChartCard.Location = new System.Drawing.Point(545, 261);
            this.pieChartCard.Margin = new System.Windows.Forms.Padding(14);
            this.pieChartCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.pieChartCard.Name = "pieChartCard";
            this.pieChartCard.Padding = new System.Windows.Forms.Padding(14);
            this.pieChartCard.Size = new System.Drawing.Size(480, 357);
            this.pieChartCard.TabIndex = 7;
            this.pieChartCard.Visible = false;
            // 
            // pieChart1
            // 
            this.pieChart1.Location = new System.Drawing.Point(0, 17);
            this.pieChart1.Name = "pieChart1";
            this.pieChart1.Size = new System.Drawing.Size(480, 337);
            this.pieChart1.TabIndex = 0;
            this.pieChart1.Text = "pieChart1";
            // 
            // lineChartCard
            // 
            this.lineChartCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lineChartCard.Controls.Add(this.lineChart1);
            this.lineChartCard.Depth = 0;
            this.lineChartCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lineChartCard.Location = new System.Drawing.Point(23, 261);
            this.lineChartCard.Margin = new System.Windows.Forms.Padding(14);
            this.lineChartCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.lineChartCard.Name = "lineChartCard";
            this.lineChartCard.Padding = new System.Windows.Forms.Padding(14);
            this.lineChartCard.Size = new System.Drawing.Size(482, 357);
            this.lineChartCard.TabIndex = 6;
            this.lineChartCard.Visible = false;
            // 
            // lineChart1
            // 
            this.lineChart1.Location = new System.Drawing.Point(1, 17);
            this.lineChart1.Name = "lineChart1";
            this.lineChart1.Size = new System.Drawing.Size(481, 337);
            this.lineChart1.TabIndex = 0;
            this.lineChart1.Text = "lineChart1";
            // 
            // materialLabel13
            // 
            this.materialLabel13.Depth = 0;
            this.materialLabel13.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel13.Location = new System.Drawing.Point(20, 118);
            this.materialLabel13.MaximumSize = new System.Drawing.Size(750, 0);
            this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(700, 80);
            this.materialLabel13.TabIndex = 5;
            this.materialLabel13.Text = resources.GetString("materialLabel13.Text");
            // 
            // materialLabel19
            // 
            this.materialLabel19.AutoSize = true;
            this.materialLabel19.Depth = 0;
            this.materialLabel19.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel19.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel19.Location = new System.Drawing.Point(20, 92);
            this.materialLabel19.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel19.Name = "materialLabel19";
            this.materialLabel19.Size = new System.Drawing.Size(251, 24);
            this.materialLabel19.TabIndex = 4;
            this.materialLabel19.Text = "Visualize Any Data Instantly";
            // 
            // materialLabel20
            // 
            this.materialLabel20.AutoSize = true;
            this.materialLabel20.Depth = 0;
            this.materialLabel20.Font = new System.Drawing.Font("Roboto", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel20.FontType = MaterialSkin.MaterialSkinManager.fontType.H3;
            this.materialLabel20.Location = new System.Drawing.Point(20, 19);
            this.materialLabel20.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel20.Name = "materialLabel20";
            this.materialLabel20.Size = new System.Drawing.Size(398, 58);
            this.materialLabel20.TabIndex = 3;
            this.materialLabel20.Text = "Chart Presentation";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "academic-cap.png");
            this.imageList1.Images.SetKeyName(1, "bars-3-bottom-left.png");
            this.imageList1.Images.SetKeyName(2, "cake.png");
            this.imageList1.Images.SetKeyName(3, "code.png");
            this.imageList1.Images.SetKeyName(4, "code-bracket-square.png");
            this.imageList1.Images.SetKeyName(5, "document-arrow-down.png");
            this.imageList1.Images.SetKeyName(6, "film.png");
            this.imageList1.Images.SetKeyName(7, "gift-top.png");
            this.imageList1.Images.SetKeyName(8, "language.png");
            this.imageList1.Images.SetKeyName(9, "link.png");
            this.imageList1.Images.SetKeyName(10, "map-pin.png");
            this.imageList1.Images.SetKeyName(11, "megaphone.png");
            this.imageList1.Images.SetKeyName(12, "newspaper.png");
            this.imageList1.Images.SetKeyName(13, "photo.png");
            this.imageList1.Images.SetKeyName(14, "presentation-chart-bar.png");
            this.imageList1.Images.SetKeyName(15, "trash.png");
            this.imageList1.Images.SetKeyName(16, "upload.png");
            this.imageList1.Images.SetKeyName(17, "20945796 [Konvertiert].png");
            // 
            // chartLoadingText
            // 
            this.chartLoadingText.AutoSize = true;
            this.chartLoadingText.Depth = 0;
            this.chartLoadingText.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.chartLoadingText.Location = new System.Drawing.Point(403, 418);
            this.chartLoadingText.MouseState = MaterialSkin.MouseState.HOVER;
            this.chartLoadingText.Name = "chartLoadingText";
            this.chartLoadingText.Size = new System.Drawing.Size(200, 19);
            this.chartLoadingText.TabIndex = 23;
            this.chartLoadingText.Text = "Generating Respective Chart";
            this.chartLoadingText.Visible = false;
            // 
            // chartProgressbar
            // 
            this.chartProgressbar.Depth = 0;
            this.chartProgressbar.Location = new System.Drawing.Point(368, 410);
            this.chartProgressbar.MouseState = MaterialSkin.MouseState.HOVER;
            this.chartProgressbar.Name = "chartProgressbar";
            this.chartProgressbar.Size = new System.Drawing.Size(292, 5);
            this.chartProgressbar.TabIndex = 22;
            this.chartProgressbar.Visible = false;
            // 
            // MILO
            // 
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1125, 750);
            this.Controls.Add(this.materialTabControl1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DrawerBackgroundWithAccent = true;
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MILO";
            this.Padding = new System.Windows.Forms.Padding(3, 92, 3, 4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MILO";
            this.materialTabControl1.ResumeLayout(false);
            this.sarcasticMiloIntroduction.ResumeLayout(false);
            this.sarcasticMiloIntroduction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.recipeSuggestion.ResumeLayout(false);
            this.recipeSuggestion.PerformLayout();
            this.recipeResultCard.ResumeLayout(false);
            this.recipeResultCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.locationFinder.ResumeLayout(false);
            this.locationFinder.PerformLayout();
            this.locationResult.ResumeLayout(false);
            this.materialCard4.ResumeLayout(false);
            this.materialCard4.PerformLayout();
            this.materialCard3.ResumeLayout(false);
            this.materialCard3.PerformLayout();
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.filmRoulette.ResumeLayout(false);
            this.filmRoulette.PerformLayout();
            this.movieResultCard.ResumeLayout(false);
            this.movieResultCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movieImage)).EndInit();
            this.materialCard6.ResumeLayout(false);
            this.materialCard6.PerformLayout();
            this.materialCard5.ResumeLayout(false);
            this.materialCard5.PerformLayout();
            this.chartPresentation.ResumeLayout(false);
            this.chartPresentation.PerformLayout();
            this.pieChartCard.ResumeLayout(false);
            this.lineChartCard.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage locationFinder;
        private System.Windows.Forms.TabPage recipeSuggestion;
        private System.Windows.Forms.TabPage filmRoulette;
        private System.Windows.Forms.TabPage sarcasticMiloIntroduction;
        private System.Windows.Forms.TabPage chartPresentation;
        private System.Windows.Forms.ImageList imageList1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 recipeSuggestionInput;
        private MaterialSkin.Controls.MaterialButton sendRecipe;
        private MaterialCard recipeResultCard;
        private MaterialLabel recipeResultTitle;
        private MaterialMultiLineTextBox recipeResultDescription;
        private PictureBox pictureBox1;
        private MaterialProgressBar recipeProgessbar;
        private MaterialLabel recipeGenerationLoader;
        private MaterialLabel materialLabel6;
        private MaterialLabel materialLabel5;
        private MaterialLabel materialLabel4;
        private MaterialCard materialCard1;
        private MaterialLabel materialLabel7;
        private MaterialComboBox holidayTypeCombo;
        private MaterialCard materialCard4;
        private MaterialComboBox holidayBudgetCombo;
        private MaterialLabel materialLabel10;
        private MaterialCard materialCard3;
        private MaterialComboBox holidayTransportationCombo;
        private MaterialLabel materialLabel9;
        private MaterialCard materialCard2;
        private MaterialComboBox holidayDurationCombo;
        private MaterialLabel materialLabel8;
        private MaterialButton getTripResult;
        private MaterialTextBox locationPlace;
        private MaterialTabControl locationResult;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private MaterialTabSelector locationSelector;
        private MaterialLabel tripGenerationLoaderText;
        private MaterialProgressBar tripGenerationLoader;
        private PictureBox pictureBox2;
        private MaterialButton miloIntroductionButton;
        private MaterialLabel materialLabel12;
        private MaterialLabel materialLabel11;
        private MaterialMaskedTextBox miloQuestionInput;
        private MaterialButton askMiloButton;
        private MaterialLabel movieLoadingText;
        private MaterialProgressBar movieProgressBar;
        private MaterialButton getMovieButton;
        private MaterialTextBox favouriteMovieInput;
        private MaterialLabel materialLabel14;
        private MaterialLabel materialLabel15;
        private MaterialLabel materialLabel16;
        private MaterialCard materialCard6;
        private MaterialComboBox streamingProviderComboBox;
        private MaterialLabel materialLabel18;
        private MaterialCard materialCard5;
        private MaterialComboBox genreComboBox;
        private MaterialLabel materialLabel17;
        private MaterialCard movieResultCard;
        private MaterialLabel genre;
        private MaterialLabel releaseDate;
        private PictureBox movieImage;
        private MaterialMultiLineTextBox plot;
        private MaterialLabel movieTitle;
        private MaterialLabel streamingProviders;
        private MaterialLabel director;
        private MaterialLabel actors;
        private MaterialLabel imdbRating;
        private MaterialCard pieChartCard;
        private MaterialCard lineChartCard;
        private MaterialLabel materialLabel13;
        private MaterialLabel materialLabel19;
        private MaterialLabel materialLabel20;
        private LiveCharts.WinForms.CartesianChart lineChart1;
        private LiveCharts.WinForms.PieChart pieChart1;
        private MaterialButton chartButton;
        private MaterialTextBox chartInput;
        private MaterialLabel chartLoadingText;
        private MaterialProgressBar chartProgressbar;
    }
}

