# Integration tests in ASP.NET Core with 3.0

This repo contains a super simple webapi which is using the entity framework core and a SQLite database. The reason for this repo is to show the [problem](https://github.com/aspnet/AspNetCore.Docs/issues/13353#issuecomment-529302877) with the integration test on the latest .NET Core 3.0. The Application is using the SQLite DB provider and the integration test should use the InMemory DB provider from EF Core. The integration test is following Microsoft documentaion "[Integration tests in ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/test/integration-tests?view=aspnetcore-3.0)" which shows the approch the how to use a [customize the WebApplicationFactory](https://docs.microsoft.com/en-us/aspnet/core/test/integration-tests?view=aspnetcore-3.0#customize-webapplicationfactory).

## Branches
This repo include two branches. The core-2.2 branches contains a working version base on the .NET Core 2.2. The master branch contains and updated version to .NET Core 3.0. In which the integration test won't pass.

- master: ASP.NET Core 3.0
- core-2.2: ASP.NET Core 2.2


## Application

If you start the application the endpoint `/artists` will return a list of artists. Please see blow.


```
[
  {
    "artistId": 1,
    "name": "AC/DC"
  },
  {
    "artistId": 2,
    "name": "Accept"
  }
.
.
.
]
```

## Integration Test

Tests the endpoint `/artists`
