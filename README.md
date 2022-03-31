# BestWorkshop.SearchCitiesTests
Skeleton project for the Bit BEST workshop "Testarea Automata – ingredientul unui software de success".

Prerequisites:
* Personal laptop
* Visual Studio 2019 - 2022
* Basic C# knowledge 

Cities Finder
Implement a city search functionality. The function takes a string (search text) as input and returns the found cities which corresponds to the search text.

Prerequisites
City names: Paris, Bucharest, Budapest, Skopje, Brasov, Rotterdam, Valencia, Vancouver, Amsterdam, Vienna, Sydney, New York City, London, Bangkok, Hong Kong, Dubai, Rome, Istanbul

Requirements
1. If the search text is fewer than 2 characters, then should return no results. 
(It is an optimization feature of the search functionality.)

2. If the search text is equal to or more than 2 characters, then it should return all the city names starting with the exact search text.
For example for search text “Va”, the function should return Valencia and Vancouver

3. The search functionality should be case insensitive

4. The search functionality should work also when the search text is just a part of a city name
For example “aso” should return “Brasov” city
