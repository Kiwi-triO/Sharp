//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Security.Cryptography;
//using System.Linq;
//using System.Xml.Linq;

//namespace a {

//    struct Toys : IComparable<Toys> {
//        public string name;
//        public int min_age, max_age, cost;
//        public Toys(string name, int min_age, int max_age, int cost) {
//            this.name = name;
//            this.min_age = min_age;
//            this.max_age = max_age;
//            this.cost = cost;
//        }

//        public int CompareTo(Toys other) { //переопределяем метод для сортировки по возрастанию стоимости
//            if (this.cost == other.cost)
//                return 0;
//            else {
//                if (this.cost > other.cost)
//                    return 1;
//                else
//                    return -1;
//            }
//        }
//    }

//    class Program {

//        static public List<Toys> Input() {
//            string path = "D:\\C#\\input.txt";
//            List<Toys> toys_list = new List<Toys>(); //список структур
//            using (StreamReader fin = new StreamReader(path)) {
//                while (!fin.EndOfStream) { //читаем до конца файла
//                    string line = fin.ReadLine(); //по строчкам, в одной строке все данные об игрушке
//                    string[] toy = line.Split(' '); //разбиваем на строки
//                    string name = toy[0];
//                    int min_age = int.Parse(toy[1]), max_age = int.Parse(toy[2]), cost = int.Parse(toy[3]);
//                    toys_list.Add(new Toys(name, min_age, max_age, cost)); //добавляем в список
//                }
//            }
//            return toys_list;
//        }

//        static void Main(string[] args) {
//            using (StreamWriter fout = new StreamWriter("D:\\C#\\output.txt", false)) {
//                Console.WriteLine("Введите минимальный возраст: ");
//                int n = int.Parse(Console.ReadLine());
//                Console.WriteLine("Введите максимальный возраст: ");
//                int m = int.Parse(Console.ReadLine());
//                List<Toys> toys_list = Input();
//                fout.WriteLine("\nИсходный список всех игрушек:");
//                foreach (var item in toys_list) {
//                    fout.WriteLine($"Название: {item.name}, Цена: {item.cost}, Возраст: {item.min_age} - {item.max_age} лет");
//                }
//                fout.WriteLine("\nСписок по заданным параметрам возраста отсортированный по цене:");
//                toys_list.Sort();
//                foreach (var item in toys_list) {
//                    //максимальное из минимальных и минимальное из максимальных означают начало и конец мест пересечения двух диапазонов
//                    //если макс из мин больше чем мин из макс то диапазоны не пересекаются и такой диапазон нам не подходит
//                    if (Math.Max(n, item.min_age) > Math.Min(m, item.max_age)) continue;
//                    if (item.min_age < m) {
//                        fout.WriteLine($"Название: {item.name}, Цена: {item.cost}, Возраст: {item.min_age} - {item.max_age} лет");
//                    }
//                }
//                fout.WriteLine();
//            }
//        }
//    }
//}
