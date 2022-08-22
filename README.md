# Video Service
I adpot a web api micro service to satisfy with the requirment from dev team.
Here is the related component architecture for video service:
![Components arch of video service](https://user-images.githubusercontent.com/5415327/185826347-d512b6ca-ec43-44bf-a31f-79480da9983e.jpg)

<h3>Here is the detail logic for what video service does?</h3>
1. Video service will consume the event from CMS service and persisted video metadata in database.
2. Video service will expose 2 types of API for dev team to retrieve video metadata and video stream.
![Video workflow](https://user-images.githubusercontent.com/5415327/185826434-e61d53cb-8a00-422b-bff4-c6b084e565ee.jpg)

<h3>Here is the DB design for video service:</h3>
![Database design](https://user-images.githubusercontent.com/5415327/185830943-5bf23d67-04c6-499c-a2af-2594a4de14c0.jpg)

<h3>Here is the project structure which follows the Domain Drive Design.</h3>
![image](https://user-images.githubusercontent.com/5415327/185861303-77797e50-e9fd-4a75-a5f2-39121e13bb06.png)
