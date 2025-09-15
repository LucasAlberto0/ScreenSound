//1

// Dictionary<string, List<double>> notasAlunos = new Dictionary<string, List<double>>();

// // Adicione notas para alguns alunos
// notasAlunos["João"] = new List<double> { 8.5, 9.0, 7.5 };
// notasAlunos["Maria"] = new List<double> { 7.0, 8.0, 6.5 };

// foreach (var aluno in notasAlunos)
// {
//     double soma = 0;
//     for (int i = 0; i < aluno.Value.Count; i++)
//     {
//         soma += aluno.Value[i];
//     }
//     double media = soma / aluno.Value.Count;
//     Console.WriteLine($"Média de {aluno.Key}: {media}");
// }

//2

// Dictionary<string, int> estoque = new Dictionary<string, int>
// {
//     { "camisetas", 50 },
//     { "calças", 30 },
//     { "tênis", 20 },
// };

// string produto = "camisetas";

// if (estoque.ContainsKey(produto))
// {
//     Console.WriteLine($"Quantidade em estoque de {produto}: {estoque[produto]} unidades.");
// }
// else
// {
//     Console.WriteLine("Produto não encontrado no estoque.");
// }

//3

// Dictionary<string, string> perguntasERespostas = new Dictionary<string, string>
// {
//     { "Qual é a capital do Brasil?", "Brasília" },
//     { "Quanto é 7 vezes 8?", "56" },
//     { "Quem escreveu 'Romeu e Julieta'?", "William Shakespeare" },
//     // Adicione mais perguntas e respostas conforme necessário
// };

// int pontuacao = 0;

// foreach (var pergunta in perguntasERespostas)
// {
//     Console.WriteLine(pergunta.Key);
//     Console.Write("Sua resposta: ");
//     string respostaUsuario = Console.ReadLine()!;

//     if (respostaUsuario.ToLower() == pergunta.Value.ToLower())
//     {
//         Console.WriteLine("Correto!\n");
//         pontuacao++;
//     }
//     else
//     {
//         Console.WriteLine($"Incorreto. A resposta correta é: {pergunta.Value}\n");
//     }
// }

// Console.WriteLine($"Pontuação final: {pontuacao} de {perguntasERespostas.Count}");

//4

Dictionary<string, string> usuarios = new Dictionary<string, string>
{
    { "user1", "senha123" },
    { "user2", "abc456" },
    // Adicione mais usuários conforme necessário
};

string nomeUsuario = "user2";
string senha = "senha123";

if (usuarios.ContainsKey(nomeUsuario) && usuarios[nomeUsuario] == senha)
    Console.WriteLine("Login bem-sucedido!");
else
    Console.WriteLine("Nome de usuário ou senha incorretos.");

