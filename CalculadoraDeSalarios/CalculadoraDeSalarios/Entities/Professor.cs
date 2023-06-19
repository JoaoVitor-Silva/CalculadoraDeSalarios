using CalculadoraDeSalarios.Entities.Enum;

namespace CalculadoraDeSalarios.Entities
{
    abstract class Professor
    {

        public Guid Id { get; set; } = Guid.NewGuid();
        public string Nome { get; set; }
        public Regime Regime { get; set; }

        public Professor() { }

        public Professor(string nome, Regime regime)
        {
            Nome = nome;
            Regime = regime;
        }
    }
}
