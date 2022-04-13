using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraTI14t
{
    class Program
    {
        static void Main(string[] args)
        {
            //conectamos a control a program
            ControlCalculadora control = new ControlCalculadora();
            //chamar o metodo que sera utilizado
            control.Operacao();
            Console.ReadLine();//manter o prompt aberto
        }//fim do método main
    }//fim da classse
}//fim do projeto
