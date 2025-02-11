﻿Feature: OpenSensMapGetMeasurements

Scenario Outline: Get list of Measurements form Box
	Given Setup a new connection to endoint 'https://api.opensensemap.org/boxes'
	And Setup new POST request to endpint '/data'
	And Open a json file '<json>' and prepare with parameters '<jsonParam>'
	And Send prepared POST requests <async>
	Then Response status is '<statusCode>'
	Examples: 
| json               | jsonParam | statusCode          | async |
| Measurements2.json | json      | OK                  | async |
| Measurements2.json | csv       | OK                  | async |
| Measurements2.json | txt       | UnprocessableEntity | async |
| Measurements2.json | json      | OK                  |       |
| Measurements.json  |           | OK                  |       |

Scenario Outline: Get list of Measurements form Box And Save it at database
	Given Setup a new connection to endoint 'https://api.opensensemap.org/boxes'
	And Setup new POST request to endpint '/data'
	And Open a json file '<json>' and prepare with parameters '<jsonParam>'
	And Send prepared POST requests <async>
	Then Response status is '<statusCode>'
	Given Connect to database
	Given Insert to database first row of retured values
	And Select first row
	Examples: 
| json               | jsonParam | statusCode          | async |
| Measurements2.json | json      | OK                  | async |

Scenario Outline: Get list of specific Measurements form Box 
	Given Setup a new connection to endoint 'https://api.opensensemap.org/boxes/'
	And Setup new POST request to endpint '/data'
	And Open a json file '<json>' and prepare with parameters '<jsonParam>'
	And Send prepared POST requests <async>
	Then Response status is '<statusCode>'
	Examples: 
| json               | jsonParam                                                   | statusCode          | async |
| Measurements3.json | json;sensorId,createdAt,value,boxId,phenomenon              | OK                  | async |
| Measurements3.json | json;sensorId,createdAt,value,boxId,phe                     | UnprocessableEntity | async |
| Measurements3.json | json;sensorId,createdAt,value,boxId,phenomenon,unit,boxName | OK                  | async |
| Measurements3.json | json;createdAt,value                                        | OK                  | async |
| Measurements3.json | json;                                                       | UnprocessableEntity | async |


Scenario Outline: Get last Measurements form Box 
	Given Setup a new connection to endoint 'https://api.opensensemap.org/boxes/'
	And Setup new GET request to endpint '{0}/sensors'
	Given Prepare get url using '<parameters>' 
	And Send prepared GET requests <async>
	Then Response status is '<statusCode>'
	Examples: 
	| async | statusCode | parameters               |
	|       | OK         | 5bb1dab2043f3f001ba31b69 |
	| async | OK         | 5bb1dab2043f3f001ba31b69 |
	| async | NotFound   | 5bb1dab2043f3f001ba31b6b |
