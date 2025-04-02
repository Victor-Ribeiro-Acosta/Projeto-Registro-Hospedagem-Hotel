using Models;

namespace Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite suiteReserva { get; set; }
        public int diasReservados { get; set; }


        public void CadastrarSuite(Suite suite)
        {
            suiteReserva = suite;
        }

        public void CadastrarHospede(List<Pessoa> hospedes)
        {
                Hospedes = hospedes;
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count();
        }

        public void ValidarNumeroHospedes(int numHospedes)
        {
              if (suiteReserva.Capacidade < numHospedes)
            {
                throw new Exception("A suite escolhida não comporta esse número de pessoas.");
            }
        }

        public decimal ValorTotal()
        {
            return diasReservados * suiteReserva.valorDiaria;
        }
    }
}