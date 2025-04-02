namespace Models
{
    public class Mensagem
    {
       public void MensagemCabeçalho()
       {
        Console.WriteLine("Registro no Hotel");
        Console.WriteLine("Informe sua operação");
        Console.WriteLine("1 - Consultar reservas\n2 - Realizar reserva\n3 - sair");
       }
       public void MensagemPausa()
       {
            Console.WriteLine("Presione ENTER para continuar");
            Console.ReadLine();
       }

       public void MensagemMenu()
       {
            Console.WriteLine(
            "Informe o tipo de suite" +
            "\nComum - capacidade: 6  Diaria: R$ 100.00" +
            "\nPremium - capacidade: 6  Diaria: R$ 150.00" +
            "\nMaster - capacidade: 3  Diaria: R$ 200.00"
            );
       }
    }
}