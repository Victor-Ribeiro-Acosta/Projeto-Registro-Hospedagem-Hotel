using System.Diagnostics.Contracts;
using Models;


Console.Clear();
(int numeroSuite,string Tipo, int capacidade, decimal valor) dadosSuite;
List<Reserva> reservasRealizadas = new List<Reserva>();
Mensagem Mensagens = new Mensagem();
bool condicao = true;


while (condicao)
{
    Reserva reserva = new Reserva();
    List<Pessoa> hospedes = new List<Pessoa>();
    Console.Clear();

    Mensagens.MensagemCabeçalho();
    int operacao = Convert.ToInt32(Console.ReadLine());

    if (operacao == 1)
    {
        if(reservasRealizadas.Count() > 0)
        {
            foreach (Reserva resevaRealizada in reservasRealizadas)
            {
                Console.WriteLine($"Suite: {resevaRealizada.suiteReserva.Numero} - Tipo: {resevaRealizada.suiteReserva.TipoSuite} - Ocupantes: {resevaRealizada.Hospedes.Count()}");
            }
             Mensagens.MensagemPausa();
        }
        else
        {
            Console.WriteLine("Não há reservas registradas");
            Mensagens.MensagemPausa();
        }
    }
    else if(operacao == 2)
    {
        Mensagens.MensagemMenu();
        string tipoSuite = Console.ReadLine();

        if (tipoSuite.ToLower() == "comum")
        {
            Console.WriteLine("Informe o número da suíte [101, 102, 103, 104, 105, 106, 107]");
            int numero = Convert.ToInt32(Console.ReadLine());
            dadosSuite = (numero, "Comum", 6, 100.0M);
        }
        else if (tipoSuite.ToLower() == "premium")
        {
            Console.WriteLine("Informe o número da suíte [201, 202, 203, 204, 205, 206, 207]");
            int numero = Convert.ToInt32(Console.ReadLine());
            dadosSuite = (numero, "Premium", 6, 150.0M);
        }
        else if (tipoSuite.ToLower() == "master")
        {
            Console.WriteLine("Informe o número da suíte [301, 302, 303, 304, 305, 306, 307]");
            int numero = Convert.ToInt32(Console.ReadLine());
            dadosSuite = (numero, "Master", 3, 200.0M);
        }
        else
        {
            throw new Exception("Tipo de suite não condiz com as especificadas!");
        }

        Suite suite = new Suite(dadosSuite.numeroSuite, dadosSuite.Tipo, dadosSuite.capacidade, dadosSuite.valor);
        reserva.CadastrarSuite(suite);
        Console.Clear();



        Console.WriteLine("Informe o número de pessoas a serem hospedadas na suite");
        int numeroHopedes = Convert.ToInt32(Console.ReadLine());
        reserva.ValidarNumeroHospedes(numeroHopedes);

        for (int contador = 1; contador <= numeroHopedes; contador++)
        {
            Console.WriteLine($"Informe o nome do {contador}º hospede:");
            string nome = Console.ReadLine();
            Console.WriteLine($"Informe o sobrenome do {contador}º hospede:");
            string sobrenome = Console.ReadLine();

            Pessoa pessoa = new Pessoa(nome, sobrenome);
            hospedes.Add(pessoa);
            Console.Clear();
        }

        reserva.CadastrarHospede(hospedes);



        Console.WriteLine("Informe o número de dias hospedados");
        int dias = Convert.ToInt32(Console.ReadLine());
        reserva.diasReservados = dias;
        reservasRealizadas.Add(reserva);

        Console.WriteLine($"Número de hóspedes: {reserva.ObterQuantidadeHospedes()}");
        Console.WriteLine($"Valor total: {reserva.ValorTotal()}");
        Mensagens.MensagemPausa();

    }
    else if (operacao == 3)
    {
        Console.WriteLine("Encerrando sistema");
        condicao = false;
    }
    else
    {
        Console.WriteLine("Operação inválida");
    }
}
