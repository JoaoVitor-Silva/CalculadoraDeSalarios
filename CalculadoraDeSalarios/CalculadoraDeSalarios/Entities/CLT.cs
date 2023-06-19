using CalculadoraDeSalarios.Entities.Enum;
using CalculadoraDeSalarios.Services;
using System.Globalization;

namespace CalculadoraDeSalarios.Entities
{
    sealed class CLT : Professor, ISalario
    {
        public double SalarioMensal { get; set; }

        public CLT(string nome, Regime regime, double salarioMensal)
            : base(nome, regime)
        {
            SalarioMensal = salarioMensal;
        }

        public double Salario()
        {
            return SalarioMensal;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode() + Nome.GetHashCode() + Regime.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            CLT otherCLT = (CLT)obj;
            return Id == otherCLT.Id && Nome == otherCLT.Nome && Regime == otherCLT.Regime;
        }

        public override string ToString()
        {
            return $"\n_______________________" +
                $"\nRegime: {Regime}" +
                $"\nNome: {Nome}" +
                $"\nSalario: {Salario().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
