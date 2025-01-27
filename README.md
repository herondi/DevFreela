DevFreela

DevFreela é um projeto de gerenciamento de freelancers, onde usuários podem criar, gerenciar e acompanhar projetos. Este repositório contém a API do projeto, desenvolvida em C#.

## Funcionalidades

- Cadastro de usuários
- Criação e gerenciamento de projetos
- Acompanhamento do status dos projetos
- Sistema de autenticação

Tecnologias Utilizadas

- Linguagem: C#
- Framework: .NET
- Banco de Dados: SQL Server (ou outro de sua preferência)

Pré-requisitos

Antes de rodar o projeto, certifique-se de ter os seguintes itens instalados:

- [.NET SDK](https://dotnet.microsoft.com/download) (versão 5.0 ou superior)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (ou outro banco de dados compatível)

Como Rodar o Projeto

Siga os passos abaixo para rodar o projeto localmente:

1. Clone o repositório:

git clone https://github.com/herondi/DevFreela.git

2. Navegue até o diretório do projeto:
cd DevFreela

3. Restaure as dependências:
dotnet restore

4. Configure o banco de dados:
Crie um banco de dados no SQL Server (ou outro que você estiver usando).
Atualize a string de conexão no arquivo appsettings.json com as credenciais do seu banco de dados.

5. Execute as migrações:
dotnet ef database update

6.Inicie a aplicação:
dotnet run

Após seguir esses passos, a API estará rodando localmente e você poderá fazer requisições para testar suas funcionalidades.

Contribuição
Contribuições são bem-vindas! Sinta-se à vontade para abrir issues ou pull requests.

Licença
Esse projeto está licenciado sob a MIT License.

Contato
Para mais informações, entre em contato com o autor do projeto.

Sinta-se à vontade para ajustar as seções conforme necessário, especialmente se houver mais funcionalidades ou detalhes específicos sobre a configuração do banco de dados.
