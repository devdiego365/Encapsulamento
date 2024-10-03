// See https://aka.ms/new-console-template for more information
using Visibilidade;


Pessoa p =  new Pessoa();
p.setNome("Diego");
Console.WriteLine(p.getNome());


p.setIdade(8);
Console.WriteLine(p.getIdade());

p.setTelefone("81993966901");
Console.WriteLine(p.getTelefone());

p.setEmail("diegodasilva365@gmail.com");
Console.WriteLine(p.getEmail());

p.setEndereco("Cabo");
Console.WriteLine(p.getEndereco());

Console.ReadKey();