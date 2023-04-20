using ProjetoClassePersonagem;

//instanciar um objeto da classe Personagem
Personagem Tony = new Personagem();

//exibindo as informações do objeto
Console.WriteLine(Tony.nome);
Console.WriteLine(Tony.idade);
Console.WriteLine(Tony.armadura);
Console.WriteLine(Tony.ia);

//Chamando os métodos da clesse
Tony.Atacar();
Console.WriteLine(Tony.Defender());
Tony.RestaurarArmadura();

