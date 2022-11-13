using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Текстовый_конвертер
{
    public class Base
    {
        public void Bas()
        {
            one();
        }
        private void one()
        {
            Console.WriteLine("Введите путь до файла (вмести с названием) который хотите открыть");
            Console.WriteLine("-----------------------------------------------------------------");

            string file = Console.ReadLine();
            string myText = File.ReadAllText(file);
            Console.WriteLine(myText);
            MyFile();
        }

        private void MyFile()
        {
            Console.WriteLine("Введите путь до файла (вмести с названием) который хотите открыть");
            Console.WriteLine("-----------------------------------------------------------------");

            while (true)
            {
                string file1 = "C:\\Users\\KS\\OneDrive\\Рабочий стол\\MyFile.txt";
                string file2 = "C:\\Users\\KS\\OneDrive\\Рабочий стол\\MyFile.json";
                string file3 = "C:\\Users\\KS\\OneDrive\\Рабочий стол\\MyFile.xml";
                Console.WriteLine("Для выхода из программы нажмите на Escape. Для сохранения файла на F1");
                Console.WriteLine("-----------------------------------------------------------------");
                string jsoon = Console.ReadLine();
                if (jsoon == file2)
                {
                    Console.Clear();
                    Deserial();
                    VVOD();
                }
                else if (jsoon == file3)
                {
                    Console.Clear();
                    txt txt;
                    XmlSerializer xml = new XmlSerializer(typeof(List<txt>));
                    using (FileStream fs = new FileStream("C:\\Users\\KS\\OneDrive\\Рабочий стол\\MyFile.xml", FileMode.Open))
                    {
                        VVOD();
                    }

                }
                else if (jsoon == file1)
                {
                    Console.Clear();
                    string myText1 = File.ReadAllText(file1);
                    Console.WriteLine(myText1);
                    
                }


                txt onefigur = new txt();
                onefigur.figure = "Прямоугольник";
                onefigur.length = 15;
                onefigur.width = 10;

                txt twofigur = new txt();
                twofigur.figure = "Квадрат";
                twofigur.length = 20;
                twofigur.width = 20;

                txt threefigur = new txt();
                threefigur.figure = "Прямоугольник";
                threefigur.length = 45;
                threefigur.width = 67;

                List<txt> list = new List<txt>();
                list.Add(onefigur);
                list.Add(twofigur);
                list.Add(threefigur);

                XmlSerializer xml1 = new XmlSerializer(typeof(List<txt>));
                using (FileStream fs = new FileStream("C:\\Users\\KS\\OneDrive\\Рабочий стол\\MyFile.xml", FileMode.OpenOrCreate))
                {

                    xml1.Serialize(fs, list);
                }

                string json = JsonConvert.SerializeObject(list);
                File.WriteAllText("C:\\Users\\KS\\OneDrive\\Рабочий стол\\MyFile.json", json);
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.F1)
                {
                    MyFile();
                }
                if (key.Key == ConsoleKey.Escape)
                {
                    break;
                }
            }
            
        }
        private void Deserial()
        {
            string text = File.ReadAllText("C:\\Users\\KS\\OneDrive\\Рабочий стол\\MyFile.json");
            List<txt> result = JsonConvert.DeserializeObject<List<txt>>(text);
            Console.WriteLine(result); 
        }
        private void VVOD()
        {
            Console.Clear();
            string figure = "Прямоугольник";
            int length = 15;
            int width = 10;
            string figure1 = "Квадрат";
            int length1 = 20;
            int width1 = 20;
            string figure2 = "Прямоугольник";
            int length2 = 45;
            int width2 = 67;
            Console.WriteLine(figure);
            Console.WriteLine(length);
            Console.WriteLine(width);
            Console.WriteLine(figure1);
            Console.WriteLine(length1);
            Console.WriteLine(width1);
            Console.WriteLine(figure2);
            Console.WriteLine(length2);
            Console.WriteLine(width2);
        }
    }
}
