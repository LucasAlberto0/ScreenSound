
//1
Console.WriteLine("Escreva um número: ");
string valor = Console.ReadLine()!;
int notaMedia = int.Parse(valor);


if (notaMedia >= 5)
{
    Console.WriteLine("Nota suficiente para aprovação!");
}
else
{
    Console.WriteLine("Reprovou!");
}


//2

List<string> linguagens = new List<string> { "C#", "Java", "JavaScript" };


//3

Console.WriteLine(linguagens[0]);

//4

Console.WriteLine("Digite a posição desejada: ");
int posicao = int.Parse(Console.ReadLine());

Console.WriteLine(linguagens[posicao]);

