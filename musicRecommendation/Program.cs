using System;
public class Sorteio
{
    // Esta é a função de embaralhamento que você deve implementar no seu código:
    static Random _random = new Random();

    public static void Shuffle<T>(T[] array)
    {
        var random = _random;
        for (int i = array.Length; i > 1; i--)
        {
            int j = random.Next(i);
            T tmp = array[j];
            array[j] = array[i - 1];
            array[i - 1] = tmp;
        }
    }


    

    public static void Main()
    {

        Console.WriteLine("Este programa sugere musicas aleatorias com base no gênero que você escolheu.");
        Console.WriteLine("Os gêneros possiveis são: Rock");
        Console.WriteLine("Escolha seu gênero");

        string gen;

        gen = Console.ReadLine();

        if (gen == "rock" | gen == "Rock" | gen == "ROCK")
        {

            string[] array = {
         "Another One Bites the Dust - Queen",
         "When the levee breaks - Led Zeppelin",
         "Bohemian Rhapsody - Queen",
         "Another Brick In The Wall – Pink Floyd",
         "Strangelove - Depeche Mode",
         "Enjoy the silence - Depeche Mode",
         "Personal jesus - Depeche mode"
            };

            Shuffle(array);
            foreach (string value in array)
            {

                Console.WriteLine("Aqui está sua sugestão:");
                Console.WriteLine(value);

                break;

            }






        }

       
    }
}
 
 