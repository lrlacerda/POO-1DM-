using ProjetoClassePersonagem;

//instanciar um objeto da classe Personagem
// Personagem Tony = new Personagem();

// //exibindo as informações do objeto
// Console.WriteLine(Tony.nome);
// Console.WriteLine(Tony.idade);
// Console.WriteLine(Tony.armadura);
// Console.WriteLine(Tony.ia);

// //Chamando os métodos da clesse
// Tony.Atacar();
// Console.WriteLine(Tony.Defender());
// Tony.RestaurarArmadura();


Personagem p1 = new Personagem();

Console.Write($"Digite o nome do Personagem: ");
p1.nome = Console.ReadLine();

Console.Write($"Digite a idade do Personagem: ");
p1.idade = int.Parse(Console.ReadLine());

Console.Write($"Digite o nome da Armadura do Personagem: ");
p1.armadura = Console.ReadLine();

Console.Write($"Digite o nome da IA do Personagem: ");
p1.ia = Console.ReadLine();

Console.WriteLine($"\nNome: {p1.nome}, \nIdade: {p1.idade}, \nArmadura: {p1.armadura}, \nIA: {p1.ia}");
