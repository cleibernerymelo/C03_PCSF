using D00_Utility;
using System;

namespace E01_Calculator_V1
{
    internal class Calculator
    {
        #region Attributes
        private decimal numero1;
        private decimal numero2;
        private string operacao;
        #endregion

        #region Properties
        public  decimal Numero1
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

        public decimal Numero2
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
            decimal resultInt;
            Console.Write("Nº: ");
            success = (decimal.TryParse(Console.ReadLine(), out resultInt));
            Numero1 = resultInt;
            Console.Write("Nº: ");
            success = decimal.TryParse(Console.ReadLine(), out resultInt);
            Numero2 = resultInt;
            #region Comments
            //Testei o bloco código abaixo, pois queria informar ao utilizador que o valor informado estava no formato invalido
            //Em alguns testes ele passou, ou seja, o resultado foi o que eu esperava.
            //Mas em alguns testes que ele não devolveu o resultado expectado.
            //Referencia https://www.macoratti.net/17/08/c_difparse1.htm

            //try
            //{
            //    Numero1 = double.Parse(Console.ReadLine());
            //    Numero2 = double.Parse(Console.ReadLine());
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("\n\nErro ao dividir por zero.");
            //}
            //catch (ArgumentException)
            //{
            //    Console.WriteLine("\n\nArgumento em falta.");
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("\n\nFormato incorreto.");
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("\n\nAconteceu um erro");
            //    //throw;
            //}
            //finally
            //{
            //    Console.WriteLine("\n\nA terminar.");
            //}
            #endregion
        }
        #endregion

        #region Mostrar Resultado
        public void ShowResult()
        {
            decimal resultado = 0;
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
        public decimal Somar(decimal Numero1, decimal Numero2)
        {
            decimal resultado = Numero1 + Numero2;
            return resultado;
        }
        #endregion

        #region Subtrair
        public decimal Subtrair(decimal Numero1, decimal Numero2)
        {
            decimal resultado = Numero1 - Numero2;
            return resultado;
        }
        #endregion

        #region Multiplicar
        public decimal Multiplicar(decimal Numero1, decimal Numero2)
        {
            decimal resultado = Numero1 * Numero2;
            return resultado;
        }
        #endregion

        #region Dividir
        public decimal Dividir(decimal Numero1, decimal Numero2)
        {
            decimal resultado = 0;
           
            try
            {
                resultado = Numero1 / Numero2;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("\n\nErro ao dividir por zero.");
            }
            catch (Exception)
            {
                Console.WriteLine("\n\nFormato incorreto.");
            }
            finally
            {
                Console.WriteLine("\n\nA terminar.");
            }

            return resultado;
        }
        #endregion
    }
}
