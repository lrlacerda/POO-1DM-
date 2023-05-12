//criar uma lista de objetos produtos

using ExemploList;

List<Produto> produtos = new List<Produto>();

//Create

//Inserir objetos de produtos dentro da lista duas formas
//através de uma instancia direta (com construtor)
produtos.Add(new Produto(1234, "camiseta lacosta", 399.99));

produtos.Add(new Produto(1236, "camiseta Ugo Boos", 199.99));

//através de uma instância básica de objeto
Produto camisetaArmani = new Produto(1235, "camiseta Armani", 259.99);
produtos.Add(camisetaArmani);

//Read

Console.WriteLine($"\nProdutos antes da alteração");

foreach (var item in produtos)
{
    Console.WriteLine($"Código: {item.Codigo}, Nome: {item.Nome}, Preço: {item.Preco:C}");
}

//UpDate

//acessar um objeto da lista para poder manipulá-lo
Produto produtoBuscado = produtos.Find(x => x.Codigo == 1234);
int index = produtos.IndexOf(produtoBuscado);
//encontrar onde ele esta no indice
Console.WriteLine($"O índice do produto encontrado é o: {index}");

//fazer alterações
produtoBuscado.Preco = 599;

//remover o item antigo da lista
produtos.RemoveAt(index);

//devolver o item atualizado no lugar dele
produtos.Insert(index, produtoBuscado);

Console.WriteLine($"\nProdutos depois da alteração");

foreach (var item in produtos)
{
    Console.WriteLine($"Código: {item.Codigo}, Nome: {item.Nome}, Preço: {item.Preco:C}");
}
