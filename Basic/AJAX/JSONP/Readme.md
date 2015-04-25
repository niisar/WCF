![img]([https://raw.githubusercontent.com/niisar/WCF/master/Basic/AJAX/JSONP/img_jsonp.JPG])

### This sample demonstrates how to support JSON with Padding (JSONP) in WCF REST services. 
---------
 - The sample includes a Web page that dynamically adds a script block after the page has been rendered in the browser. 
 - This script block calls a WCF REST service that has a single operation, GetCustomer. 
 - The WCF REST service returns a customer’s name and address wrapped in a callback function name. 
 - The injection of the script tag and the execution of the callback function is automatically handled by the ASP.NET AJAX ScriptManager control.
 
##### The Web page can call the WCF REST service because the service is using the WebScriptEndpoint with crossDomainScriptAccessEnabled set to true.
``` xml
      <system.serviceModel>
        <serviceHostingEnvironment aspNetCompatibilityEnabled="true"/>
        <standardEndpoints>
          <webScriptEndpoint>
            <standardEndpoint name="" crossDomainScriptAccessEnabled="true"/>
          </webScriptEndpoint>
        </standardEndpoints>
      </system.serviceModel>
```
##### In the sample, the Web page calls the WCF REST service with the following URI.

	http://localhost:33695/CustomerService/GetCustomer?callback=Sys._json0

##### Returns JSONP

	Sys._json0({"__type":"Customer:#Microsoft.Samples.Jsonp","Address":"1 Example Way","Name":"Bob"});
> ### _My Notes_
> **System.ServiceModel.Activation.WebScriptServiceHostFactory**
	Automatically adds an ASP.NET AJAX endpoint to a service, without requiring configuration, in a managed hosting environment that dynamically activates host instances for the service in response to incoming messages.
    

> **[Ref.](https://msdn.microsoft.com/en-us/library/ee834511(v=vs.110).aspx)**

