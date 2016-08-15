# WCF – Windows Communication Foundation
WCF, Microsoft platform for building distributed and interoperable application.

Project 1: Creating a WCF Service - Tutorial
HelloService
Clients\HelloWebClient
Clients\HelloWindowsClient

Tutorial done from Link:
https://www.youtube.com/watch?v=UcmD1SfIayM&list=PL6n9fhu94yhVxEyaRMaMN_-qnDdNVGsL1&index=3

NOTE:
- Hosting WCF on console application.
- Two Clients using WCF services.
- WCF services has 2 endpoints. 
- One client using XML Message format over HTTP Protocol - Client Web Application
- Other client using Binary Message format over TCP Protocol - Client Window Application
- Run VisualStudio as Administrator. Since,  binding to a tcp port requires administrative privileges.

--------------------------------------------------------------------------------------


Project 2: WCF DataContract and DataMember

Tutorial done from Link:
https://www.youtube.com/watch?v=RPgTKzSGcKY&index=6&list=PL6n9fhu94yhVxEyaRMaMN_-qnDdNVGsL1

 - if you want to have explicit control on what fiels and properties get serialized the use DataContract and DataMember.
 - WCF service using ADO.Net to access database Sample, table tblEmployee for read and write operation
 - WebForm client to read and write database using WCF service
 - WCF hosted on console application.
 
 
--------------------------------------------------------------------------------------

Project 3: WCF REST Service

Tutorial done fro Link:
https://www.youtube.com/watch?v=AMO6aIXRp1U

-[WebInvoke] -> service operation is invoke operation and can be called by REST programming model.
 

