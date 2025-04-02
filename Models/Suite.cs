
namespace Models
{
    public class Suite
    {
        public Suite(int numeroSuite, string tipo, int capacidade, decimal valor)
        {
            Numero = numeroSuite;
            TipoSuite = tipo;
            Capacidade = capacidade;
            valorDiaria = valor;
        }
        public int Numero { get; set; }
        public string TipoSuite { get; set; }
        public int Capacidade { get; set; }
        public decimal valorDiaria { get; set; }
    }
}