using System;

namespace SegundoProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            //Laços de Repetição
            Console.WriteLine("Projeto 10 - calcula poupança com While!");

            double ValorInvestido = 1000;
            int ContadorMes = 1;

            while(ContadorMes <= 12)
            {
                // 0.36 = 0.0036 
                ValorInvestido = ValorInvestido + ValorInvestido * 0.0036;
                Console.WriteLine("Após "+ ContadorMes +" mês voce terá " + ValorInvestido);
                //ContadorMes += 1;
                ContadorMes++;
            }


            Console.WriteLine("Projeto 11 - calcula poupança com for!");
            
            double ValorInvestido1 = 1000;

            for(int Contador = 1; Contador <= 12; Contador++)
            {
                ValorInvestido1 *= 1.0036;
                Console.WriteLine("Após "+ Contador +" mês voce terá " + ValorInvestido1);
            }

            Console.WriteLine("Projeto 12 - calcula poupança com for encadeado");

            double fatorRedimento = 1.0036;
            double valorInvestido = 1000;

            for(int ContadorAno=1; ContadorAno<=5; ContadorAno++)
            {
                for(int contadorMes=1; contadorMes <= 12; contadorMes++)
                {
                    valorInvestido *= fatorRedimento;
                }

                fatorRedimento += 0.0010;
            }
            Console.WriteLine("Ao fim do inestimento você terá " + valorInvestido + " reais");

            
            //projeto 13 - utilizando o break no for
            Console.WriteLine("Projeto 13 - Break");
            // *
            // **
            // ***
            // ****
            // *****

            for(int ContadorLinha=0; ContadorLinha<10; ContadorLinha++)
            {
                for(int ContadorColuna=0;ContadorColuna<10;ContadorColuna++)
                {
                    Console.Write("*");
                    if(ContadorColuna >= ContadorLinha)
                        break;
                }
                Console.WriteLine();
            }

            //outra forma de fazer os asteriscos sem o break
            for(int ContadorLinha=0; ContadorLinha<10; ContadorLinha++)
            {
                for(int ContadorColuna=0;ContadorColuna<=ContadorLinha;ContadorColuna++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for(int linha = 0; linha < 5; linha++)
            {
                for (int coluna = 0; coluna < 5; coluna++)
                {
                    if (coluna > linha)
                    {
                        break;
                    }
                    Console.Write(coluna+1);
                }
                Console.WriteLine();
            }

            for (int i = 1; i < 100; i++ )
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            int fatorial =1;
            for(int i = 0;i <=10;i++)
            {
                fatorial *= i;
                Console.WriteLine("Fatorial de " + i + " = " + fatorial);
            }

            Console.ReadLine();
        }
    }
}
