using System;
using System.Collections.Generic;

namespace Data
{
    public class Menu
    {
        public void Menu_()
        {
            var i = 1;
            while (i == 1)
            {
                Console.Clear();
                Console.WriteLine("Escolha uma das opcoes abaixo");
                Console.WriteLine("1. Consultar nome e sobrenome a partir de um nome de usuario");
                Console.WriteLine("2. Incluir uma pessoa");
                Console.WriteLine("3. Excluir pessoa");
                Console.WriteLine("4. Consultar aeroporto a partir de um endereco");
                Console.WriteLine("5. Sair");
                var opc = Console.ReadLine();
                Console.Clear();
                if (opc.Equals("1"))
                {
                    GetUser g = new GetUser();
                    Console.WriteLine("Digite o nome de usuario ou parte dele");
                    var result = g.GetUsers(Console.ReadLine());
                    Console.Clear();
                    foreach (var results in result)
                    {
                        Console.WriteLine("\nNome: {0}, Sobrenome: {1}", results.FirstName, results.LastName);
                    }
                    Console.WriteLine("\nAperte qualquer tecla para voltar ao menu");
                    Console.ReadKey();
                }
                else if (opc.Equals("2"))
                {
                    People people = new People();
                    PostUser p = new PostUser();
                    Console.WriteLine("Digite o nome de usuario");
                    people.UserName = Console.ReadLine();
                    Console.WriteLine("Digite o primeiro nome");
                    people.FirstName = Console.ReadLine();
                    Console.WriteLine("Digite o ultimo nome");
                    people.LastName = Console.ReadLine();
                    Console.WriteLine("Digite o Email");
                    people.Emails.Add("" + Console.ReadLine() + "");
                    p.PostUsers(people);
                    Console.WriteLine("\nAperte qualquer tecla para voltar ao menu");
                    Console.ReadKey();
                }
                else if (opc.Equals("3"))
                {
                    DeleteUser d = new DeleteUser();
                    Console.WriteLine("Digite o nome de usuario para excluir");
                    d.DeleteUsers(Console.ReadLine());
                    Console.WriteLine("\nAperte qualquer tecla para voltar ao menu");
                    Console.ReadKey();
                }
                else if (opc.Equals("4"))
                {
                    GetAir ga = new GetAir();
                    Console.WriteLine("Digite o endereco ou parte dele");
                    var result = ga.GetAirs(Console.ReadLine());
                    Console.Clear();
                    foreach (var results in result)
                    {
                        Console.WriteLine("\nNome: {0}, IataCode: {1}", results.Name, results.IataCode);
                    }

                    Console.WriteLine("\nAperte qualquer tecla para voltar ao menu");
                    Console.ReadKey();

                }

                else if (opc.Equals("5"))
                    break;
            }
        }
    }
}

