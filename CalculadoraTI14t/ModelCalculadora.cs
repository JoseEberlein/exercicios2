using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraTI14t
{
    class ModelCalculadora
    {
        //public - publica todo o projeto enxerga essa variavel
        //private - apenas a classe que ela foi criada enxerga a variavel
        //protected - somente a familia enxerga a variavel

        private double num1;
        private double num2;

        public ModelCalculadora()
        {
            //instanciando as variaveis
            ModificarNum1 = 0;
            ModificarNum2 = 0;
        }//fim do metodo construtor

        //metodos de acesso - get(consultar) e set(modificar)

        public double ModificarNum1
        {
            get
            {
                return num1;
            }

            set
            {
                this.num1 = value;
            }
        }//fim do metodo modificar num1

        public double ModificarNum2
        {
            get
            {
                return num2;
            }
            set
            {
                this.num2 = value;
            }

        }//fim do metodo modificar num2
        public double Somar(double num1, double num2)
        {
            ModificarNum1 = num1;
            ModificarNum2 = num2;
            return ModificarNum1 + ModificarNum2;
        }//fim do metodo soma
        public double Subtrair(double num1, double num2)
        {
            ModificarNum1 = num1;
            ModificarNum2 = num2;
            return ModificarNum1 - ModificarNum2;
        }//fim do metodo subtrair
        public double Multiplicar(double num1, double num2)
        {
            ModificarNum1 = num1;
            ModificarNum2 = num2;
            return ModificarNum1 * ModificarNum2;
           
        }//fim do metodo multiplicar
        public double Dividir(double num1, double num2)
        {
            ModificarNum1 = num1;
            ModificarNum2 = num2;
            //validaçao
            if(ModificarNum2 == 0)
            {
                return -1;
            }
            return ModificarNum1 / ModificarNum2;
        }//fim do metodo dividir
        public double Potencia(double num1, double num2)
        {
            ModificarNum1 = num1;
            ModificarNum2 = num2;
            return Math.Pow(ModificarNum1, ModificarNum2);
        }//fim do metodo potencia
        public double Raiz(double num1)
        {
            ModificarNum1 = num1;
            //validaçao
            if(ModificarNum1 <0 )
            {
                return -1;
            }
            return Math.Sqrt(ModificarNum1);
        }//fim do metodo raiz
    }//fim da classe
}//fim do projeto
