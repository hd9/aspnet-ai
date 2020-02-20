# aspnet-ai
Sample code on how to enable [Application Insights
telemetry](https://docs.microsoft.com/en-us/azure/azure-monitor/app/app-insights-overview#what-does-application-insights-monitor)
on an [ASP.NET Core web applications](https://docs.microsoft.com/en-us/aspnet/core/).

Fore more information, visit: [Adding Application Insights telemetry to your
ASP.NET Core website | HildenCo](https://blog.hildenco.com/2020/03/adding-application-insights-telemetry.html)

## Running
This repo contains 3 solutions:
* Simple Application Insights demo
* Suppressing Telemetry on Application Insights demo
* Simple Alert based on Application Insights demo

### Simple Application Insights demo
To run the base version, use the code available on `master` branch:
```
git clone https://github.com/hd9/aspnet-ai.git
cd aspnet-ai/src
# add your instrumentation key to src/appSettings.Development.json
dotnet run
```

### Simple Telemetry demo
To run the version that suppresses telemetry, run the code available on the
`telemetry` branch:
```
git clone https://github.com/hd9/aspnet-ai.git
git checkout telemetry
cd aspnet-ai/src
# add your instrumentation key to src/appSettings.Development.json
dotnet run
```

### Simple Alert demo
To run the version that produces Application Insights alerts, run the code
available on the `alerts` branch:
```
git clone https://github.com/hd9/aspnet-ai.git
git checkout alerts
cd aspnet-ai/src
# add your instrumentation key to src/appSettings.Development.json
dotnet run
```

## Configuration
To work, this solution requires a valid [Instrumentation Key](https://docs.microsoft.com/en-us/azure/azure-monitor/app/create-new-resource)
on your `appSettings.json`.

## Thanks!
And don't forget to visit [blog.hildenco.com](https://blog.hildenco.com).

## License
MIT
