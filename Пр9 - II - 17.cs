//using System;
//using System.Text;
//using System.Linq;
//using System.IO;

//class Program {
//    static void Main(string[] args) {
//        string path_in = "d:/C#/input.txt";
//        string path_out = "d:/C#/output.txt";
//        using (StreamReader fin = new StreamReader(path_in)) {
//            using (StreamWriter fout = new StreamWriter(path_out, false)) {
//                string inline = fin.ReadToEnd();
//                for (int i = inline.Length - 1; i >= 0; i--) {
//                    if (inline[i] == '\n') {
//                        continue;
//                    }
//                    fout.Write(inline[i]);
//                }
//            }
//        }
//    }
//}