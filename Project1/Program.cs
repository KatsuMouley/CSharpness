namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            double convertido = 0; // Initialize the variable
            Console.WriteLine("Program: Digite um valor em real: ");
            double value;
            while (!double.TryParse(Console.ReadLine(), out value))
            {
                Console.WriteLine("Valor inválido, por favor digite um número:");
            }

            Console.WriteLine("Agora escolha uma das 3 moedas \nA)Dólar\nB)Euro\nC)Peso Argentino: ");
            char choice = (char)Console.Read(); // Cast to char
            
            switch (choice)
            {
                case 'A':
                case 'a':
                    convertido = value / 5.17;
                    Console.WriteLine("O valor convertido é: " + convertido + " Dólares");
                    break;
                case 'B':
                case 'b':
                    convertido = value / 6.14;
                    Console.WriteLine("O valor convertido é: " + convertido + " Euros");
                    break;
                case 'C':
                case 'c':
                    convertido = value / 0.05;
                    Console.WriteLine("O valor convertido é: " +  convertido.ToString("F2") + " Pesos Argentinos");
                    break;
                default:
                    Console.WriteLine("Por favor, escolha uma opção válida.");
                    break;
            }
        }
    }
}
