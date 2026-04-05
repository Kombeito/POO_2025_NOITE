using ArrayConta;
internal class Program
{
    private static void Main(string[] args)
    {
        //declaração de vetor - fora do laço
        Conta[] vetConta = new Conta[3];
        for (int i = 0; i < vetConta.Length; i++){
            // instanciação de cada indice
            vetConta[i] = new Conta();
            Console.Write("Digite o número da conta: ");
            vetConta[i].numero = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite um titular: ");
            vetConta[i].titular = Console.ReadLine();
            Console.Write("Digite o saldo: ");
            vetConta[i].saldo = Convert.ToDouble(Console.ReadLine());
        }
        vetConta[1].MostrarAtributos();


    }
}