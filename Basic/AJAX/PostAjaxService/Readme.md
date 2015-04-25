##### This sample demonstrates how to use Windows Communication Foundation (WCF) to create a basic ASP.NET Asynchronous JavaScript and XML (AJAX) service (a service that you can access using JavaScript code from a Web browser client).
----------
 
##### Output
![img](https://raw.githubusercontent.com/niisar/WCF/master/Basic/AJAX/PostAjaxService/PostAjaxService.JPG)

##### Code
``` cs
[ServiceContract(Namespace = "PostAjaxService")]
    public interface ICalculator
    {        [WebInvoke]
        double Add(double n1, double n2);
        //Other operations omitted…
    }
```

 - If the WebInvokeAttribute attribute is applied on an operation, or the WebGetAttribute attribute is not applied, the default HTTP verb (“POST”) is used.
 - use POST requests for all operations where caching is not appropriate.
 - Unlike GET requests, you cannot invoke POST services from the browser. For example, navigating to ` http://localhost/ServiceModelSamples/service.svc/Add?n1=100&n2=200 ` results in an error, because the POST service expects the n1 and n2 parameters to be sent in the message body—in the JSON format—and not in the URL.

> **[Ref.](https://msdn.microsoft.com/en-us/library/bb410768(v=vs.110).aspx)**

