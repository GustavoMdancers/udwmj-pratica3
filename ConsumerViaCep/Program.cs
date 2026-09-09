//Usei IA para comentar o código e explicar o que cada linha faz pra ajudar nos estudos.

// Importa os metodos estaticos da classe Console para usa-los sem escrever Console.
using static System.Console;

// Importa o namespace que contem a classe Endereco.
using ConsumerViaCep;

// Importa as classes usadas para converter JSON em objetos C#.
using System.Text.Json;

// Exibe uma mensagem solicitando o CEP ao usuario.
Console.WriteLine("Digite o CEP que deseja consultar!");

// Le o CEP digitado e armazena o texto na variavel cep.
var cep = ReadLine();

// Monta a URL da API do ViaCEP usando o CEP informado.
var enderecourl = $"https://viacep.com.br/ws/{cep}/json/";

// Informa ao usuario qual URL sera consultada.
WriteLine($"Consultando o CEP {enderecourl}...");

// Cria um cliente HTTP para fazer requisicoes na internet.
var httpClient = new HttpClient();

// Inicia um bloco para capturar possiveis erros durante a consulta.
try
{
    // Envia uma requisicao GET para a URL e aguarda a resposta.
    HttpResponseMessage response = await httpClient.GetAsync(enderecourl);

    // Interrompe o fluxo se a API retornar um status de erro HTTP.
    response.EnsureSuccessStatusCode();

    // Le o conteudo da resposta como texto JSON.
    string respostaApi = await response.Content.ReadAsStringAsync();

    // Converte o JSON recebido em um objeto da classe Endereco.
    Endereco? enderecoApi = JsonSerializer.Deserialize<Endereco>(
        respostaApi,
        new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

    // Exibe o CEP retornado pela API; o operador ?. evita erro se o objeto for nulo.
    WriteLine($"CEP: {enderecoApi?.Cep}");

    // Exibe o nome da rua retornado pela API.
    WriteLine($"Logradouro: {enderecoApi?.Logradouro}");

    // Exibe o complemento do endereco retornado pela API.
    WriteLine($"Complemento: {enderecoApi?.Complemento}");

    // Exibe o bairro retornado pela API.
    WriteLine($"Bairro: {enderecoApi?.Bairro}");

    // Exibe a cidade retornada pela API.
    WriteLine($"Localidade: {enderecoApi?.Localidade}");

    // Exibe a sigla do estado retornada pela API.
    WriteLine($"UF: {enderecoApi?.UF}");
}
catch (Exception ex)
{
    // Exibe uma informacao interna do erro, quando existir.
    WriteLine("Erro: " + ex.InnerException);

    // Exibe a mensagem principal do erro ocorrido.
    WriteLine($"Ocorreu um erro ao consultar o CEP: {ex.Message}");
}