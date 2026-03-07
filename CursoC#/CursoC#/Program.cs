using System.ComponentModel.Design;

partial class Program
{

    static void Main(string[] args)
    {

        // Variavel
        int idade = 0;
        string opcao;

        // estrutura de  Repetição While => Enquanto
        while (true)
        {

            // Mensagem para usuario 
            Console.WriteLine("Informe sua idade");

            // Atribuir valor que o usuario digita na variavel
            idade =
                 int.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine($"Sua idade é :{idade}");

            // Estrutura  Condicional IF
            if (idade >= 18)
            {
                Console.WriteLine("Maior de idade");
            }
            else
            {
                Console.WriteLine("Menor de idade");
            }
            // Finalizando estrutura de repetição

            Console.WriteLine
            ("Deseja analisar outra idade s/n");
            opcao = Console.ReadLine();

            if( opcao != "s")
            {
                break;
           
            }
       
             Console.Clear ();


        }   // fim while



           for(int i = 0; i <1000; i++)
        {
            Console.WriteLine("No lowCode");
        }
        
            
    }
}
