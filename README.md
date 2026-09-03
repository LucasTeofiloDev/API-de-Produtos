# API de Produtos

API REST para gerenciamento de produtos, desenvolvida com ASP.NET Core 10, Entity Framework Core e SQL Server. O projeto demonstra a implementação de um CRUD completo, separação de responsabilidades em camadas e persistência de dados em banco relacional.

## Tecnologias

- C# e .NET 10
- ASP.NET Core Web API
- Entity Framework Core 10
- SQL Server
- Injeção de dependência

## Funcionalidades

- Cadastrar produtos
- Listar todos os produtos
- Buscar um produto por ID
- Atualizar produtos
- Excluir produtos

## Estrutura do projeto

```text
ApiDeProdutos/
|-- Controllers/          # Endpoints HTTP da API
|-- Model/                # Entidades de domínio
|   `-- Context/          # Contexto do Entity Framework Core
|-- Services/
|   |-- Interfaces/       # Contratos dos serviços
|   `-- Implementations/  # Regras de acesso e persistência
|-- Program.cs            # Configuração da aplicação e dependências
`-- appsettings.json      # Configurações da aplicação e do banco
```

## Modelo de produto

| Campo | Tipo | Descrição |
|---|---|---|
| `id` | inteiro | Identificador único |
| `name` | texto | Nome do produto |
| `price` | decimal | Preço do produto |
| `category` | texto | Categoria do produto |

Exemplo de JSON:

```json
{
  "id": 1,
  "name": "Teclado mecânico",
  "price": 299.90,
  "category": "Periféricos"
}
```

## Endpoints

A rota base da API é `api/Product`.

| Método | Endpoint | Descrição |
|---|---|---|
| `GET` | `/api/Product` | Lista todos os produtos |
| `GET` | `/api/Product/{id}` | Busca um produto por ID |
| `POST` | `/api/Product` | Cadastra um produto |
| `PUT` | `/api/Product` | Atualiza um produto |
| `DELETE` | `/api/Product/{id}` | Exclui um produto |

## Como executar

### Pré-requisitos

- [.NET SDK 10](https://dotnet.microsoft.com/download/dotnet/10.0)
- SQL Server disponível localmente ou em outro servidor

### 1. Clone o repositório

```bash
git clone https://github.com/LucasTeofiloDev/API-de-Produtos.git
cd API-de-Produtos
```

### 2. Configure o banco de dados

Atualize `ApiDeProdutos/appsettings.json` com a sua conexão:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=api_produts;Trusted_Connection=True;TrustServerCertificate=True"
  }
}
```

O banco deve possuir uma tabela `Products` compatível com o modelo abaixo:

```sql
CREATE TABLE Products (
    id INT IDENTITY(1,1) PRIMARY KEY,
    nome NVARCHAR(200) NOT NULL,
    price DECIMAL(18,2) NOT NULL,
    categoria NVARCHAR(100) NOT NULL
);
```

### 3. Restaure e execute a aplicação

```bash
dotnet restore ApiDeProdutos.slnx
dotnet run --project ApiDeProdutos/ApiDeProdutos.csproj
```

Por padrão, a API ficará disponível em:

- `http://localhost:5093`
- `https://localhost:7166`

## Objetivo do projeto

Este projeto foi criado para praticar o desenvolvimento de APIs REST com ASP.NET Core, organização em camadas, injeção de dependência e integração com SQL Server usando Entity Framework Core.

## Autor

Desenvolvido por [Lucas Teofilo](https://github.com/LucasTeofiloDev).
