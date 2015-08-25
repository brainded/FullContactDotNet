# FullContactDotNet [![Build status](https://ci.appveyor.com/api/projects/status/5jj02pgboarvicun/branch/master?svg=true)](https://ci.appveyor.com/project/brainded/fullcontactdotnet/branch/master)
A C# client for the Full Contact Api.

## Nuget Package
You can find the Nuget Package at https://www.nuget.org/packages/FullContactDotNet/

To Install use the package manager command: Install-Package FullContactDotNet -Pre

## ApiKey
To use this client you will need an ApiKey from FullContact. Once the ApiKey is aquired, you can either set it in your configuration as an App Setting or supply it upon creation of the Api.

## Quick Overview

To get a handle on what FullContact provides check out their [Api documentation](https://www.fullcontact.com/developer/docs/). This project is a work in progress but it does currently provide the Account, Email, Name, Organization and Person Apis.

A quick example of how to use the Api:

```c#
var emailApi = FullContactEmailApi("your-api-key-here");
var result = emailApi.DetectDisposableEmail("bobloblaw@example.com");
```

## Error Handling

All response objects inherit from the FullContactResponse object which gives them the HttpStatusCode and the corresponding message from FullContact to describe what happened with the response. If it is a 200, there is data provided. If it is a 202, they need to process the request and no data is provided. Finally if there is a 404, nothing was found.

In the special instances of a Forbidden response or the RestSharp library had an exception, a FullContactApiException will be thrown to tell the user something exceptional happened.
