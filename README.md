# videoService
We adpot a web api micro service to satisfy with the requirment of dev team.
Here is the related component archtect for video serivce:

![Components arch of video service](https://user-images.githubusercontent.com/5415327/185826347-d512b6ca-ec43-44bf-a31f-79480da9983e.jpg)

Here is the detail logic for what video service does?
1. Video service will consume the event from CMS service and persisted video metadata in database.
2. Video service will expose 2 types of API for dev team to retrieve video metadata and video stream.
![Video workflow](https://user-images.githubusercontent.com/5415327/185826434-e61d53cb-8a00-422b-bff4-c6b084e565ee.jpg)

Here is the DB design for video service:
![Database design](https://user-images.githubusercontent.com/5415327/185830943-5bf23d67-04c6-499c-a2af-2594a4de14c0.jpg)