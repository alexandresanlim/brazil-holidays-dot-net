# BrazilHolidays.Net
[![Nuget](https://img.shields.io/nuget/dt/BrazilHolidays.Net)](https://www.nuget.org/packages/BrazilHolidays.Net)
[![Nuget](https://img.shields.io/nuget/v/BrazilHolidays.Net)](https://www.nuget.org/packages/BrazilHolidays.Net)

 Instale [este pacote](https://www.nuget.org/packages/BrazilHolidays.Net) via nuget ou linha de comando:<br/>
`Install-Package BrazilHolidays.Net`

## Como usar

 - Hoje é feriado? (Is today a holiday?)
```csharp 
BrazilHolidays.Net.Today.IsHoliday(); 
```

- Uma data especifica é feriado? (Is a date a holiday?)
```csharp  
new DateTime(2020, 12, 25).IsHoliday()
```

- Lista dos próximos feriados (Get a list of next holidays)
```csharp  
BrazilHolidays.Net.DataStore.Holiday.GetAllNext();
```

- Pegar o ultimo (Get the last holiday)
```csharp  
BrazilHolidays.Net.DataStore.Holiday.GetOld();
```

- Pegar o próximo (Get the next holiday)
```csharp  
BrazilHolidays.Net.DataStore.Holiday.GetNext();
```

- Pegar todos de um determinado mês (Get a list by month)
```csharp  
BrazilHolidays.Net.DataStore.Holiday.GetAllByMonth(BrazilHolidays.Net.DataStore.Holiday.Months.Dec);
```

### Este projeto incluí testes:
- Feriados para o ano corrente
- Feriados para datas móveis em um ano bissexto e não bissexto.
- Se a data atual é feriado

![image](https://user-images.githubusercontent.com/5353685/97025524-9193e600-152e-11eb-9077-f873e472c43f.png)
