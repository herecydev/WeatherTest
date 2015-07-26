# .NET Weather Test
## Brief
Create an application/website which given a location will display an aggregated weather result (temperature and wind speed) from the two supplied APIs. 

Your application/website should:
 - Given temperatures of 10c from bbc and 68f from accuweather when searching then display either 15c or 59f (the average).
 - Given windspeeds of 8kph from bbc and 10mph from accuweather when searching then display either 12kph or 7.5mph (the average).
 - Gracefully handle one or more of the APIs being down or being slow to respond.
 - Gracefully handle HTTP error codes from the APIs.
 - Allow the user to choose which measurement unit they want results displayed in (eg. mph, kph, celsius, fahrenheit).

This challenge should only take you a few hours to complete, 
should be written in a way that shows you have a good understanding of object oriented programming, design patterns and SOLID principles and you will be expected to write unit tests to cover any logic.

If you feel the brief is unclear in any way or you have any questions over scope, please feel free to contact me. 
Should there be any aspects of your code you would like to refactor given more time, 
please add some comments covering what you would have done.

## Swagger
To help consume both of the supplied APIs, [Swagger](http://swagger.io/) and [SwaggerUi](http://swagger.io/swagger-ui/) have been implemented. By default when the APIs are running you can access SwaggerUI via 'http://API URL/swagger/ui'.

## Prerequisites
You will need to use Visual Studio 2015 to open and run the provided APIs.
