using System;

/* A sobrecarga de métodos ocorre quando utilizamos métodos iguais, porém as suas "assinaturas" são diferentes. 
   A assinatura de um método é o tipo de retorno e seus parametros, ou argumentos(tipos e quantidade).
*/
class Pessoa
{
    public string nome;

    public int idade;

    //método sem parametro
    public void saudacaoInicial()
    {
        Console.WriteLine("Olá!!!");
    }

    //método com apenas 1 parametro
    public void saudacaoInicial( string nome)
    {
        Console.WriteLine("Olá "+nome);
    }
    
    //método com n parametros
    public void saudacaoInicial(string nome, int idade)
    {
        Console.WriteLine("olá "+nome+" você tem "+idade+" anos!");    
    }
}