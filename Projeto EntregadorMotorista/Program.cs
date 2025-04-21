using Projeto_EntregadorMotorista;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

class Program
{
    static void Main()
    {
        int op;
        Motorista m;
        Entregador e;

        List<Funcionario> Funcionarios = new List<Funcionario>();

        do
        {
            Console.WriteLine(" ______Menu Sedex______");
            Console.WriteLine(" 1. Cadastrar Motorista");
            Console.WriteLine(" 2. Cadastrar Entregador");
            Console.WriteLine(" 3. Exibir dados de todos funcionarios");
            Console.WriteLine(" 4. Mostrar dados de um funcionario");
            Console.WriteLine(" 5. Sair do programa\n");
            Console.Write("Digite o que deseja realizar: ");
            
            op = int.Parse(Console.ReadLine());
            Console.Write("\n");

            switch (op)
            {
                case 1:
                    m = new Motorista();
                    CadastrarFuncionario(m);
                    Console.Write("Horas Extras: ");
                    m.HorasExtras = double.Parse(Console.ReadLine());
                    Funcionarios.Add(m);
                    Console.WriteLine("\nFuncionario cadastrado com sucesso");

                    Console.ReadKey();
                    Console.Clear();

                    break;

                case 2:
                    e = new Entregador();
                    CadastrarFuncionario(e);
                    Console.Write("Quantidade de entregas: ");
                    e.Entregas = int.Parse(Console.ReadLine());
                    Funcionarios.Add(e);

                    Console.WriteLine("\nFuncionario cadastrado com sucesso");

                    Console.ReadKey();
                    Console.Clear();

                    break;

                case 3:

                    foreach (Funcionario aux in Funcionarios)
                    {
                        Console.WriteLine(aux.Mostra());
                        Console.WriteLine("____________________________________\n");
                    }

                    Console.ReadKey();
                    Console.Clear();

                    break;

                case 4:
                    Console.Write("Digite o nome do funcionario que deseja verificar: ");
                    string nomeverifcar = Console.ReadLine();
                    Console.WriteLine(" ");
                    bool encontrado = false;

                    foreach(Funcionario verificar in Funcionarios)
                    {
                        if(nomeverifcar == verificar.Nome)
                        {
                            Console.WriteLine(verificar.Mostra());
                            Console.WriteLine("Salario Total: " + verificar.CalculoSalario());
                            encontrado = true;
                        }

                        if (encontrado == false)
                        {
                            Console.WriteLine("Funcionário não encontrado.");
                        }
                    }
                    Console.ReadKey();
                    Console.Clear();

                    break;

                    case 5:
                    Console.WriteLine("Saindo...");

                    break;

            }



        } while (op != 5);
    }


    static void CadastrarFuncionario(Funcionario f)
    {
        Console.Write("Nome: ");
        f.Nome = Console.ReadLine();

        Console.Write("Salario Base: ");
        f.Salario = double.Parse(Console.ReadLine());
    }
}
