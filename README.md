# OpenAI API POC

This project is a proof of concept for utilizing the OpenAI API. The goal of this project was to experiment with different use cases for the API, such as generating recipe, movie, and travel suggestions, as well as implementing a sarcastic chatbot named Milo and a chart displayer based on user input. The UI was implemented in WinForms.

## Getting Started

### Prerequisites

To run this project, you will need the following:

- Visual Studio (version 2019 or later)
- .NET Framework (version 4.7.2 or later)

### Installation

1. Clone the repository to your local machine.
2. Open the project in Visual Studio.
3. Create and change API Keys for Open AI API and Google Text-to-Speech API
4. Build the solution.
5. Run the application.

## Usage

When you run the application, you will see a main menu with several options:

- Recipe Suggestions
- Movie Suggestions
- Travel Suggestions
- Milo (Sarcastic Chatbot)
- Chart Displayer

### Recipe Suggestions

Selecting this option will generate a recipe suggestion based on a query entered by the user. The API will return a list of recipes that match the query, and the user can select one of them to view the recipe details.

### Movie Suggestions

Selecting this option will generate a movie suggestion based on a query entered by the user. The API will return a list of movies that match the query, and the user can select one of them to view the movie details.

### Travel Suggestions

Selecting this option will generate a travel suggestion based on a query entered by the user. The API will return a list of travel destinations that match the query, and the user can select one of them to view more details about the destination.

### Milo (Sarcastic Chatbot)

Selecting this option will launch the sarcastic chatbot named Milo. Milo will respond to user input with sarcastic and witty comments. Users can continue chatting with Milo until they choose to exit the chatbot.

### Chart Displayer

Selecting this option will allow the user to input data to be displayed in a chart. The user can input the data as comma-separated values, and the application will display the data in a chart.

## Built With

- .NET Framework
- WinForms
- OpenAI API

## Authors

- David Obermair

## License

This project is licensed under the MIT License - see the LICENSE file for details.

## Acknowledgments

- The OpenAI team for providing the API used in this project.
