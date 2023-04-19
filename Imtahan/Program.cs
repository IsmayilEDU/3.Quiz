using System;

namespace Imtahan
{
    internal class Program
    {
        public static void shuffleArray(in Random rand,params string[] array)
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
            //  Score for player 
            byte score = 0;

            //  Questions
            string[] questions = new string[10]
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

            //  Correct answers
            string[] correctAnswers = new string[10]
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

            //  All Answers
            string[][] allAnswers = new string[10][] {
                new string[4]{ "Kur chayi ile","Iberiya ile","Xezer denizi ile","Atropatena ile" },
                new string[4]{"Dovlet","Ibtidai insan surusu","Tayfa","Qebile" },
                new string[4]{"Avesta","Tovrat","Incil","Qurani-Kerim" },
                new string[4]{"Atropat","Cavanshir","Iranzu","Tomiris" },
                new string[4]{"Qebele","Gence","Berde","Ismayilli" },
                new string[4]{"Ateshperstlik","Xristianliq","Budperestlik","Buddizm" },
                new string[4]{"Naghara","Balaban","Kamancha","Qavaldash" },
                new string[4]{"Fars","Manna","Alban","Massaget" },
                new string[4]{"Berde","Izurtu","Qazaka","Qebele" },
                new string[4]{"Yemek","Dagh","Duman","Su" },
            };

            //  Variants (for add to answers)
            string[] variants = new string[4] { "a)", "b)", "c)", "d)" };

            //  Shuffle and append variants to all answers
            Random rand = new Random();
            for (int i = 0; i < allAnswers.Length; i++)
            {
                //  Shuffle answers
                shuffleArray(rand, allAnswers[i]);
                for (int j = 0; j < allAnswers[i].Length; j++)
                {
                    //  Add variant to answer
                    string answerWithVariant = variants[j] + allAnswers[i][j];
                    allAnswers[i][j] = answerWithVariant;
                }
            }

            //  Play quiz
            for (int i = 0; i < allAnswers.Length; i++)
            {
                Console.Clear(); 
                Console.ForegroundColor= ConsoleColor.White;
                
                //  Show question and answers
                Console.WriteLine(questions[i]);
                for (int j = 0; j < allAnswers[i].Length; j++)
                {
                    Console.WriteLine(allAnswers[i][j]);
                }
                Console.WriteLine();
                Console.WriteLine($"Score: {score}");

                //  Select variant
                Console.WriteLine();
                Console.Write("Please choose variant: ");
                ConsoleKeyInfo chooseVariant= Console.ReadKey();
                char selectedVariant = chooseVariant.KeyChar;

                //  Find selected answer in answers
                string selectedAnswer = null;
                for (int j = 0; j < variants.Length; j++)
                {
                    if (selectedVariant == allAnswers[i][j][0])
                    {
                        selectedAnswer = allAnswers[i][j].Substring(2);
                        break;
                    }
                }

                //  Show correct or wrong answer
                Console.Clear();
                Console.SetCursorPosition(50,16);
                //  If player choose correct answer
                if (selectedAnswer == correctAnswers[i])
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Congralutions, you choose correct answer");
                    score += 10;
                }

                //  If player choose wrong answer
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Unfortunately, you choose wrong answer");
                    if (score>=10) score -= 10;
                }
                Thread.Sleep(2000);
            }













        }
    }
}