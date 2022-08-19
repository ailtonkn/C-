using System;

//implemente uma função calcula média (double[] numeros)

namespace projeto03
{
    class Program
    {
        static double calculaMedia(double[] numeros)
        {
            

             double soma = 0;

             for (int i = 0; i < numeros.length; i++)
             {
                soma += numeros[i];
             }
             
            double media = soma / numeros.length;


            return media;
        }

        static double calculaMediana(double[] numeros)
        {
            
            Array.Sort(numeros);
            if ((numeros.length % 2) == 0)
            {
                return (numeros[meio] + numeros[meio - 1]) / 2;
            }
            else
            {
                int meio = numeros.length / 2;

                return numeros[meio];
            }
        }

        static double calculaModa(double[] numeros)
        {
            double reoeticoes = new double[numeros.length]
            for (int i = 0; i < numeros.length; i++)
            {
                double atual = numeros[i];
                int cont = 0;

                for (int j = 0; j < numeros.length; j++)
                {
                    if (numeros[j] == atual)
                    {
                        cont++;
                    }
                }
                reoeticoes[i] = cont;
                
            }

            int maior =  0;
            for (int i = 1; i < repeticoes.length; i++)
            {
                if (repeticoes[i] > repeticoes[i - 1])
                {
                    maior = i;
                }
            }
            return numeros[maior];
        }



        static void Main(string[] args)
        {
          
            
          double[] numeros = {5.5, 6.5, 9.6};
          double media = calculaMedia(numeros);
          double mediana = calculaMediana(numeros);
          double mediana = calculaModa(numeros);
          Console.WriteLine("Média: " + media);
          Console.WriteLine("Mediana: " + mediana);
          Console.WriteLine("Moda: " + moda);


            


        }
    }
}
