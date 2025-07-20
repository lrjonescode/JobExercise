# EagleRock Traffic Monitoring Solutions
<li><a href="#acknowledgments">Acknowledgments</a></li>
  </ol>
</details>


<!-- ABOUT THE PROJECT -->
## About The Project

EagleRock Traffic Monitoring Solutions provide a ASP .Net core based API that provides functionality to

1) Allow up to three(3) authorised agents to send observed traffic data to be stored by EagleRock
2) Provide a summary of the current state of agents who have submitted data to EagleRock

## API's

### POST /Traffic/

### Required Request Data

 #### Reporting unit's unique identifier
 string ReportingUnitId

 #### Data reporting location (latitude / longitude)
 GeoLocation Location  

 #### Data reporting time (UTC)  
 DateTime ReportedAt

 #### Road identifier/name
 string RoadId

 #### Road flow rate (vehicles/second)
 VehicleFlowRate 

 #### Average vehicle speed (m/s)
VehicleAverageSpeed

 #### vehicle direction (heading) (degrees)
 VehicleHeading

 #### Curl Example

curl -X 'POST' \
  'http://localhost:32780/Traffic' \
  -H 'accept: */*' \
  -H 'Content-Type: application/json' \
  -d '{
  "reportingUnitId": "Daddy Cool",
  "location": {
    "latitude": -34.41,
    "longitude": 141.76
  },
  "reportedAt": "2025-07-20T23:24:43.122Z",
  "roadId": "CreekRd",
  "vehicleFlowRate": 7,
  "vehicleAverageSpeed": 17.1,
  "vehicleHeading": 5.4
}

### Response
201 Created if data is successfully received by EagleRock

### http: Get /BotStatus/

### Required Request Data: None

curl -X 'GET' \
  'http://localhost:32780/BotStatus' \
  -H 'accept: text/plain'

####  Example Response
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

