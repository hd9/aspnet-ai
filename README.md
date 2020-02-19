# aspnet-ai
Sample code on how to enable [Application Insights
telemetry](https://docs.microsoft.com/en-us/azure/azure-monitor/app/app-insights-overview#what-does-application-insights-monitor)
on an [ASP.NET Core web applications](https://docs.microsoft.com/en-us/aspnet/core/).

Fore more information, visit: [Adding Application Insights telemetry to your
ASP.NET Core website | HildenCo](https://blog.hildenco.com/2020/03/adding-application-insights-telemetry.html)

## Running
To run the base version, use the code available on `master` branch:
```
git clone https://github.com/hd9/aspnet-ai.git
cd aspnet-ai/src
dotnet run
```

To run the version that suppresses telemetry, run the code available on the
`telemetry` branch:
```
git clone https://github.com/hd9/aspnet-ai.git
git checkout telemetry
cd aspnet-ai/src
dotnet run
```

Don't forget to add your [Instrumentation
Key](https://docs.microsoft.com/en-us/azure/azure-monitor/app/create-new-resource)
to your `appSettings.json`.

## Thanks!
And don't forget to visit [blog.hildenco.com](https://blog.hildenco.com).

## License
MIT
