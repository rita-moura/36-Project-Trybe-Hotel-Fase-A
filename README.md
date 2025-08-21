# 🏨 Projeto Trybe Hotel - Fase A

![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=c-sharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![Entity Framework](https://img.shields.io/badge/Entity%20Framework-4E257E?style=for-the-badge)

Projeto de desenvolvimento do back-end de uma aplicação de reservas de hotel, realizado como parte do curso de Desenvolvimento Web da [Trybe](https://www.betrybe.com/).

## 📋 Tabela de Conteúdos

- [Sobre o Projeto](#-sobre-o-projeto)
- [Funcionalidades Implementadas](#-funcionalidades-implementadas)
- [Tecnologias Utilizadas](#-tecnologias-utilizadas)
- [Estrutura do Projeto e Autoria](#-estrutura-do-projeto-e-autoria)
- [Como Começar](#-como-começar)
  - [Pré-requisitos](#pré-requisitos)
  - [Instalação e Execução](#instalação-e-execução)
  - [Executando os Testes](#executando-os-testes)
- [Autora](#-autora)

## 📖 Sobre o Projeto

O **Trybe Hotel** é uma API RESTful construída em C# com .NET para gerenciar hotéis, quartos e reservas. Esta é a "Fase A" do projeto, focada na construção dos endpoints essenciais e na configuração da base de dados e da estrutura da aplicação. O objetivo é aplicar conceitos de desenvolvimento back-end, como arquitetura em camadas, ORM com Entity Framework, e criação de APIs.

## ✨ Funcionalidades Implementadas

*   **Hotéis**:
    *   `GET /hotel`: Lista todos os hotéis cadastrados.
    *   `POST /hotel`: Adiciona um novo hotel.
*   **Quartos**:
    *   `GET /room/:hotelId`: Lista os quartos de um hotel específico.
    *   `POST /room`: Adiciona um novo quarto a um hotel.
    *   `DELETE /room/:roomId`: Remove um quarto.
*   **Reservas**:
    *   `GET /booking/:bookingId`: Busca uma reserva específica com detalhes do quarto e hotel.
    *   `POST /booking`: Adiciona uma nova reserva para um usuário.
*   **Usuários**:
    *   `GET /user`: Lista todos os usuários.
    *   `POST /user`: Adiciona um novo usuário (com validação de e-mail existente).
*   **Login**:
    *   `POST /login`: Autentica um usuário e retorna um token JWT.

*(Lembre-se de ajustar esta lista com as funcionalidades que você realmente implementou!)*

## 🚀 Tecnologias Utilizadas

Este projeto foi desenvolvido com as seguintes tecnologias:

- **C#**: Linguagem de programação principal.
- **.NET 6**: Framework para construção da aplicação.
- **Entity Framework Core 6**: ORM para interação com o banco de dados.
- **ASP.NET Core**: Framework para criação de APIs web.
- **xUnit**: Biblioteca para a escrita dos testes automatizados.
- **Moq**: Framework de mocking para testes unitários.
- **Swagger/OpenAPI**: Para documentação e teste interativo da API.

## 📂 Estrutura do Projeto e Autoria

Conforme as diretrizes da Trybe, a autoria dos arquivos está dividida da seguinte forma:

- 📁 `src/TrybeHotel/`: **Desenvolvido por mim (Rita)**. Contém toda a lógica da aplicação, incluindo controllers, models, services e repository.
- 📁 `src/TrybeHotel.Test/`: **Desenvolvido por mim (Rita)**. Contém todos os testes unitários para garantir a qualidade e o funcionamento correto da API.
- 📝 Arquivos de configuração (`.sln`, `.csproj`, `launchSettings.json`, `appsettings.json`, etc.): **Fornecidos pela Trybe** como base para o desenvolvimento do projeto.

## 🏁 Como Começar

Siga os passos abaixo para configurar e executar o projeto em seu ambiente local.

### Pré-requisitos

Antes de começar, você vai precisar ter instalado em sua máquina:

- .NET SDK 6.0 ou superior.
- Um editor de código de sua preferência, como Visual Studio Code ou Visual Studio.

### Instalação e Execução

1. **Clone o repositório:**
   ```bash
   git clone git@github.com:seu-usuario/36-Project-Trybe-Hotel-Fase-A.git
   ```
2. **Navegue até o diretório do projeto:**
   ```bash
   cd 36-Project-Trybe-Hotel-Fase-A
   ```
3. **Restaure as dependências do .NET:**
   ```bash
   dotnet restore
   ```
4. **Execute as migrations para criar o banco de dados:**
   *(Certifique-se que a connection string em `appsettings.json` está correta)*
   ```bash
   dotnet ef database update --project src/TrybeHotel
   ```
5. **Execute a aplicação:**
   ```bash
   dotnet run --project src/TrybeHotel
   ```
6. A API estará disponível em `http://localhost:5000` (ou outra porta configurada). Você pode acessar a documentação interativa do Swagger em `http://localhost:5000/swagger`.

### Executando os Testes

Para rodar a suíte de testes e verificar se tudo está funcionando como esperado, execute o comando:
```bash
dotnet test
```
