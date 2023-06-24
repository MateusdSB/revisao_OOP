/* A sobrecarga de métodos ocorre quando utilizamos métodos iguais, porém as suas "assinaturas" são diferentes.
   A assinatura de um método é o tipo de retorno e seus parametros, ou argumentos(tipos e quantidade).
*/

class Program
{
    private static void Main(string[] args)
    {
        //sobrescrita de métodos
        Console.WriteLine("Conceitos sobre sobrecarga de métodos");
        Pessoa alguem = new Pessoa();
        
        alguem.saudacaoInicial();
        alguem.saudacaoInicial("joaquim");
        alguem.saudacaoInicial("joaquim", 25);
    }
}
