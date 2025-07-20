# EagleRock Traffic Monitoring Solutions
<li><a href="#acknowledgments">Acknowledgments</a></li>
  </ol>
</details>


<!-- ABOUT THE PROJECT -->
## About The Project

EagleRock Traffic Monitoring Solutions provide a ASP .Net core based API that provides functionality to

1) Allow authorised agent to send observed traffic data to be stored by EagleRock
2) Provide a summary of the current state of agents ho have submitted data to EagleRock

API's
http: POST /Traffic/

Required Data

 /// <summary>
 /// Reporting unit's unique identifier
 /// </summary>
 string ReportingUnitId

 /// <summary>
 /// data reporting location (latitude / longitude)
 /// </summary>
 GeoLocation Location  

 /// <summary>
 /// data reporting time (UTC)
 /// </summary>     
 ateTime ReportedAt

 /// <summary>
 /// Road identifier/name
 /// </summary>
 string RoadId

 /// <summary>
 /// Road flow rate (vehicles/second)
 /// </summary>
 VehicleFlowRate 

 /// <summary>
 /// Average vehicle speed (m/s)
 /// </summary>
VehicleAverageSpeed

 /// <summary>
 /// vehicle direction (heading) (degrees)
 /// </summary>
 VehicleHeading

#JSON Example
{
  "reportingUnitId": "EagleRockAgent",
  "location": {
    "latitude": 142.89,
    "longitude": 34.15
  },
  "reportedAt": "2025-07-20T07:11:12.827Z",
  "roadId": "CreekRd",
  "vehicleFlowRate": 6,
  "vehicleAverageSpeed": 27.6,
  "vehicleHeading": 171.6
}


<p align="right">(<a href="#readme-top">back to top</a>)</p>



### Built With



<p align="right">(<a href="#readme-top">back to top</a>)</p>


### Prerequisites
* Docker For Desktop
* Redis Server

