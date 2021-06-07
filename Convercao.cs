using System;
using System.Globalization;

namespace Course5 {

    class Convercao {
    
        static void Main(string[] args) {

            int num;
            char caracter;
            double num2;

            Console.WriteLine("Digite um número inteiro");
            num = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite uma unica letra");
            caracter = char.Parse(Console.ReadLine());

            //dessa forma se colocar "."(ponto) não funcionará de acordo
            Console.WriteLine("Digite um número componto flutiante");
            num2 = double.Parse(Console.ReadLine());
            
            
            Console.WriteLine("Digite um número componto flutiante");
            num2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
        }
    }
}
