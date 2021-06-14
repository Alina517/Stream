using System;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

namespace Stream
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader file = new StreamReader("text.txt");//открываем файл для чтения
            string readText = file.ReadToEnd();//считываем все данные из файла и записываем в readText
            file.Close();//закрывем файл

            string[] newText = Regex.Split(readText, "\n");//делим считанные данные на строки
            for(int i = 0; i < newText.Length; i++)//проходим по массыву данных
            {
                for(int j = 1; j < newText[i].Length; j++)
                {                  
                    newText[i] = newText[i].Remove(j, 1);  // удаляем четные элементы каждой строки                                
                }
            }
            StreamWriter fileout = new StreamWriter("text1.txt", false, System.Text.Encoding.Default);//открываем файл для записи
            foreach(string b in newText)
            {
                fileout.WriteLine(b);// записывем полученные данные в файл
            }
            fileout.Close();// закрываем файл
            Console.WriteLine("Данные записаны в файл text1.txt");//вывод сообщения в консоль
        }
    }
}
