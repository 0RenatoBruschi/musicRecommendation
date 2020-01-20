using System;

namespace musicRecommendatioN
{


    class Program
    {
        static void Main(string[] args)
        {


            // Array Rock e Array Rock Link (array com os links d
            string[] rock = new string[]
            { "Another One Bites the Dust - Queen",
         "When the levee breaks - Led Zeppelin",
         "Bohemian Rhapsody - Queen",
         "Another Brick In The Wall – Pink Floyd",
         "Strangelove - Depeche Mode",
         "Enjoy the silence - Depeche Mode",
         "Personal jesus - Depeche mode"
             };
            string[] rockL = new string[]
             { "Another One Bites the Dust - Queen",
         "When the levee breaks - Led Zeppelin",
         "Bohemian Rhapsody - Queen",
         "Another Brick In The Wall – Pink Floyd",
         "Strangelove - Depeche Mode",
         "Enjoy the silence - Depeche Mode",
         "Personal jesus - Depeche mode"
             };


            // Array Pop
            string[] pop = new string[]
            { "Don't Stop me now do grupo Queen",
            "Enjoy the Silence do grupo Depeche Mode",
        "Starway to Heaven do grupo Nirvana",
        "Break up with your girlfriend, I'm bored da cantora Ariana Grande",
        "7 Rings da cantora Ariana Grande"
             };
            string[] popL = new string[]
            { "Don't Stop me now do grupo Queen",
            "Enjoy the Silence do grupo Depeche Mode",
        "Starway to Heaven do grupo Nirvana",
        "Break up with your girlfriend, I'm bored da cantora Ariana Grande",
        "7 Rings da cantora Ariana Grande"
             };


            Random rnd = new Random(DateTime.Now.Millisecond);

            // Interface do Usuário 

            Console.WriteLine("Este programa recomenda musicas aleatórias baseado no gênero que você escolher");
            Console.WriteLine("Os gêneros disponíveis são: Rock, Pop");
            Console.WriteLine("Selecione seu gênero...");

            string gen;
            bool nDone = false;

            while (!nDone)
            {
                gen = Console.ReadLine();


                if (gen == "Rock")
                {

                    Console.WriteLine("Recomendo a música " + rock[rnd.Next(4)]);
                    Console.WriteLine("Deixo aqui o link para a música: " + rockL[rnd.Next()]);
                    nDone = true;
                }
                else if (gen == "Pop")
                {
                    Console.WriteLine("Recomendo a música " + pop[rnd.Next(4)]);
                    Console.WriteLine("Deixo aqui o link para a música: " + popL[rnd.Next()]);
                    nDone = true;
                }
                else
                {
                    Console.WriteLine("Parece que o gênero " + gen + " não está disponível no momento, desculpe...");
                    Console.WriteLine("Por favor, digite um gênero entre: Rock, Pop");

                }

            }


        }
    }
}
