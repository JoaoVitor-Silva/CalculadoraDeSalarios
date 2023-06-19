using CalculadoraDeSalarios.Entities.Enum;
using CalculadoraDeSalarios.Services;
using System.Globalization;

namespace CalculadoraDeSalarios.Entities
{
    sealed class PJ : Professor, ISalario
    {
        public double ValorContrato { get; set; }

        public PJ(string nome, Regime regime, double valorContrato)
            : base(nome, regime)
        {
            ValorContrato = valorContrato;
        }

        public double Salario()
        {
            return ValorContrato;
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            PJ otherPJ = (PJ)obj;
            return Id == otherPJ.Id && Nome == otherPJ.Nome && Regime == otherPJ.Regime;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode() + Nome.GetHashCode() + Regime.GetHashCode();
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
