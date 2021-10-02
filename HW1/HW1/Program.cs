using System;
using System.Collections;
using System.Linq;

namespace HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            string expression1 = Console.ReadLine();

            int expression = Int32.Parse(expression1);
            switch (expression) {
                case (1):
                    Console.WriteLine("Pozitif bir sayı girin: ");

                    string num = Console.ReadLine();
                    int num2 = Int32.Parse(num);

                    for (int i = 0; i < num2; i++)
                    {
                        string temp = (num2 - i).ToString();

                        Console.WriteLine(temp + " sayı girin!");

                        string num3 = Console.ReadLine();

                        int temp1 = Int32.Parse(num3);

                        if (temp1 % 2 == 0)
                        {
                            Console.WriteLine(temp1 + " çift bir sayı.");

                        }
                        else
                        {
                            Console.WriteLine(temp1 + " bir çift sayı değil.");
                        }
                    }
                    break;
                case (2):

                    Console.WriteLine("Pozitif bir sayı girin: ");
                    string n = Console.ReadLine();
                    int guess1 = Int32.Parse(n);

                    Console.WriteLine("Pozitif bir sayı daha girin:");
                    string m = Console.ReadLine();
                    int guess2 = Int32.Parse(m);

                    for (int i = 0; i < guess1; i++)
                    {
                        Console.WriteLine((guess1 - i) + " tane sayı girin.");
                        string yeni = Console.ReadLine();

                        int yeni1 = Int32.Parse(yeni);

                        if(yeni1 % guess2 == 0)
                        {
                            Console.WriteLine(yeni + ", " + m + "'e bölünüyor ya da eşit.");
                        }
                    }

                    break;

                case (3):

                    ArrayList kelimeler = new ArrayList();
                    Console.WriteLine("Pozitif bir sayı girin: ");

                    string input1 = Console.ReadLine();

                    int inp1 = Int32.Parse(input1);

                    for(int i = 0; i < inp1; i++)
                    {
                        Console.WriteLine((inp1 - i) + " adet kelime girin.");

                        string inp = Console.ReadLine();
                        kelimeler.Add(inp);

                    }
                    for(int i = kelimeler.Count; i > 0; i--)
                    {
                        Console.WriteLine(kelimeler[i-1]);
                    }

                    break;
                case (4):

                    Console.WriteLine("Bir cümle yazın: ");
                    string sentence = Console.ReadLine();

                   

                    foreach (var word in sentence.TrimEnd('.').Split('.'))
                        Console.WriteLine("Cümledeki kelime sayısı " + word.Trim().Split(' ').Count());
                    Console.WriteLine("Cümledeki harf sayısı : " + sentence.Replace(" ","").Length);
                    break;
            }
            
        }
    }
}
