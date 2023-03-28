namespace Forca.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string[] palavras = { "ABACATE", "ABACAXI","ACEROLA", "AÇAÍ", "ARAÇA", "ABACATE", "BACABA", "BACURI", 
                "BANANA", "CAJÁ",
                "CAJÚ", "CARAMBOLA", "CUPUAÇU", "GRAVIOLA", "GOIABA", "JABUTICABA", "JENIPAPO" ,"MAÇÃ", 
                "MANGABA", "MANGA", "MARACUJÁ", "MURICI", "PEQUI",
                "PITANGA", "PITAYA", "SAPOTI", "TANGERINA", "UMBU", "UVA", "UVAIA"};

            Random random = new Random();
            string palavraAleatoria = palavras[random.Next(palavras.Length)].ToLower();
            


            string[] chute = new string[palavraAleatoria.Length];
            int erro = 5;
            string guardaLetra = null;
            
            while(erro != 0)
            {
                Console.WriteLine("Digite uma letra: ");
                char letra = char.Parse(Console.ReadLine());
                
                
                    for (int j = 0; j < palavraAleatoria.Length; j++)
                    {
                        if (palavraAleatoria[j].ToString() == letra.ToString())
                        {
                            chute[j] = letra.ToString();
                          
                        }
                        
                        else if (chute[j] is null)
                        {
                            chute[j] = "_";
                        guardaLetra = chute[j];

                        }

                        
                    }
                    if (guardaLetra != letra.ToString())
                    {
                        erro--;
                    }
                foreach (string item in chute)
                {
                    Console.Write(item);
                }
                Console.WriteLine();
            }
        }
    }
}