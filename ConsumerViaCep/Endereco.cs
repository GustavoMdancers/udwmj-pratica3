// Importa tipos basicos do .NET.
using System;

// Importa tipos de colecoes genericas.
using System.Collections.Generic;

// Importa metodos de consulta para colecoes.
using System.Linq;

// Importa tipos usados em tarefas assincronas.
using System.Threading.Tasks;

// Define o namespace do projeto.
namespace ConsumerViaCep
{
    // Representa os dados de um endereco retornados pelo ViaCEP.
    public class Endereco
    {
        // Armazena o CEP do endereco.
        public string? Cep { get; set; }

        // Armazena o nome da rua ou avenida.
        public string? Logradouro { get; set; }

        // Armazena informacoes adicionais do endereco.
        public string? Complemento { get; set; }

        // Armazena o bairro do endereco.
        public string? Bairro { get; set; }

        // Armazena a cidade ou municipio do endereco.
        public string? Localidade { get; set; }

        // Armazena a sigla do estado.
        public string? UF { get; set; }
    }
}