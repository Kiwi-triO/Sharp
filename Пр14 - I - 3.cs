using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Linq;

//3. Найти точку которая наименее удалена от начала координат
namespace a {
    //структура точки
    struct SPoint {
        public int x;
        public int y;
        public SPoint(int x, int y) {
            this.x = x;
            this.y = y;
        }
    }
    class Program {
        //метод ввода данных
        static public List<SPoint> Input() {
            string path_in = "D:\\C#\\points.txt";
            List<SPoint> points = new List<SPoint>(50); //список структур
            using (StreamReader fin = new StreamReader(path_in)) {
                while (!fin.EndOfStream) { //читаем до конца файла
                    string[] coordinates = fin.ReadLine().Split(' '); //разбиваем на 2 строки
                    int first_coor = int.Parse(coordinates[0]); //каждую координату
                    int second_coor = int.Parse(coordinates[1]); //в int
                    points.Add(new SPoint(first_coor, second_coor)); //добавляем в список
                }
                return points;
            }
        }

        //метод расчета расстояния от начала координат до точки
        static double GetDistance(SPoint p) {
            return Math.Sqrt(p.x * p.x + p.y * p.y);
        }


        static void Main(string[] args) {
            List<SPoint> points = Input(); //получаем все точки списком
            double min_distance = double.MaxValue;
            List<SPoint> AllowPoints = new List<SPoint>(50); //список подходящих точек
            foreach (SPoint point in points) {
                double current_distance = GetDistance(point);
                if (current_distance < min_distance) {
                    min_distance = current_distance;
                    AllowPoints.Clear(); //если нашлась точка ближе очищаем список
                    AllowPoints.Add(point); //и добавляем ее
                }
                else if (current_distance == min_distance) {
                    AllowPoints.Add(point);
                }
            }


            string path_out = "D:\\C#\\points_out.txt";
            using (StreamWriter fout = new StreamWriter(path_out, false)) {
                fout.WriteLine("Точки, наименее удаленные от начала координат: ");
                foreach (SPoint p in AllowPoints) {
                    fout.WriteLine("(" + p.x + ", " + p.y + ")");
                }
            }
        }
    }
}