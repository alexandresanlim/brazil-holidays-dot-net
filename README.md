# BrazilHolidays.Net

## Como usar

 - Hoje é feriado?

` BrazilHolidays.Net.Today.IsHoliday(); `

- Hoje não é feriado?

` BrazilHolidays.Net.Today.IsNotHoliday() `

- Uma data especifica é feriado?

` new DateTime(Year, 12, 25).IsHoliday() `

## Testes
O projeto incluí testes:
- Feriados para o ano corrente
- Feriados para datas móveis em um ano bissexto e não bissexto.
- Se a data atual é feriado

![image](https://user-images.githubusercontent.com/5353685/97025524-9193e600-152e-11eb-9077-f873e472c43f.png)
