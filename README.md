# FirstAPI-BackOffice

📌 Visão Geral
O FIRSTAPI é uma API desenvolvida em ASP.NET Core com arquitetura modular, pensada para servir como BackOffice em projetos futuros.
Ela implementa padrões como Repository Pattern, Services Layer, e autenticação via JWT, garantindo escalabilidade, segurança e facilidade de manutenção.

🚀 Funcionalidades Principais
Gestão de Utilizadores: CRUD completo de contas e perfis.
Gestão de Roles: Criação, atualização e atribuição de permissões.
Autenticação JWT: Login seguro com tokens Bearer.
Integração com PostgreSQL: Persistência robusta usando Entity Framework Core.
Swagger UI: Documentação interativa para testes de endpoints.
Arquitetura Limpa: Separação clara entre camadas (Domain, Application, Infrastructure).


📂 Estrutura do Projeto
FIRSTAPI/
│── Application/        # Serviços e lógica de negócio
│   └── Services/Role   # Exemplo: RoleService.cs
│── Controllers/        # Endpoints da API
│── Domain/             # Entidades e modelos de domínio
│── Model/              # DTOs e ViewModels
│── Repositories/       # Interfaces e implementações de persistência
│── appsettings.json    # Configurações (DB, JWT, etc.)


Instalar Dependências
bash
dotnet restore

Configurar Base de Dados
No appsettings.json, define a connection string:
json
"ConnectionStrings": {
  "DefaultConnection": "Host=localhost;Database=FirstAPIDb;Username=postgres;Password=senha"
}

Executar a API
bash
dotnet run

Endpoints disponíveis em:

https://localhost:7047
http://localhost:5299

🔑 Autenticação
Login gera um token JWT.
Endpoints protegidos exigem Authorization: Bearer <token> no header.

📖 Roadmap
[x] CRUD de Roles e Users
[x] Autenticação JWT
