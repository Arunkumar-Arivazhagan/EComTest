In this repo the following tasks are covered.

Key points:
- Utilized some of the advanced concepts like Dependency Injection, Seperation of context to isolate TestSettings and DriverFixture.
- Isolate test from the framework and settings, by adding reference to the dependencies to one another[project to project].
- Tried intergrating Dependcy injection with Specflow, can be achieved by finding work around.

## Automation Testing with Selenium WebDriver and C#:
Test Scenario:
Write a C# script using Selenium WebDriver to automate the following scenario: Log
in to a demo website (e.g., http://demo.testfire.net/login.jsp) and validate a
successful login.

## BDD (Behavior-Driven Development) with SpecFlow:
Test Scenario:
Write a BDD scenario using Gherkin syntax for testing the search functionality of a
fictitious e-commerce website.

## Automated Test Script (Data-Driven Approach):
Test Scenario:
Create an automated test script using C# and Selenium WebDriver to perform a
data-driven test on a login page. You will have a CSV file containing multiple sets of
login credentials. Automate the login process for each set of credentials and log the
results.
- Instead of using external file, I have used [Theory] since there were only 2 login credentials provided by the creator.

## NUnit Testing for a C# Library:
Test Scenario:
Given a simple C# library that provides math functions (e.g., addition, subtraction),
write NUnit test cases to validate the correctness of these functions.
