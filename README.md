# Restsharp Complete Basic Example

Esse projeto foi inspirado por [Rest-Assured Complete Basic Example]("https://github.com/eliasnogueira/restassured-complete-basic-example") do [Elias Nogueira]("https://github.com/eliasnogueira")


## Como executar os testes

Para executar os testes, procure a guia Teste -> Gerenciador de Testes no Visual Studio

ou

Execute os testes pela linha de comando `dotnet test`

Para filtrar os testes que deseja executar pela linha de comando utilize:

| Categoria          | Comando                                  |
|--------------------|------------------------------------------|
| health check tests | dotnet test --filter Category=health     |
| contract tests     | dotnet test --filter Category=contract   |
| functional tests   | dotnet test --filter Category=functional |
| e2e tests          | dotnet test --filter Category=e2e        |


### Executando a API de back-end

Antes de executar qualquer teste, siga as instru��es do reposit�rio abaixo e execute a api:
- [Combined Credit API]("https://github.com/eliasnogueira/credit-api")


### Nota
> Esse projeto ainda n�o est� completo, � necess�rio implementar os testes e2e e adicionar mais alguns testes para simulations.