# EagleRock Traffic Monitoring Solutions
<li><a href="#acknowledgments">Acknowledgments</a></li>
  </ol>
</details>


<!-- ABOUT THE PROJECT -->
## About The Project

EagleRock Traffic Monitoring Solutions provide a ASP .Net core based API that provides functionality to

1) Allow up to three(3) authorised agents to send observed traffic data to be stored by EagleRock
2) Provide a summary of the current state of agents who have submitted data to EagleRock

API's
http: POST /Traffic/

Required Data

 # Reporting unit's unique identifier
 string ReportingUnitId

 # Data reporting location (latitude / longitude)
 GeoLocation Location  

 # Data reporting time (UTC)  
 DateTime ReportedAt

 #Road identifier/name
 string RoadId

 #Road flow rate (vehicles/second)
 VehicleFlowRate 

 # Average vehicle speed (m/s)
VehicleAverageSpeed

 /// <summary>
 /// vehicle direction (heading) (degrees)
 /// </summary>
 VehicleHeading

# JSON Example
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



http: Get /BotStatus/

<p align="right">(<a href="#readme-top">back to top</a>)</p>

Example Response
  {
    "id": "Daddy Cool",
    "isActive": true,
    "currentLocation": {
      "latitude": 142.4,
      "longitude": -35.51
    },
    "lastReport": {
      "id": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
      "reportingUnitId": "Daddy Cool",
      "location": {
        "latitude": 142.4,
        "longitude": -35.51
      },
      "reportedAt": "2025-07-20T07:28:11.339Z",
      "roadId": "Warrego Hwy",
      "vehicleFlowRate": 6,
      "vehicleAverageSpeed": 31.4,
      "vehicleHeading": 265.4
    }6
  }



### Built With



<p align="right">(<a href="#readme-top">back to top</a>)</p>


### Prerequisites
* Docker For Desktop
* Redis Server

