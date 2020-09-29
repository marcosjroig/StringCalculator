# String Calculator
This code is a .NET Core 3.1 console application.

## Requirements for Installation
- Visual Studio 2019 or VS Code
- .NET Core 3.1 framework

## Considerations about the code
- I created a config file appsettings.json that allows to give flexbility to the code. So using regex, if there is a need of change any of the patterns it can be done my changing the config file without compiling the code
- I added also Dependency injection to the project. 
- Validations: the first part of the code it validates that the input is correct, but it does not check if the number is bigger than 1000 or is negative, as I wanted to give some flexibility to the code, this things are checked in a second stage.
- The negative numbers: are checked in Exceptions. Even if I am not triggering any exception I am just displying the error because the number is negative.
- Ignore list: inside of the folder Ignore, is place the logic the is used to remove a number from the list if this does not follow the regex pattern. Again, this pattern is easily configured from the config file.
- The class Calculations hold most of the logic for making a calculation.
- And the Calculator I did it with the option to add more operations using delagates (actually it is a Func). That why the calculator is extensible if in the future we want to add more operation in addition to "sum".
- In the class "ConsoleApplication" I had hardcoded a few input strings in order to avoid complexity of entering values manually and the reading it.
- Most of the classes does not have more than 10 lines, so I tried to create separation of concerns in this code.
- There is a test project also where most of the classes are tested.
- The code can be improved further depending of the needs and the time available.
- Note: I was not able to match one of the regex, that verify numbers bigger than 1000, it works well until 999 but all the 4 digits numbers are considered big. This is something can be be fixed quickly having some more time. 

