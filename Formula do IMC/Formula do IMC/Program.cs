
public class Peso
{
    static void Main(string[] args)
    {
        float peso = 0;
        float altura = 0;


        Console.WriteLine("Informe seu peso");

        peso =
            float.Parse(Console.ReadLine());

        Console.Clear();
        Console.WriteLine($"Sua peso é :{peso}");


        Console.WriteLine("Informe sua altura");
        altura =
            float.Parse(Console.ReadLine());


        Console.Clear();
        Console.WriteLine($"Sua altura é :{altura}");

        if (peso >= 18) ;
        {
            Console.WriteLine("Abaixo do peso");
        }
        if (peso >= 18) ;
        {
            Console.WriteLine("Peso ideal");
        }
        if (peso >= 18) ;
        {
            Console.WriteLine("Levemente acima do peso");
        }
        if (peso >= 18) ;
        {
            Console.WriteLine("Obeso grau 1");
        }
    }
}