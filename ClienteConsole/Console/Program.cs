using Console.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Service1Client client = new ServiceReference1.Service1Client();

            // Use a variável 'client' para chamar as operações no serviço.
            client.Open();
            do
            {
                System.Console.Clear();
                System.Console.WriteLine("Digite o valor A: ");
                int a = int.Parse(System.Console.ReadLine());
                System.Console.WriteLine("Digite o valor B: ");
                int b = int.Parse(System.Console.ReadLine());
                var result = client.Soma(a,b);
                System.Console.WriteLine(result);
                System.Console.ReadKey();
            }
            while(true);
            // Sempre feche o cliente.
            client.Close();
        }
    }
}
