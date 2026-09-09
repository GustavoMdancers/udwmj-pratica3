# Prática 3 - Consulta de CEP com ViaCEP

Aplicação em C# desenvolvida para consumir a API pública do ViaCEP e exibir os dados de endereço a partir de um CEP informado pelo usuário.

## Objetivo

O projeto tem como objetivo praticar:

- consumo de APIs REST em C#;
- uso do `HttpClient` para requisições HTTP;
- desserialização de JSON em objetos com `System.Text.Json`;
- manipulação de dados de endereço em uma aplicação de console.

## Tecnologias utilizadas

- C#
- .NET 10
- ASP.NET? Não aplica aqui
- `System.Text.Json`
- `HttpClient`

## Funcionalidades

- Solicita ao usuário que informe um CEP;
- monta a URL da API do ViaCEP;
- faz a requisição HTTP GET;
- converte a resposta JSON em um objeto `Endereco`;
- exibe no console:
  - CEP;
  - logradouro;
  - complemento;
  - bairro;
  - cidade;
  - UF.

## Estrutura do projeto

```text
udwmj-pratica3/
├── README.md
├── ConsumerViaCep/
│   ├── ConsumerViaCep.csproj
│   ├── Endereco.cs
│   └── Program.cs
└── .gitignore
```

## Arquivos principais

- `ConsumerViaCep/Program.cs`: contém a lógica principal da aplicação, incluindo a consulta à API e apresentação dos resultados.
- `ConsumerViaCep/Endereco.cs`: define a classe modelo usada para receber os dados retornados pela API.
- `ConsumerViaCep/ConsumerViaCep.csproj`: arquivo de configuração do projeto .NET.

## Pré-requisitos

Antes de executar o projeto, certifique-se de que o ambiente possui:

- SDK do .NET 10 instalado;
- terminal ou prompt de comando disponível;
- conexão com a internet para acessar a API do ViaCEP.

## Como executar

1. Abra o terminal na pasta raiz do projeto.
2. Acesse a pasta do aplicativo:

```bash
cd ConsumerViaCep
```

3. Execute a aplicação:

```bash
dotnet run
```

4. Digite um CEP no console, por exemplo:

```text
01001000
```

5. A aplicação exibirá os dados do endereço correspondente.

## Exemplo de saída

```text
Digite o CEP que deseja consultar!
01001000
Consultando o CEP https://viacep.com.br/ws/01001000/json/...
CEP: 01001-000
Logradouro: Praça da Sé
Complemento: lado impar
Bairro: Sé
Localidade: São Paulo
UF: SP
```

## Observações

- A API do ViaCEP é pública e gratuita para consultas simples.
- Caso o CEP seja inválido ou a API esteja indisponível, a aplicação trata a exceção e exibe uma mensagem de erro.
- O projeto é uma boa base para estudos de consumo de APIs REST em C#.

## Autor

Projeto desenvolvido para fins de estudo e prática de programação em C#.
