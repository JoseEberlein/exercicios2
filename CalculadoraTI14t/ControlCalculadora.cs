using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraTI14t
{
    class ControlCalculadora
    {
        ModelCalculadora modelo; //conectando a outra classe
        private int opcao;
        private double num1;
        private double num2;
        public ControlCalculadora()
        {
            modelo = new ModelCalculadora();//instanciando a variavel modelo, permite usar todos os metodos de "modelcalculadora"
            ConsultarOpcao = 0; //instanciando o metodo
            ConsultarNum1 = 0;
            ConsultarNum2 = 0;
        }//fim da controlcalculadora

        public int ConsultarOpcao
        {
            get
            {
                return opcao;
            }
            set
            {
                this.opcao = value;                    
            }

        }//fim do consultar opçao

        public double ConsultarNum1
        {
            get
            {
                return num1;
            }
            set
            {
                this.num1 = value;
            }
        }//fim do consultar num1
        public double ConsultarNum2
        {
            get
            {
                return num2;
            }
            set
            {
                this.num2 = value;
            }
        }//fim do consultar num2
          
        public void Menu()
        {
            Console.WriteLine("-----Menu-----\n\n" + 
                "1.Somar\n" +
                "2.Subtrair\n" +
                "3.Multiplicar\n" +
                "4.Dividir\n" +
                "5.Potencia\n" +
                "6.Raiz\n" +
                "0.Sair\n");
            Console.WriteLine("\n\nEscolha uma das opçoes acima");
            ConsultarOpcao = Convert.ToInt32(Console.ReadLine());
        }//fim do metodo menu

        public void Operacao()
        {
            do {
                Menu();//chamar o menu

                switch (ConsultarOpcao)
                {
                    case 1:
                        Coletar(); //coletar o primeiro e segundo numero
                        Console.WriteLine("O resultado da operacao é:" + modelo.Somar(ConsultarNum1, ConsultarNum2));
                        break;
                    case 2:
                        Coletar(); //coletar o primeiro e segundo numero
                        Console.WriteLine("O resultado da operacao é:" + modelo.Subtrair(ConsultarNum1, ConsultarNum2));
                        break;
                    case 3:
                        Coletar();
                        Console.WriteLine("O resultado da operacao é:" + modelo.Multiplicar(ConsultarNum1, ConsultarNum2));
                        break;
                    case 4:
                        Coletar();
                        if (modelo.Dividir(ConsultarNum1, ConsultarNum2) == -1)
                        {
                            Console.WriteLine("Impossivel dividir por zero:");
                        }
                        else
                        {
                            Console.WriteLine("O resultado da operacao :" + modelo.Dividir(ConsultarNum1, ConsultarNum2));
                        }
                        break;
                    case 5:
                        Coletar();
                        Console.WriteLine("O resultado da operacao é:" + modelo.Potencia(ConsultarNum1, ConsultarNum2));
                        break;
                    case 6:
                        Coletar();
                        Console.WriteLine("Informe um número para calcular a raiz");
                        ConsultarNum1 = Convert.ToInt32(Console.ReadLine());
                        if(ConsultarNum1 < 0)
                        {
                            Console.WriteLine("Impossivel calcular raiz de numero negativo");
                        }
                        else
                        {
                            Console.WriteLine("O resultado da operacao é:" + modelo.Raiz(ConsultarNum1));
                        }
                        break;
                    case 0:
                        Console.WriteLine("Obrigado!!!");
                        break;
                    default:
                        Console.WriteLine("Opção escolhida não é válida, tente novamente!");
                        break;
                }//fim do switch
            }while(ConsultarOpcao != 0);
        }//fim do metodo operacao
        public void Coletar()
        {
            Console.WriteLine("Informe o primeiro numero:");
            ConsultarNum1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe o segundo numero");
            ConsultarNum2 = Convert.ToDouble(Console.ReadLine());
        }//fim do coletar
    }//fim da classe
}//fim do projeto
