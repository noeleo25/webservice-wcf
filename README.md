# webservice-wcf
_.NET WCF (SOAP) web service and client example_

Solution includes 3 projects:

* **Web Service** : CodigoFacilitoWS (Web App)
  * ICourseService.cs
  * CourseService.svc.cs
  
  NOTE: To test web service
  1. In Solution Explorer go to _CourseService.svc.cs_
  2. Click F5 to run WCF Test Client

* **Client** : CourseClient (Console App)
  * Data (directory)
    * CourseDataService.cs
  * Program.cs

* **Model and Data Service** : Data (Class Library)
  * Course.cs
  * CourseDataService.cs
