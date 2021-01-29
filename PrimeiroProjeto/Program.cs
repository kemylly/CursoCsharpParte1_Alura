using System;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá");

            //criando variaveis numericas e operacoes
            int idade;
            idade = 32;

            Console.WriteLine(idade);

            Console.WriteLine("Idade: " + idade);

            idade = 10;
            Console.WriteLine("Idade agora é: " + idade);

            idade = 32 + 10;
            Console.WriteLine("Soma das idades: " + idade);

            idade = 32 - 10;
            Console.WriteLine("Soma das idades: " + idade);

            idade = 32 * 10;
            Console.WriteLine("Soma das idades: " + idade);

            idade = 10 / 10;
            Console.WriteLine("Soma das idades: " + idade);

            idade = 32 * (10 + 2);
            Console.WriteLine("Soma das idades: " + idade);

            //crinado variaveis com numeros com virgula
            //variaveis com pontos flutuantes
            double salario;
            salario = 1500.99;

            Console.WriteLine("Salario: " + salario);

            salario = salario / idade;

            Console.WriteLine("Salario dividido pela idade: " + salario);

            //conversao para outros tipos numericos
            double salarioDouble;
            salarioDouble = 1200.70;

            int salarioInteiro;
            salarioInteiro = (int)salarioDouble; //convertendo double para int 

            Console.WriteLine(salarioInteiro);
            
            //o int é um tipo de variavel de 64 bits
            long idadelonga;
            idadelonga = 12222222222222299;
            Console.WriteLine(idadelonga);

            //o short pe uma variavel de 16 bits
            short idadePequena;
            idadePequena = 150;
            Console.WriteLine(idadePequena);

            //o float ele tem menos casas decimais que o double
            float altura = 15.10f;
            Console.WriteLine(altura);

            //Caracteres e Textos
            Console.WriteLine("Executando o Porjeto 5 de caracteres e textos");

            //character
            char unicaLetra = 'k'; //aspas simples
            Console.WriteLine(unicaLetra);

            unicaLetra = (char)65; //fazer o cast => conversoes
            Console.WriteLine(unicaLetra); //sai um A => olhar a tabela ASCII

            unicaLetra = (char)(unicaLetra + 1);
            Console.WriteLine(unicaLetra);

            //trabalhando com strings
            string titulo = "Akatsuki no Yona" + 2021; //aspas duplas
            Console.WriteLine(titulo);

            string CursoDeProgramacao = @" - .Net
                - java
                - JavaScript";

            Console.WriteLine(CursoDeProgramacao);

            Console.WriteLine(titulo + salarioInteiro); //concatenando string e int

            //projeto 6 - variaveis guardam valores
            int idade1 = 32;
            int idade2 = idade1; //ele só substitui

            idade1 = 20;
            //variaveis guardam valores e não referencias
            Console.WriteLine(idade1);
            Console.WriteLine(idade2);

            //executando o projeto 7 - Condicional
            Console.WriteLine("Condicionais");

            int idadeYona = 16;
            int quantidadeDePessoas = 2;

            if( idadeYona >= 18)
            {
                Console.WriteLine("Yona possui mais de 18 anos");
            }
            else
            {
                if(quantidadeDePessoas >= 2)
                {
                    Console.WriteLine("Yona possui menos de 18 anos, mas está acompanhada");
                }
                else
                {
                    Console.WriteLine("Yona possui menos de 18 anos");
                }
            }


            //Executando o projeto 8 - Condicionais 2 - Variavel Booleana
            Console.WriteLine("Variavel Booleana");

            int idadeHak = 16;
            int QuantidadeDePessoas = 2;
            //bool Acompanhante = true;
            bool Acompanhante = QuantidadeDePessoas >= 2;

            if( idadeHak >= 18 || QuantidadeDePessoas >= 2) // OU
            {
                Console.WriteLine("Pode entrar");
            }
            else
            {
                Console.WriteLine("Não pode entrar");
            }

            if( idadeHak >= 18 && QuantidadeDePessoas >= 2) // E
            {
                Console.WriteLine("Pode entrar");
            }
            else
            {
                Console.WriteLine("Não pode entrar");
            }

            if( idadeHak >= 18 && Acompanhante == true) // True ou False
            {
                Console.WriteLine("Pode entrar");
            }
            else
            {
                Console.WriteLine("Não pode entrar");
            }


            //Projeto 9 - Escopo
            Console.WriteLine("Escopo");

            //variaveis globais podem ser usadas em todos os lugares
            int IdadeYONA = 18;
            bool Acompanhada = false;
            string mensagemAdicional;

            if (Acompanhada == true)
            {
                //se criar uma variavei aqui, ela se torna uma varievale local
                //e não pode ser usada fora desse if
                //Pode adiciona valores aqui, para ser usados fora
                mensagemAdicional = "Yona está acompanhada";
            }
            else
            {
                mensagemAdicional = "Yona está sozinha";
            }

            if( IdadeYONA >= 18 && Acompanhante == true) 
            {
                Console.WriteLine("Pode entrar");
                Console.WriteLine(mensagemAdicional);
            }
            else
            {
                Console.WriteLine("Não pode entrar");
                Console.WriteLine(mensagemAdicional);
            }

            int QuantidadeDePessoa = 2;
            //verificacao a condicao de entrar a patir dos acompanhates
            if (QuantidadeDePessoa >= 2)
            {
                Acompanhada = true;
            }
            else
            {
                Acompanhada = false;
            }

            if( IdadeYONA >= 18 && Acompanhante) 
            {
                Console.WriteLine("Pode entrar");
            }
            else
            {
                Console.WriteLine("Não pode entrar");
            }


            //calculo do imposto de renda
            //De 1900.0 até 2800.0, o IR é de 7.5% e pode deduzir na declaração o valor de R$ 142;
            // De 2800.01 até 3751.0, o IR é de 15% e pode deduzir R$ 350;
            // De 3751.01 até 4664.00, o IR é de 22.5% e pode deduzir R$ 636.

            double salario1 = 3300.0;

            if(salario1 >= 1900.0 && salario <= 2800.0)
            {

            }
            else
            {
                if(salario1 > 2800.0 && salario <= 3751.0)
                {

                }
                else
                {
                   if(salario1 > 3751.01 && salario <= 4664.00)
                    {

                    } 
                    else
                    {

                    }
                }
            }

            //estudando switch
            int mes = 13;

            switch (mes)
            {
                case 1:
                    Console.WriteLine("O mês é Janeiro");
                    break;
                case 2:
                    Console.WriteLine("O mês é Fevereiro");
                    break;
                case 3:
                    Console.WriteLine("O mês é Março");
                    break;
                case 4:
                    Console.WriteLine("O mês é Abril");
                    break;
                case 5:
                    Console.WriteLine("O mês é Maio");
                    break;
                case 6:
                    Console.WriteLine("O mês é Junho");
                    break;
                case 7:
                    Console.WriteLine("O mês é Julho");
                    break;
                case 8:
                    Console.WriteLine("O mês é Agosto");
                    break;
                case 9:
                    Console.WriteLine("O mês é Setembro");
                    break;
                case 10:
                    Console.WriteLine("O mês é Outubro");
                    break;
                case 11:
                    Console.WriteLine("O mês é Novembro");
                    break;
                case 12:
                    Console.WriteLine("O mês é Dezembro");
                    break;
                default:
                    Console.WriteLine("Mês inválido");
                    break;
            }

            Console.ReadLine();
        }
    }
}
