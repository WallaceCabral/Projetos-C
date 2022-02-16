using EstoqueEmpresa;

Produto p;

p = new Produto();
int qtde;
string resp;

Console.WriteLine("Entre com os dados do produto");
Console.WriteLine("Qual nome do produto: ");
p.Nome = Console.ReadLine();
Console.WriteLine("Preço: ");
p.Preco = double.Parse(Console.ReadLine());
Console.WriteLine("Quantidade no estoque: ");
p.Quantidade = int.Parse(Console.ReadLine());

Console.WriteLine();
Console.WriteLine("Dados do Produto: "+p);

Console.WriteLine();

Console.WriteLine("Deseja Adicionar ou remover quantidade de Produtos? ");
Console.WriteLine("1- Adicionar");
Console.WriteLine("2- Remover");
Console.WriteLine("3- Finalizar");

resp = Console.ReadLine();
do
{



    if (resp == "Adicionar" || resp == "adicionar" || resp == "1")
    {
        Console.WriteLine("Digite o numero de produtos a ser adicionado ao estoque:");
        qtde = int.Parse(Console.ReadLine());

        p.AdicionarProdutos(qtde);

        Console.WriteLine();
        Console.WriteLine("dados atualizados: " + p);

        Console.WriteLine();
        Console.WriteLine("Deseja Adicionar ou remover quantidade de Produtos? ");
        Console.WriteLine("1- Adicionar");
        Console.WriteLine("2- Remover");
        Console.WriteLine("3- Finalizar");

        resp = Console.ReadLine();
    }
    else if (resp == "Remover" || resp == "remover" || resp == "2")
    {
        Console.WriteLine("Digite o numero de produtos a ser Removido do estoque:");
        qtde = int.Parse(Console.ReadLine());

        p.RemoverProdutos(qtde);

        Console.WriteLine();
        Console.WriteLine("dados atualizados: " + p);

        Console.WriteLine();
        Console.WriteLine("Deseja Adicionar ou remover quantidade de Produtos? ");
        Console.WriteLine("1- Adicionar");
        Console.WriteLine("2- Remover");
        Console.WriteLine("3- Finalizar");

        resp = Console.ReadLine();
    }
    else
    {

        Console.WriteLine();
        Console.WriteLine("dados atuais: " + p);
    }
  
} while (resp != "3");

    

