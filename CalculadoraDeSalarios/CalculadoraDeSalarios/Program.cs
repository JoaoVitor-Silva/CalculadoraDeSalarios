
using CalculadoraDeSalarios.Entities;
using CalculadoraDeSalarios.Entities.Enum;
using System.Globalization;


namespace CalculadoraDeSalarios
{
    class Program
    {
        static void Main(string[] args)
        {
            bool StatusExecute = true;
            HashSet<Professor> Professores = new HashSet<Professor>();

            while (StatusExecute != false)
            {
                Console.Clear();
                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.WriteLine("Regime de trabalho: " +
                    "\n1- CLT" +
                    "\n2- PJ" +
                    "\n3- Horista" +
                    "\n4- Sair");
                byte option = byte.Parse(Console.ReadLine());

                Console.Clear();

                if (option == 1)
                {
                    Console.Write("Salario mensal: ");
                    double salarioMensal = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Professores.Add(new CLT(nome, Regime.CLT, salarioMensal));
                }
                else if (option == 2)
                {
                    Console.Write("Valor de contrato: ");
                    double valorContrato = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Professores.Add(new PJ(nome, Regime.PJ, valorContrato));
                }
                else if (option == 3)
                {
                    Console.Write("Valor por hora: ");
                    double valorPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.Write("Horas trabalhadas: ");
                    int horasTrabalhadas = int.Parse(Console.ReadLine());

                    Professores.Add(new Horista(nome, Regime.Horista, horasTrabalhadas, valorPorHora));
                }
                else
                {
                    StatusExecute = false;
                }
            }

            foreach (Professor professores in Professores)
            {
                Console.WriteLine(professores);
            }
        }
    }
}




