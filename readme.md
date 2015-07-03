#.net Weather Test
Create an application/website which given a location will display the aggregated weather result from the two supplied API's. 

Your application/website should:
 - Allow the user to choose which measurement unit they want results displayed in (mph, kph, celsius, fahrenheit).
 - Consider other measurement units may be added in the future.
 - Consider that more API's will be added in the future.
 - Consider how to handle one or more of the API's being down or being slow to respond.
 - Given temperatures of 10*c from bbc and 68*f from accuweather when searching then display either 15*c or 59*f (the average).
 - Given windspeeds of 8kph from bbc and 10mph from accuweather when searching then display either 12kpb or 7.5mph (the average).
 - Given an empty or null location when searching then not request from the API's.
 - Handle HTTP error codes from the API's without displaying these to the user.

This challenge should only take you a few hours to complete, 
should be written in a way that shows you have a good understanding of design patterns and SOLID principles 
and you will be expected to have written unit tests to cover any logic.

If you feel the brief is unclear in any way or you have any questions over scope, please feel free to contact me. 
Should there be any aspects of your code you would like to refactor given more time, 
please add some comments covering what you would have done.