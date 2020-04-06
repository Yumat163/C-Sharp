using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Files_experiments
{
    class Program
    {
        static void Main(string[] args)
        {   static void TaskOne(StreamWriter writer)
            {
                int[] array = new int[501];
                for (int i = 0; i < array.Length; i++)
                {
                    writer.Write(i + " ");
                    
                }
                writer.Close();
            }
            static void TaskTwo(List <string> SA,StreamWriter writer)
            {
                
                for (int i = 0; i < SA.Count; i++)
                {
                    writer.Write(SA[i] + " ");

                }
                writer.Close();
            }
            static string TaskThree(StreamReader reader)
            {
                string str = reader.ReadToEnd();
                string[] stringArray = str.Split(' ');
                int counterMin = stringArray[0].Length;//?
                string theShortestWord = "";
                for (int i = 0;i < stringArray.Length; i++)
                {
                    if (counterMin >= stringArray[i].Length) // WHAT THE FUCK? Кароч смотри stringArray[0].Length = 3 тк первое слово red.тк counterMin = stringArray[0].Length => равен 3.Значит в if counterMin >= i0 значит код внутри if должен выполняться а выполняется else 
                    {
                        theShortestWord = stringArray[i];
                        counterMin = stringArray[i].Length;
                    }
                    else
                    {
                        theShortestWord = "go fuck yourself";
                    }
                }
                //return theShortestWord;
                reader.Close(); 
                return counterMin + " " + theShortestWord;

                //Console.WriteLine(reader.ReadToEnd());
                
            }

            //array = Convert.ToString();
            //string textFilePath = @"D:\!!! лабы\!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!LabsNew\myfile.txt";
            // string directoryPath = @"D:\!!! лабы\!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!LabsNew\NewFolder";
            //string textFilePathInNewDirectory = @"D:\!!! лабы\!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!LabsNew\NewFolder\myfile.txt";
            string toNumbers = @"D:\!!! лабы\!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!LabsNew\NEWFILE.txt";
            //StreamWriter writer = new StreamWriter(toNumbers);
            StreamReader reader = new StreamReader(toNumbers);
            //List<string> stringArray = new List<string> { "red", "green", "black", "white", "blue" };
            //TaskTwo(stringArray, writer);
            Console.WriteLine(reader.ReadToEnd());
            Console.Write(TaskThree(reader)); 

            

            //TaskOne(writer);

            //File.Create(textFilePath);

            //File.WriteAllText(textFilePath, "текст");
            //FileStream file = new FileStream(textFilePath, FileMode.Create);
            //StreamWriter writer = new StreamWriter(file);
            //writer.Write("Text my ");
            // writer.Close();
            //StreamReader reader = new StreamReader(file);
            //Console.WriteLine(reader.ReadToEnd());
            //reader.Close();
            //Directory.CreateDirectory(directoryPath);
            //StreamWriter writer = new StreamWriter(textFilePathInNewDirectory);
            // writer.Write("Text my ");
            // writer.Close();

            //writer.Write(array);
            // writer.Close();
            //Console.ReadLine();
        }
    }
}
