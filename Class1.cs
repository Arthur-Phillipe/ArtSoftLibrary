using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtSofLibrary
{
    namespace Talk
    {
        /// <summary>
        /// Biblioteca para "conversar com usuário" através do Console;
        /// extendendo ós métodos do tipo string
        /// </summary>
        public static class Talk
        {
            /// <summary>
            /// Imprime no Console a própria string
            /// </summary>
            /// <param name="fala"></param>
            public static void Say(this string fala)
            {
                Console.Write(fala);
            }
            /// <summary>
            /// Imprime no Console a própria string, lê e devolve a string digitada;
            /// </summary>
            /// <param name="pergunta"></param>
            /// <returns></returns>
            public static string Ask(this string pergunta)
            {
                pergunta.Say();
                return Console.ReadLine();
            }
            /// <summary>
            /// Imprime no Console a própria string, lê e devolve um inteiro digitado;
            /// </summary>
            /// <param name="pergunta"></param>
            /// <returns></returns>
            public static int AskInt(this string pergunta)
            {
                return int.Parse(pergunta.Ask());
            }
            /// <summary>
            /// Imprime no Console a própria string, lê e devolve um double digitado;
            /// </summary>
            /// <param name="pergunta"></param>
            /// <returns></returns>
            public static double AskDouble(this string pergunta)
            {
                return double.Parse(pergunta.Ask());
            }
            /// <summary>
            /// Imprime no Console a própria string, lê e devolve um float digitado;
            /// </summary>
            /// <param name="pergunta"></param>
            /// <returns></returns>
            public static float AskFloat(this string pergunta)
            {
                return float.Parse(pergunta.Ask());
            }
            public static DateTime AskDate(this string pergunta)
            {
                return DateTime.Parse(pergunta.Ask());
            }
        }

        public class TalkFunctions
        {
            /// <summary>
            /// Imprime no Console a string;
            /// </summary>
            /// <param name="fala"></param>
            public static void Say(string fala)
            {
                Console.Write(fala);
            }
            /// <summary>
            /// Imprime no Console a string, lê e devolve a string digitada;
            /// </summary>
            /// <param name="pergunta"></param>
            /// <returns></returns>
            public static string Ask(string pergunta)
            {
                Say(pergunta);
                return Console.ReadLine();
            }
            /// <summary>
            /// Imprime no Console a string, lê e devolve o inteiro digitado;
            /// </summary>
            /// <param name="pergunta"></param>
            /// <returns></returns>
            public static int AskInt(string pergunta)
            {
                return int.Parse(Ask(pergunta));
            }
            /// <summary>
            /// Imprime no Console a string, lê e devolve o double digitado;
            /// </summary>
            /// <param name="pergunta"></param>
            /// <returns></returns>
            public static double AskDouble(string pergunta)
            {
                return double.Parse(Ask(pergunta));
            }
            /// <summary>
            /// Imprime no Console a string, lê e devolve o float digitado;
            /// </summary>
            /// <param name="pergunta"></param>
            /// <returns></returns>
            public static float AskFloat(string pergunta)
            {
                return float.Parse(Ask(pergunta));
            }
            public static DateTime AskDate(string pergunta)
            {
                return DateTime.Parse(Ask(pergunta));
            }
        }
    } // Fim namespace Talk

} // Fim namespace ArtSoftLibrary
