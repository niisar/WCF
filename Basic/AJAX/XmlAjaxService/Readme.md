#####  Demonstrates how to use Windows Communication Foundation (WCF) to create an Asynchronous JavaScript and XML (AJAX) service that returns either JavaScript Object Notation (JSON) or XML data. You can access an AJAX service by using JavaScript code from a Web browser client..
----------
 
##### Output
![img](https://raw.githubusercontent.com/niisar/WCF/master/Basic/AJAX/XmlAjaxService/XmlAjaxService.jpg)

 - To enable the use of non-ASP.NET AJAX clients, use WebServiceHostFactory (not WebScriptServiceHostFactory) in the .svc file. WebServiceHostFactory adds a WebHttpEndpoint standard endpoint to the service. The endpoint is configured at an empty address relative to the .svc file; this means that the address of the service is ` http://localhost/ServiceModelSamples/service.svc `, with no additional suffixes other than the operation name.

> ### _Note_
> Getting Error not able to replicate
> 
> ![img](https://raw.githubusercontent.com/niisar/WCF/master/Basic/AJAX/XmlAjaxService/error.JPG)
> 
> **[Ref.](https://msdn.microsoft.com/en-us/library/bb472488(v=vs.110).aspx)**

