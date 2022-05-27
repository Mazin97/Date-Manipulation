# Date-Manipulation

For study purposes. This repo contains some samples on how DateTime behaves in C#.

<hr>

## Features

- Samples of DateTime manipulation in C#.


## Samples

```
Formats:
  String.Format("{0:dd/MM/yyyy hh:mm:ss ff z}") -> 27/05/2022 06:48:14 56 -3
  String.Format("{0:t}") -> 18:48
  String.Format("{0:T}") -> 18:48:14
  String.Format("{0:d}") -> 27/05/2022
  String.Format("{0:D}") -> sexta-feira, 27 de maio de 2022
  String.Format("{0:g}") -> 27/05/2022 18:48
  String.Format("{0:f}") -> sexta-feira, 27 de maio de 2022 18:48
  String.Format("{0:r}") -> Fri, 27 May 2022 18:48:14 GMT
  String.Format("{0:R}") -> Fri, 27 May 2022 18:48:14 GMT
  String.Format("{0:s}") -> 2022-05-27T18:48:14
  String.Format("{0:u}") -> 2022-05-27 18:48:14Z

Culture Info:
  CultureInfo("pt-BR") -> sexta-feira, 27 de maio de 2022
  CultureInfo("en-US") -> Friday, May 27, 2022
  currentCulture -> sexta-feira, 27 de maio de 2022

Timezone:
  DateTime.UtcNow.ToString("f") -> sexta-feira, 27 de maio de 2022 21:48
  DateTime.UtcNow.ToLocalTime().ToString("f") -> sexta-feira, 27 de maio de 2022 18:48
  TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, timezoneBrazil).ToString("f") -> sexta-feira, 27 de maio de 2022 18:48
```


## Running

clone the repo and just ``` dotnet build ``` in your console. (Required ASP.NET 6 or higher)
