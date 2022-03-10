# _Meal Prep Application_

#### By:

* _Michael Watkins_


#### _An mvc web application that displays recipes and offers a database to store recipes for specific dates._

## Technologies Used:
* _HTML_
* _C#_
* _CSS_
* _Markdown_
* _EntityFrameworkCore_
* _Razor View Engine_
* _ASP.Net Core MVC_
* _Spoonacular API_

## Description

This mvc application consists of two pieces. In the first piece there is a form to submit an ingredient to an api call. The api call responds with three different meals to choose from. Then once someone has chosen three different meals for each time of day they can go to the database form page and create a meal plan. You can then see all your meal plans in an index page.

## Setup/Installation Requirements

* _Install .NET Framework_
* _Navigate to https://github.com/MichaelHWatkins/MealPrep.Solution_
* _Click on the green "Code" button and copy the repository URL or click on the copy button_
* _Open the terminal on your desktop_
* _Once in the terminal, use it to navigate to your desktop folder_
* _Once inside your desktop folder, use the command "git clone https://github.com/MichaelHWatkins/MealPrep.Solution"_
* _After cloning the project, navigate into it using the command `"cd MealPrep.Solution"`_
* _Use the command `"git remote -v"` to confirm the creation of the new local repository_
* _Open the project with the code editor of your choice_
* _Navigate to MealPrep directory and enter command `"dotnet restore"`_
* _Obtain an api key from Spoontacular by going to their website an creating an account._
* _In EnvironmentVariables add your api key to the corresponding api variable._
```
   public static string ApiKey = "[YOUR-SPOONACULAR-API-KEY-HERE]";
   
```

## Using the Application
After following the Setup/Installation steps above:
 * Navigate to the root directory.
 * Start the application in a server with the command _`"dotnet run"`_.

## Known Bugs

* _No known bugs_

## License

[MIT](https://opensource.org/licenses/MIT)

Copyright (c) 2022 Michael Watkins

## Contact Information


Michael Watkins: <michaelhugheswatkins@gmail.com>