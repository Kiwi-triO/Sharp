//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;

//namespace a {
//    class Program {
//        static void Main(string[] args) {
//            string path_in1 = "D:\\C#\\input1.txt";
//            string path_in2 = "D:\\C#\\input2.txt";
//            List<int> Numbers = new List<int>();
//            string FileContent1 = File.ReadAllText(path_in1);
//            string FileContent2 = File.ReadAllText(path_in2);
//            string[] numbers1 = FileContent1.Split(new[] { ' ', '\n', '\r' },
//            StringSplitOptions.RemoveEmptyEntries);
//            string[] numbers2 = FileContent2.Split(new[] { ' ', '\n', '\r' },
//            StringSplitOptions.RemoveEmptyEntries);
//            int length = numbers1.Length;
//            string path_out = "D:\\C#\\output.txt";
//            using (StreamWriter fout = new StreamWriter(path_out, false)) {
//                for (int i = 0; i < length; i++) {
//                    fout.WriteLine(int.Parse(numbers1[i]) + int.Parse(numbers2[i]));
//                }
//            }
//        }
//    }
//}
