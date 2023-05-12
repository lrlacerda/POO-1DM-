using Produto_Interface;


Carrinho carrinho = new Carrinho();

Produto p1 = new Produto(1, "Call of Duty", 399);
Produto p2 = new Produto(2, "Mineirinho Ultra Adventures", 2.30);
Produto p3 = new Produto(2, "The Last Of Us", 250);

//Adicionar

carrinho.Adicionar(p1);
carrinho.Adicionar(p2);
carrinho.Adicionar(p3);

//listar

carrinho.Listar();

//Valor do carrinho

carrinho.ValorTotal();

Console.WriteLine($"\n**************************************************");

//Remover

carrinho.Remover(p1);

//Listar

carrinho.Listar();

//Valor total após remover um objeto

carrinho.ValorTotal();

Console.WriteLine($"\n*************************************************");

//Atualizar
//criar um novo objeto com os dados atualizados

Produto produtoAtualizado = new Produto();
produtoAtualizado.Nome = "Mineirinho Directors Cut";
produtoAtualizado.Preco = 2.50;

carrinho.Atualizar(2, produtoAtualizado);

carrinho.Listar();

carrinho.ValorTotal();