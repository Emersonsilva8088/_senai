using _senai.classes;
string? opcao;

do
{
Console.Clear();
Console.WriteLine(@"
1 - Cadastrar pj
0 - Sair
");
opcao = Console.ReadLine();
pessoajuridica metodosPj = new pessoajuridica ();
if (opcao == "1") {
    pessoajuridica pj = new pessoajuridica();
    Console,WriteLine("Digite o nome da pj:");
    pj: = Console,ReadLine();
    Console.WriteLine("Informe o rendimento da pj:");
    pj.Rendimento = float.Parse(Console,ReadLine());
    } else if (opcao == "2") {
    } else if (opcao == "0") {
        Console.WriteLine("Obrigado por utilizar o nosso sistema! :)");
    }else if {
        Console.WriteLine("Opcao invalida, tente nvamente;");

}
} while (opcao != "2");

void ReadLine()
{
    throw new NotImplementedException();
}

void WriteLine(string v)
{
    throw new NotImplementedException();
}