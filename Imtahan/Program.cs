using System;

namespace Imtahan
{
    internal class Program
    {
        static void shuffleArray(in Random rand, string[] array)
        {
            int n = array.Length;
            while (n > 1)
            {
                int k = rand.Next(n--);
                string temp = array[n];
                array[n] = array[k];
                array[k] = temp;
            }
        }

        static void Main(string[] args)
        {
            

            string[] questions = new string[]
            {
                "Azerbaycanin paytaxti haradir?",
                "Qan qohumu olan insanlarin birliyi?",
                "Islam dininin muqeddes kitabi hansidir?",
                "'Sen qan istedin, indi doyunca ich' ifadesi kime mexsusdu?",
                "Albaniya dovrune aid edilen Girdiman qalasi bu rayonumuzun erazisinde yerleshir?",
                "Azerbaycandaki dini inanclara daxil deyil?",
                "Qobustanda bu adda musiqi aleti var?",
                "Tomiris bu turksoylu tayfanin bashchisi idi?",
                "Qedim Albaniyanin paytaxti?",
                "Ateshperestler uchun bu muqeddesdir?"
            };

            string[] correctAnswers = new string[]
            {
                "Atropatena ile",
                "Qebile",
                "Qurani-Kerim",
                "Tomiris",
                "Ismayilli",
                "Buddizm",
                "Qavaldash",
                "Massaget",
                "Qebele",
                "Su"
            };

            string[,] answers = new string[10,3] {
                { "Kur chayi ile","Iberiya ile","Xezer denizi ile" },
                {"Dovlet","Ibtidai insan surusu","Tayfa" },
                {"Avesta","Tovrat","Incil" },
                {"Atropat","Cavanshir","Iranzu" },
                {"Qebele","Gence","Berde" },
                {"Ateshperstlik","Xristianliq","Budperestlik" },
                {"Naghara","Balaban","Kamancha" },
                {"Fars","Manna","Alban" },
                {"Berde","Izurtu","Qazaka" },
                {"Yemek","Dagh","Duman" },
            };

            // Append correct
            Random rand = new Random();
            for (int j = 0; j < 10; j++)
            {

                for (int i = 0; i < answers[j].Length; i++)
                {
                    Console.Write($"{answers[j][i]} ");
                }
                shuffleArray(rand, answers);
                for (int i = 0; i < answers.Length; i++)
                {
                    Console.Write($"{answers[i]} ");
                }
                Console.WriteLine();
            }
            






            //int select = 0;
            //dynamic button;
            //while (true)
            //{
            //    Console.Clear();

            //    //  Show menu
            //    int x = 50;
            //    int y = 15;
            //    Console.SetCursorPosition(x, y);
            //    Console.Write("Please choose operation from menu:");
            //    x += 5;
            //    for (int i = 0; i < operations.Count(); i++)
            //    {
            //        y++;
            //        Console.SetCursorPosition(x, y);
            //        if (select == i) { Console.BackgroundColor = ConsoleColor.DarkGreen; }
            //        Console.WriteLine(operations[i]);
            //        Console.BackgroundColor = ConsoleColor.Black;
            //    }

            //    Console.SetCursorPosition(0, 0);

            //    button = Console.ReadKey(true);
            //    //  To navigate through in menu
            //    switch (button.Key)
            //    {
            //        //  Move down
            //        case ConsoleKey.DownArrow:
            //            if (select <= 2 && select >= 0)
            //            {
            //                select++;
            //            }
            //            break;

            //        //  Move up
            //        case ConsoleKey.UpArrow:
            //            if (select <= 3 && select >= 1)
            //            {
            //                select--;
            //            }
            //            break;

            //        //  Select from menu
            //        case ConsoleKey.Enter:
            //            break;
            //        default:
            //            break;
            //    }
            //}
        }
    }
}