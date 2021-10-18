using System;

namespace exercicios_CeA_Fashion_Devs
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            double n1, n2, n3;
            double resultado;
            bool validacao = true;
            Program program = new Program();

            Console.WriteLine("### Exercícios C&A Fashion Devs ### \n");
            do
            {
                Console.WriteLine("Qual exercício deseja testar? \n");
                Console.WriteLine("(1) Programa 1");
                Console.WriteLine("(2) Programa 2");
                Console.WriteLine("(3) Programa 3");
                Console.WriteLine("(4) Programa 4");
                Console.WriteLine("(5) Sair \n\n"); 

                Console.WriteLine("Digite a sua opção: ");
                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Digite o peso em Kg: ");
                        n1 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Digite a altura em metros: ");
                        n2 = Convert.ToDouble(Console.ReadLine());

                        resultado = program.CalculoIMC(n1, n2);
                        
                        if(resultado < 20) 
                        { 
                           Console.WriteLine("\n Abaixo do peso.\n"); 
                        } 
                        else if((resultado >= 20) && (resultado < 25))
                        { 
                           Console.WriteLine("\n Peso Ideal.\n"); 
                        } 
                        else if (resultado >= 25) 
                        { 
                           Console.WriteLine("\n Acima do peso.\n"); 
                        }

                        break;
                    case 2:
                        Console.WriteLine("Digite o valor do seu salário: ");
                        n1 = Convert.ToDouble(Console.ReadLine());

                        resultado = program.CalculoSalario(n1);
                        Console.WriteLine("\n O seu salário equivale a {0:F2} salários mínimos.\n", resultado);

                        break;
                    case 3:
                        Console.WriteLine("Digite o valor do raio: ");
                        n1 = Convert.ToDouble(Console.ReadLine());

                        resultado = program.VolumeEsfera(n1);
                        Console.WriteLine("\n O volume da esfera é de {0:F2}.\n", resultado);

                        break;
                    case 4:
                        Console.WriteLine("Digite a primeira nota: ");
                        n1 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Digite a segunda nota: ");
                        n2 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Digite a terceira nota: ");
                        n3 = Convert.ToDouble(Console.ReadLine());

                        resultado = program.CalculoNota(n1, n2, n3);

                        if(resultado >= 7) 
                        { 
                           Console.WriteLine("\n Aprovado! Nota = {0:F2}\n", resultado); 
                        } else
                         { 
                            Console.WriteLine("\n Digite a nota do exame:\n"); 
                            double notaExame = Convert.ToDouble(Console.ReadLine());

                            double media = (resultado + notaExame) / 2;

                            if(media >= 5)
                            {
                                Console.WriteLine("\n Aprovado em exame! Nota = {0:F2}\n", media); 
                            }else
                                {
                                    Console.WriteLine("\n Reprovado. Nota = {0:F2}\n", media); 
                                }
                         } 

                        break;
   
                    case 5:
                        validacao = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }

                Console.WriteLine("Aperte ENTER para continuar");
                Console.ReadLine();
                Console.Clear();
            } while (validacao);
        }

        public double CalculoIMC(double peso, double altura)
        {
            double IMC = peso / (altura * altura);
            return IMC;
        }

        public double CalculoSalario(double salario)
        {
            double salarioMinimo = 1100.00;
            double QtdeSalariosMinimos = salario / salarioMinimo;
            return QtdeSalariosMinimos;
        }

        public double VolumeEsfera(double raio)
        {
            double pi = 3.14;
            double volume = 4/3 * (pi * (raio*raio*raio));
            return volume;
        }
        public double CalculoNota(double n1, double n2, double n3)
        {
            double media = (n1 + n2 + n3) / 3;
            return media;
        }

    }
}
