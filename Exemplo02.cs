
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

//Se você declarar um campo com um publicmodificador de acesso, ele ficará acessível para todas as classes:

namespace ModificadorDeAcesso;
   public class Exemplo02
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Roupa blusa = new Roupa();

            Console.WriteLine(blusa.marca);
        }
    }
}







