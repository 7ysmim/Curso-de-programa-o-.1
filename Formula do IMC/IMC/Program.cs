 
//==============Variaveis

float peso;
float altura;
float imc;
string opcao;


//==========Lógica
while (true)
{
    Console.WriteLine("Informe seu peso!");
        peso = float.Parse(Console.ReadLine());

    Console.WriteLine("Informe sua altura!");
    altura = float.Parse(Console.ReadLine());

     imc = peso / (altura * altura);
    Console.WriteLine($"Seu IMC: {imc:F2}");

    Console.WriteLine("Deseja calcula outro IMC s/n");
        opcao = Console.ReadLine();

     if ( opcao != "s")
    {
        break;
    }

    Console.Clear();


}






