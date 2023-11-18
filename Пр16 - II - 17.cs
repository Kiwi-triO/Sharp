using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace a {
    class Student {
        public string NAME, FACULTY;
        public int COURSE, GROUP, EX1, EX2, EX3;
        public Student(string name, string faculty, int course, int group,
            int ex1, int ex2, int ex3) {
            NAME = name; FACULTY = faculty;
            COURSE = course; GROUP = group;
            EX1 = ex1; EX2 = ex2; EX3 = ex3;
        }
    }
    class Program {
        static void Main() {
            string path_in = "D:\\C#\\input.txt";
            List<Student> Students = new List<Student>();
            using (StreamReader fin = new StreamReader(path_in, Encoding.Default)) {
                while (!fin.EndOfStream) {
                    string line = fin.ReadLine();
                    string[] stud = line.Split(' ');
                    Students.Add(new Student(stud[0], stud[1], int.Parse(stud[2]), int.Parse(stud[3]), int.Parse(stud[4]), int.Parse(stud[5]), int.Parse(stud[6])));
                }
            }

            //var sortedStudents = from n in Students
            //                     where (n.EX1 == 2) || (n.EX2 == 2) || (n.EX3 == 2)
            //                     orderby n.NAME ascending
            //                     select n;

            var sortedStudents = Students.Where(x => (x.EX1 == 2) || (x.EX2 == 2) || (x.EX3 == 2)).OrderBy(x => x.NAME).ToList();

            string path_out = "D:\\C#\\output.txt";
            using (StreamWriter fout = new StreamWriter(path_out, false)) {
                fout.WriteLine("{0,-15} {1,-15} {2,-10} {3,-10} {4,-10}",
                    "Фамилия", "Факультет", "Курс", "Группа", "Оценки\n");
                foreach (var x in sortedStudents)
                    fout.WriteLine("{0,-15} {1,-15} {2,-10} {3,-10} {4,-10}",
                        x.NAME, x.FACULTY, x.COURSE, x.GROUP, string.Join(" ", x.EX1, x.EX2, x.EX3));
            }
        }
    }
}

//Данные для примера
//Грустный смайл 2 2 1 3 3
//Веселящий газ 2 1 3 3 3
//Смайл фейс 4 5 5 2 2
//Дурной тон 1 1 2 2 2
//Дядя федя 1 2 4 4 3
//Дядя степа 3 2 5 5 2
//Синий трактор 2 3 5 4 3
//Раскладной диван 1 5 2 4 5
