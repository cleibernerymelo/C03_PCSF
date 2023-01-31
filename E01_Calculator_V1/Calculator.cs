using D00_Utility;
using System;

namespace E01_Calculator_V1
{
    internal class Calculator
    {
        #region Attributes
        private double numero1;
        private double numero2;
        private string operacao;
        #endregion

        #region Properties
        public  double Numero1
        {
            get
            {
                return numero1;
            }
            set
            {
                numero1 = value;
            }
        }

        public double Numero2
        {
            get
            {
                return numero2;
            }
            set
            {
                numero2 = value;
            }
        }

        public string Operacao
        {
            get
            {
                return operacao;
            }
            set
            {
                operacao = value;
            }
        }
        #endregion

        #region Constructor
        public Calculator() //--> Esse construtor seria o mesmo se eu fizesse new Calculator
        {
            Numero1 = 0;
            Numero2 = 0;
            Operacao = "";
        }
        #endregion

        #region Motor Calculadora
        public void MotorCalculator()
        {
            //while (Operacao != "S")
            //{
            //    Utility.MenuOptionsCalculator();

            //    Operacao = Console.ReadLine();

            //    if ((Operacao == "+") || (Operacao == "-") || (Operacao == "*") || (Operacao == "/"))
            //    {
            //        ReadValues();
            //    }
            //    ShowResult();
            //}

            do
            {
                //Utility.MenuOptionsCalculator();
                //Utility.MenuInical();

                Utility.MenuInical();

                Operacao = Console.ReadLine();                

                if ((Operacao == "1") || (Operacao == "2") || (Operacao == "3") || (Operacao == "4"))
                {
                    ReadValues();
                }
                ShowResult();
            }
            while (Operacao != "0");
        }
        #endregion

        #region Ler Valores
        public void ReadValues()
        {
            bool success;
            double resultInt;
            Console.Write("Nº: ");
            success = (double.TryParse(Console.ReadLine(), out resultInt));
            Numero1 = resultInt;
            Console.Write("Nº: ");
            success = double.TryParse(Console.ReadLine(), out resultInt);
            Numero2 = resultInt;

            //Testei o bloco código abaixo, pois queria informar ao utilizador que o valor informado estava no formato invalido
            //Em alguns testes ele passou, ou seja, o resultado foi o que eu esperava.
            //Mas em alguns testes que ele não devolveu o resultado expectado.
            //Referencia https://www.macoratti.net/17/08/c_difparse1.htm

            //Console.Write("Nº: ");
            //try
            //{
            //    Numero1 = double.Parse(Console.ReadLine());
            //}
            //catch (Exception)
            //{

            //    Console.WriteLine("Formato Inválido");
            //}

            //Console.Write("Nº: ");
            //try
            //{
            //    Numero2 = double.Parse(Console.ReadLine());
            //}
            //catch (Exception)
            //{

            //    Console.WriteLine("Formato Inválido");
            //}
        }
        #endregion

        #region Mostrar Resultado
        public void ShowResult()
        {
            double resultado = 0;
            bool value = true;

            switch (Operacao)
            {
                case "1":
                    {
                        resultado = Somar(Numero1, Numero2);
                        break;
                    };
                case "2":
                    {
                        resultado = Subtrair(Numero1, Numero2);
                        break;
                    };
                case "3":
                    {
                        resultado = Multiplicar(Numero1, Numero2);
                        break;
                    };
                case "4":
                    {
                        resultado = Dividir(Numero1, Numero2);
                        break;
                    };
                case "0":
                    {
                        Utility.EnvironmentExit();
                        break;
                    };
                default:
                    Utility.OptionInvalid();
                    value = false;
                    break;
            }
            if (value == true)
            {
                Console.WriteLine($"Resultado {Numero1} {Operacao} {Numero2} = {Math.Round(resultado,3)}");
            }
            Console.ReadKey();
            Console.Clear();
        }
        #endregion

        #region Somar
        public double Somar(double Numero1, double Numero2)
        {
            double resultado = Numero1 + Numero2;
            return resultado;
        }
        #endregion

        #region Subtrair
        public double Subtrair(double Numero1, double Numero2)
        {
            double resultado = Numero1 - Numero2;
            return resultado;
        }
        #endregion

        #region Multiplicar
        public double Multiplicar(double Numero1, double Numero2)
        {
            double resultado = Numero1 * Numero2;
            return resultado;
        }
        #endregion

        #region Dividir
        public double Dividir(double Numero1, double Numero2)
        {
            double resultado = Numero1 / Numero2;
            return resultado;
        }
        #endregion
    }
}
