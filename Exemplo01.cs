using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

//Se você declarar um campo com um privatemodificador de acesso, ele só poderá ser acessado dentro da mesma classe:

namespace ModificadorDeAcesso
{
    internal class Tenis
    {
       private string marca = "Adidas";

        public static void Main(string[] args)
        {
         Tenis tenis1 = new Tenis();
         Console.WriteLine(tenis1.marca);
       }
  }
}
