using EncapsulamentoConta;
Conta C = new Conta();
C.Numero = 1; //set Numero(1);
Console.WriteLine("Numero: " + C.Numero); //getNumero()
// if (c.Numero > 5)
// x = c.Numero + 21;
//C.Sacar(10);
//C.MostrarAtributos();
C.Titular = "Ana";
Console.WriteLine("Nome: " + C.Titular);
C.Saldo = 100;
Console.WriteLine($"Saldo: {C.Numero:c}");