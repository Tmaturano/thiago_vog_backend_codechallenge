# Vog App Challenge

This solution contains a set of.Net Core projects (API, Console, libraries and AWS Lambda) using C# for the Vogg App backend challenge.

## Installation

Clone this project and open the solution in Visual Studio 2019 and hit Build -> Rebuild Solution.

It requires to have docker installed and running to run the API project.


## Usage

* API: Select `VogCodeChallenge.API` as startup project. It uses InMemory database with Entity Framework and offers two HttpGet Endpoints `/api/employees` and `/api/employees/department/{departmentId}`
* Console: Select `VogCodeChallenge.Console` as startup project. It has two classes `Program` (to execute a sample to iterate a simple list using a `do while` loop) and `QuestionClass` (contains the `IterateList` and `TESTModule` implementations).
* Unit Test: Select `VogCodeChallenge.Console.Test` as startup project and run the test cases for the function `TESTModule` of the `QuestionClass`.
* AWS Lambda: Select `VogCodeChallenge.AWSLambda` as startup project. This project uses a simple template using AWS Lambda for a DynamoDBEvent.

## License
[MIT](https://choosealicense.com/licenses/mit/)
