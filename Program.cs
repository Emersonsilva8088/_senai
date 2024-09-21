using _senai.classes;
string? opcao;

do
{
Console.Clear();
Console.WriteLine(@"
1 - Cadastrar PJ
0 - Sair
");
opcao = Console.ReadLine();
Pessoajuridica metodosPj = new Pessoajuridica ();
if (opcao == "1") {
    Pessoajuridica pj = new Pessoajuridica();
    Console.WriteLine("Digite o nome da pj:");
    pj.Nome = Console.ReadLine();

    Console.WriteLine("Informe o rendimento da pj:");
    pj.Rendimento = float.Parse(Console.ReadLine());

    Console.WriteLine("informe o CNPJ da pj");
    pj.cnpj = Console.ReadLine();

    metodosPj.Inserir(pj);

    } else if (opcao == "2") {
    } else if (opcao == "0") {
        Console.WriteLine("Obrigado por utilizar o nosso sistema! :)");
    }else {
        Console.WriteLine("Opcao invalida, tente nvamente;");

}
} while (opcao != "0");


