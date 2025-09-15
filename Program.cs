// //1
// void operacoesBasicas()
// {
//     Console.WriteLine("1. Adição");
//     Console.WriteLine("2. Divisão");
//     Console.WriteLine("3. Subtração");
//     Console.WriteLine("4. Multiplicação");

// }

// operacoesBasicas();

// string escolha = Console.ReadLine()!;
//     int escolhaNumerica = int.Parse(escolha);

// Console.WriteLine("Digite o primeiro número: ");

// string num11 = Console.ReadLine()!;
// double num1 = double.Parse(num11);

// Console.WriteLine("Digite o primeiro número: ");

// string num22 = Console.ReadLine()!;
// double num2 = double.Parse(num22);

// switch (escolhaNumerica)
// {
//     case 1:
//         Console.WriteLine("Sua adição deu: " + (num1 + num2));
//         break;
//     case 2:
//         Console.WriteLine("Sua Divisão deu: " + (num1 / num2));
//         break;
//     case 3:
//         Console.WriteLine("Sua Subtração deu: " + (num1 - num2));
//         break;
//     case 4:
//         Console.WriteLine("Sua Multiplicação deu: " + (num1 * num2));
//         break;
//     default:
//         Console.WriteLine("Opção Inválida!");
//         break;
// }

// 2
// List<string> bandas = new List<string> { "Metallica", "Iron Maiden", "Skillet" };

// Console.WriteLine("Cadastre uma banda: ");
// string bandaP = Console.ReadLine()!;
// bandas.Add(bandaP);

// foreach (string banda in bandas)
// {
//     Console.WriteLine($"Banda: {banda}");
// }

//3

// for (int i = 0; i < bandas.Count; i++)
// {
//     Console.WriteLine($"Banda: {bandas[i]}");
// }


//4

// List<int> numeros = new List<int> { 1, 2, 3, 4, 5 };
// int soma = 0;

// foreach (int numero in numeros)
// {
//     soma += numero;
// }

// Console.WriteLine($"A soma dos elementos da lista é: {soma}");


// List<double> numeros2 = new List<double> { 1.5, 2.5, 3.5, 4.5, 5.5 };
// double soma2 = 0;

// foreach (double numero2 in numeros2)
// {
//     soma2 += numero2;
// }

// double media = soma / numeros2.Count;
// Console.WriteLine($"A média dos elementos da lista é: {media}");


// List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

// for (int i = 0; i < numeros.Count; i++)
// {
//     if (numeros[i] % 2 == 0) 
//     {
//         Console.WriteLine(numeros[i]);
//     }
// }

//OU foreach (int numero in numeros)
// {
//     if (numero % 2 == 0) {
//         Console.WriteLine(numero);
//     }
// }

var notasAlunos = new Dictionary<string, Dictionary<string, List<int>>> {
    { "Ana", new Dictionary<string, List<int>> {
        { "C#", new List<int> { 8, 7, 6 } },
        { "Java", new List<int> { 7, 6, 5 } },
        { "Python", new List<int> { 9, 8, 8 } }
    }},
    { "Maria", new Dictionary<string, List<int>> {
        { "C#", new List<int> { 6, 5, 4 } },
        { "Java", new List<int> { 8, 7, 6 } },
        { "Python", new List<int> { 6, 10, 5 } }
    }},
    { "Luiza", new Dictionary<string, List<int>> {
        { "C#", new List<int> { 2, 3, 10 } },
        { "Java", new List<int> { 8, 8, 8 } },
        { "Python", new List<int> { 7, 7, 7 } }
    }}
};

List<int> notasPythonMaria = notasAlunos["Maria"]["Python"];
double mediaMariaEmPython = notasPythonMaria.Average();
Console.WriteLine(mediaMariaEmPython);