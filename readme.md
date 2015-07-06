# .NET Weather Test
Create an application/website which given a location will display an aggregated weather result (temperature and wind speed) from the two supplied APIs. 

Your application/website should:
 - Allow the user to choose which measurement unit they want results displayed in (mph, kph, celsius, fahrenheit).
 - Allow for more APIs to be easily added in the future.
 - Handle one or more of the APIs being down or being slow to respond.
 - Given temperatures of 10c from bbc and 68f from accuweather when searching then display either 15c or 59f (the average).
 - Given windspeeds of 8kph from bbc and 10mph from accuweather when searching then display either 12kph or 7.5mph (the average).
 - Given an empty or null location when searching then do not make a request to the APIs.
 - Handle HTTP error codes from the APIs without displaying these to the user.

This challenge should only take you a few hours to complete, 
should be written in a way that shows you have a good understanding of design patterns and SOLID principles 
and you will be expected to have written unit tests to cover any logic.

If you feel the brief is unclear in any way or you have any questions over scope, please feel free to contact me. 
Should there be any aspects of your code you would like to refactor given more time, 
please add some comments covering what you would have done.
