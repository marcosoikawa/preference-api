---
ArtifactType: API
Language: C#
Platform: Windows
Tags: Azure, .NET 9
---


# API de Preferências para demonstração


![GitHub](https://img.shields.io/github/license/marcosoikawa/preference-api) 
![GitHub repo size](https://img.shields.io/github/repo-size/marcosoikawa/preference-api) 
[![Azure](https://badgen.net/badge/icon/azure?icon=azure&label)](https://azure.microsoft.com)

![GitHub last commit](https://img.shields.io/github/last-commit/marcosoikawa/preference-api)
![GitHub top language](https://img.shields.io/github/languages/top/marcosoikawa/preference-api)

## Cenário

Esta API permite consultar preferências/gostos de pessoas baseado em seus nomes. Ideal para ser usada em demosntraçãoes de agentes com AI Foundry, ou outras ferramentas que suportem cadastro de Actions via OpenAPI.

## Endpoint Disponível

### Obter preferência por nome
- **GET** `/api/preference/{name}`
- **Descrição**: Retorna a preferência de uma pessoa específica
- **Exemplo**: `GET /api/preference/Nathalia`

## Exemplo de Uso

### Buscar preferência da Nathalia:GET /api/preference/Nathalia
Resposta:
{
    "name": "Nathalia",
    "preference": "Monet",
    "category": "Obras de Arte",
    "description": "Para obras de arte, prefere Monet"
}
### Buscar preferência do Marcos:GET /api/preference/Marcos
Resposta:
{
    "name": "Marcos",
    "preference": "Hokusai",
    "category": "Obras de Arte",
    "description": "Para obras de arte, prefere Hokusai"
}
## Pessoas Pré-cadastradas

A API possui as seguintes preferências disponíveis para consulta:
- **Nathalia** - Monet
- **Marcos** - Hokusai
- **Iury** - Picasso
- **Filiputti** - Gogh

## Como Executar

1. Execute o projeto com `dotnet run`
2. Acesse **`https://localhost:7010/swagger`** para ver a documentação interativa
3. Use o endpoint listado acima

## Swagger UI

### Produção:
- **Swagger UI**: `https://seu-dominio.com/swagger`
- **OpenAPI JSON**: `https://seu-dominio.com/swagger/v1/swagger.json`

## Características da API

✅ **API somente leitura** - Apenas consultas são permitidas  
✅ **Busca insensível a maiúsculas/minúsculas** - Funciona com qualquer combinação  
✅ **Respostas padronizadas** - JSON estruturado  
✅ **Logs detalhados** - Para monitoramento  
✅ **Swagger sempre disponível** - Em todos os ambientes  

## Códigos de Resposta

- **200 OK** - Preferência encontrada com sucesso
- **400 Bad Request** - Nome não fornecido ou vazio
- **404 Not Found** - Pessoa não encontrada na base de dados


## Contributing

This project welcomes contributions and suggestions.  Most contributions require you to agree to a
Contributor License Agreement (CLA) declaring that you have the right to, and actually do, grant us
the rights to use your contribution. For details, visit https://cla.opensource.microsoft.com.

When you submit a pull request, a CLA bot will automatically determine whether you need to provide
a CLA and decorate the PR appropriately (e.g., status check, comment). Simply follow the instructions
provided by the bot. You will only need to do this once across all repos using our CLA.

This project has adopted the [Microsoft Open Source Code of Conduct](https://opensource.microsoft.com/codeofconduct/).
For more information see the [Code of Conduct FAQ](https://opensource.microsoft.com/codeofconduct/faq/) or
contact [opencode@microsoft.com](mailto:opencode@microsoft.com) with any additional questions or comments.

## Trademarks

This project may contain trademarks or logos for projects, products, or services. Authorized use of Microsoft 
trademarks or logos is subject to and must follow 
[Microsoft's Trademark & Brand Guidelines](https://www.microsoft.com/en-us/legal/intellectualproperty/trademarks/usage/general).
Use of Microsoft trademarks or logos in modified versions of this project must not cause confusion or imply Microsoft sponsorship.
Any use of third-party trademarks or logos are subject to those third-party's policies.