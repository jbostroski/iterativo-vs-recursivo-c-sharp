using System;
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Utilizar algoritmo iterativo ou recursivo? (I = iterativo | R = recursivo)");
        string escolha = Console.ReadLine();

        if (escolha == "I" || escolha == "i")
        {
            //Tabuada iterativa:
            Console.WriteLine("Digite qual tabuada deseja calcular:\n");
            int EntradaUm = int.Parse(Console.ReadLine());
            static void TabuadaIterativa(int entrada)
            {
                int multiplicador = 0;
                //Fator de parada:
                while (multiplicador <= 10)
                {
                    int resultado = entrada * multiplicador;
                    Console.WriteLine("{0} X {1} = {2}", entrada, multiplicador, resultado);
                    //Iteração:
                    multiplicador++;
                }
            }

            TabuadaIterativa(EntradaUm);
            //Fim tabuada Iterativa
        }
        else if (escolha == "R" || escolha == "r")
        {
            //Tabuada Recursiva:
            Console.WriteLine("Digite qual tabuada deseja calcular:\n");
            int EntradaDois = int.Parse(Console.ReadLine());
            int Multiplicador = 0;
            TabuadaRecursiva(EntradaDois, Multiplicador);

            static void TabuadaRecursiva(int entrada, int multiplicador)
            {   
                //Fator de parada:
                if (multiplicador == 11)
                    return;
                else
                    Console.WriteLine("{0} X {1} = {2}", entrada, multiplicador, entrada*multiplicador);
                    //Chamada para a própria função:
                    TabuadaRecursiva(entrada, multiplicador + 1);                   
                return;
                //Fim tabuada recursiva
            }

        }
        else Console.WriteLine("Inválido");
    }
}