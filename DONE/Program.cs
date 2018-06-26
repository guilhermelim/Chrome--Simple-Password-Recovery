using System;

namespace SimpleChromepwrec
{
    /*
     <~> Módulo simples que mostra senhas e cookies armazenados localmente no Google Chrome.
     <~> Não há DDLs externos ou outras dependências necessárias. SQLiteHandler e outras classes já estão aqui.
    */
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Simple Chrome Password Recovery";
            WriteLineColor(ConsoleColor.Red, "\t Simple Chrome Password Recovery\n");

            foreach (var chrome in Chrome.GetSavedPasswords())
            {
                WriteColor(ConsoleColor.White, "SITE:     ");
                WriteLineColor(ConsoleColor.White, chrome.URL);

                WriteColor(ConsoleColor.White, "USER:     ");
                WriteLineColor(ConsoleColor.Blue, chrome.Username);

                WriteColor(ConsoleColor.White, "PASSWORD: ");
                WriteLineColor(ConsoleColor.Red, chrome.Password);

                Console.WriteLine(Environment.NewLine);
            }

            WriteLineColor(ConsoleColor.Red, "\t Todas as senhas encontradas foram recuperadas.");
            Console.ReadKey();
        }

        static void WriteColor(ConsoleColor _foregroundColor, String _text)
        {
            Console.ForegroundColor = _foregroundColor;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(_text);
            Console.ResetColor();
        }

        static void WriteLineColor(ConsoleColor _foregroundColor, String _text)
        {
            Console.ForegroundColor = _foregroundColor;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine(_text);
            Console.ResetColor();
        }
    }


}
