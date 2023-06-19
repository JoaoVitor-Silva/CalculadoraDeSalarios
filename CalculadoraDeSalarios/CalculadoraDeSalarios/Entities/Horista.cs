using CalculadoraDeSalarios.Entities.Enum;
using CalculadoraDeSalarios.Services;
using System.Globalization;

namespace CalculadoraDeSalarios.Entities
{
    sealed class Horista : Professor, ISalario
    {
        public int HorasTrabalhadas { get; set; }
        public double ValorHora { get; set; }

        public Horista(string nome, Regime regime, int horasTrabalhadas, double valorHora)
            : base(nome, regime)
        {
            HorasTrabalhadas = horasTrabalhadas;
            ValorHora = valorHora;
        }

        public double Salario()
        {
            return HorasTrabalhadas * ValorHora;
        }

        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Horista otherHorista = (Horista)obj;
            return Id == otherHorista.Id && Nome == otherHorista.Nome && Regime == otherHorista.Regime;
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
