//1
void operacoesBasicas()
{
    Console.WriteLine("1. Adição");
    Console.WriteLine("2. Divisão");
    Console.WriteLine("3. Subtração");
    Console.WriteLine("4. Multiplicação");

}

operacoesBasicas();

string escolha = Console.ReadLine()!;
    int escolhaNumerica = int.Parse(escolha);

Console.WriteLine("Digite o primeiro número: ");

string num11 = Console.ReadLine()!;
double num1 = double.Parse(num11);

Console.WriteLine("Digite o primeiro número: ");

string num22 = Console.ReadLine()!;
double num2 = double.Parse(num22);

switch (escolhaNumerica)
{
    case 1:
        Console.WriteLine("Sua adição deu: " + (num1 + num2));
        break;
    case 2:
        Console.WriteLine("Sua Divisão deu: " + (num1 / num2));
        break;
    case 3:
        Console.WriteLine("Sua Subtração deu: " + (num1 - num2));
        break;
    case 4:
        Console.WriteLine("Sua Multiplicação deu: " + (num1 * num2));
        break;
    default:
        Console.WriteLine("Opção Inválida!");
        break;
}



