# API de Preferências para demonstração

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

📋 **A documentação interativa Swagger está SEMPRE DISPONÍVEL** em todos os ambientes:

### Desenvolvimento (local):
- **HTTPS**: `https://localhost:7010/swagger`
- **HTTP**: `http://localhost:5213/swagger`

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