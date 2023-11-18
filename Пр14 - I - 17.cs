//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Security.Cryptography;
//using System.Linq;
//namespace a {
//    //структура точки
//    struct SPoint {
//        public int X;
//        public int Y;
//        public SPoint(int x, int y) {
//            this.X = x;
//            this.Y = y;
//        }
//    }
//    class Program {
//        //метод ввода данных
//        static public List<SPoint> Input() {
//            string path_in = "D:\\C#\\points.txt";
//            List<SPoint> points = new List<SPoint>(50); //список структур
//            using (StreamReader fin = new StreamReader(path_in)) {
//                while (!fin.EndOfStream) { //читаем до конца файла
//                    string line = fin.ReadLine(); //по строчкам, в одной строке 2 числа - координаты
//                    string[] coordinates = line.Split(' '); //разбиваем на 2 строки
//                    int first_coor = int.Parse(coordinates[0]); //каждую координату
//                    int second_coor = int.Parse(coordinates[1]); //делаем в int
//                    points.Add(new SPoint(first_coor, second_coor)); //добавляем в список
//                }
//                return points;
//            }
//        }


//        //метод расчета периметра треугольника
//        static double GetPerimeter(SPoint p1, SPoint p2, SPoint p3) {
//            double side1 = GetDistance(p1, p2);
//            double side2 = GetDistance(p1, p3);
//            double side3 = GetDistance(p2, p3);
//            if (side1 + side2 > side3 && side1 + side3 > side2 && side2 + side3 > side1) //проверка на существование треугольника
//                return side1 + side2 + side3;
//            else return double.MinValue;
//        }

//        //метод расчета расстояния между точками
//        static double GetDistance(SPoint p1, SPoint p2) {
//            int dx = Math.Abs(p1.X - p2.X);
//            int dy = Math.Abs(p1.Y - p2.Y);
//            return Math.Sqrt(dx * dx + dy * dy);
//        }


//        static void Main(string[] args) {
//            List<SPoint> points = Input(); //получаем все координаты списком
//            double max_perimetr = double.MinValue;
//            SPoint[] Triangle = new SPoint[3]; //массив с координатами трех точек, из которых получается треугольник с максимальным периметром
//            List<SPoint[]> MaxTriangleList = new List<SPoint[]>(); //список треугольников с макс периметром
//            for (int a = 0; a < points.Count - 2; a++) {
//                for (int b = a + 1; b < points.Count - 1; b++) {
//                    for (int c = b + 1; c < points.Count; c++) {
//                        double cur_perimetr = GetPerimeter(points[a], points[b], points[c]); //считаем периметр для каждой точки
//                        if (cur_perimetr > max_perimetr) {
//                            max_perimetr = cur_perimetr;
//                            Triangle[0] = points[a];
//                            Triangle[1] = points[b];
//                            Triangle[2] = points[c];
//                            MaxTriangleList.Clear(); //т.к. найден новый максимум - удаляем старые записи
//                            MaxTriangleList.Add(Triangle); //записываем новый трегольник в список
//                        }
//                        else if (cur_perimetr == max_perimetr) {
//                            SPoint[] xTriangle = new SPoint[3];
//                            xTriangle[0] = points[a];
//                            xTriangle[1] = points[b];
//                            xTriangle[2] = points[c];
//                            MaxTriangleList.Add(xTriangle);
//                        }
//                    }
//                }
//            }
//            string path_out = "D:\\C#\\points_out.txt";
//            using (StreamWriter fout = new StreamWriter(path_out, false)) {
//                fout.WriteLine("Максимальный периметр = " + max_perimetr);
//                fout.WriteLine("Координаты точек этого треугольника:\n" +
//                    "а = (" + Triangle[0].X + ", " + Triangle[0].Y + ")" +
//                    " b = (" + Triangle[1].X + ", " + Triangle[1].Y + ")" +
//                    " c = (" + Triangle[2].X + ", " + Triangle[2].Y + ")");
//                fout.WriteLine($"\nВсего треугольников с макс периметром {MaxTriangleList.Count()}");
//                foreach (SPoint[] i in MaxTriangleList) {
//                    foreach (SPoint p in i) {
//                        fout.WriteLine($"({p.X},{p.Y})");
//                    }
//                    fout.WriteLine();
//                }
//            }
//        }
//    }
//}
