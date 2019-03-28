# webservice-wcf
_.NET WCF (SOAP) web service and client example_

Solution includes 3 projects:

* _Web Service_ : CodigoFacilitoWS (Web App)
  * ICourseService.cs
  * CourseService.svc.cs
  
  NOTE: To test web service
  1. In Solution Explorer go to _CourseService.svc.cs_
  2. Click F5 to run WCF Test Client

* _Client_ : CourseClient (Console App)
  * Data (directory)
    * CourseDataService.cs
  * Program.cs

* _Model and Data Service_ : Data (Class Library)
  * Course.cs
  * CourseDataService.cs
