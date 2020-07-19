# Cloudmersive.APIClient.NET.VideoAndMediaServices - the C# library for the videoapi

The video APIs help you convert, encode, and transcode videos.

This C# SDK is for the [Cloudmersive Video and Media Services API](https://cloudmersive.com/video-and-media-services-api):

- API version: v1
- SDK version: 3.0.1
- Build package: io.swagger.codegen.languages.CSharpClientCodegen

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

<a name="dependencies"></a>
## Dependencies
- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.2.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

<a name="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using Cloudmersive.APIClient.NET.VideoAndMediaServices.Api;
using Cloudmersive.APIClient.NET.VideoAndMediaServices.Client;
using Cloudmersive.APIClient.NET.VideoAndMediaServices.Model;
```
<a name="packaging"></a>
## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out Cloudmersive.APIClient.NET.VideoAndMediaServices.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.

<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.VideoAndMediaServices.Api;
using Cloudmersive.APIClient.NET.VideoAndMediaServices.Client;
using Cloudmersive.APIClient.NET.VideoAndMediaServices.Model;

namespace Example
{
    public class Example
    {
        public void main()
        {

            // Configure API key authorization: Apikey
            Configuration.Default.ApiKey.Add("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Apikey", "Bearer");

            var apiInstance = new VideoApi();
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input file to perform the operation on.
            var fileUrl = fileUrl_example;  // string | Optional; URL of a video file being used for conversion. Use this option for files larger than 2GB. (optional) 
            var maxWidth = 56;  // int? | Optional; Maximum width of the output video, up to the original video width. Defaults to 250 pixels. (optional) 
            var maxHeight = 56;  // int? | Optional; Maximum height of the output video, up to the original video width. Defaults to 250 pixels. (optional) 
            var preserveAspectRatio = true;  // bool? | Optional; If false, the original video's aspect ratio will not be preserved, allowing customization of the aspect ratio using maxWidth and maxHeight, potentially skewing the video. Default is true. (optional) 
            var frameRate = 56;  // int? | Optional; Specify the frame rate of the output video. Defaults to 24 frames per second. (optional) 
            var extendProcessingTime = true;  // bool? | Optional; If true, will allow additional processing time for the video file conversion, using one API call per additional minute over the 5 minute default processing time, up to a maximum of 25 total minutes. This is generally necessary for files larger than 500 MB or longer than 30 minutes. (optional) 
            var startTime = 2013-10-20T19:20:30+01:00;  // DateTime? | Optional; Specify the desired starting time of the GIF video in TimeSpan format. (optional) 
            var timeSpan = 2013-10-20T19:20:30+01:00;  // DateTime? | Optional; Specify the desired length of the GIF video in TimeSpan format. Limit is 30 minutes. (optional) 

            try
            {
                // Convert Video to Animated GIF format.
                byte[] result = apiInstance.VideoConvertToGif(inputFile, fileUrl, maxWidth, maxHeight, preserveAspectRatio, frameRate, extendProcessingTime, startTime, timeSpan);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VideoApi.VideoConvertToGif: " + e.Message );
            }

        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://api.cloudmersive.com*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*VideoApi* | [**VideoConvertToGif**](docs/VideoApi.md#videoconverttogif) | **POST** /video/convert/to/gif | Convert Video to Animated GIF format.
*VideoApi* | [**VideoConvertToMov**](docs/VideoApi.md#videoconverttomov) | **POST** /video/convert/to/mov | Convert Video to MOV format.
*VideoApi* | [**VideoConvertToMp4**](docs/VideoApi.md#videoconverttomp4) | **POST** /video/convert/to/mp4 | Convert Video to MP4 format.
*VideoApi* | [**VideoConvertToWebm**](docs/VideoApi.md#videoconverttowebm) | **POST** /video/convert/to/webm | Convert Video to WEBM format.
*VideoApi* | [**VideoGetInfo**](docs/VideoApi.md#videogetinfo) | **POST** /video/convert/get-info | Get detailed information about a video or audio file


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.MediaInformation](docs/MediaInformation.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="Apikey"></a>
### Apikey

- **Type**: API key
- **API key parameter name**: Apikey
- **Location**: HTTP header

