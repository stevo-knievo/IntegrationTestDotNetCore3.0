# Integration tests in ASP.NET Core with 3.0

This repo contains a super simple webapi which is using the entity framework core and a sqlite database. The reason for this repo is to show the [problem](https://github.com/aspnet/AspNetCore.Docs/issues/13353#issuecomment-529302877) with the integration test on the latest .NET Core 3.0.

## Branches
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