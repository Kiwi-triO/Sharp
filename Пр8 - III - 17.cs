//using System;
//using System.Text;
//using System.Linq;

//class Program {
//    static void Main(string[] args) {

//        StringBuilder text = new StringBuilder(Console.ReadLine(), 200);
//        //1 вариант удаления знаков пунктуации и записи слов в массив
//        //for (int i = 0; i < text.Length;) {
//        //    if (char.IsPunctuation(text[i])) {
//        //        text.Remove(i, 1);
//        //    }
//        //    else ++i;
//        //}

//        //string[] words = text.ToString().Split(' ');

//        //2 вариант удаления знаков пунктуации в купе с разбиением на слова
//        string[] words = text.ToString().Split(new[] { ' ', '.', ',', '!', '?' },
//            StringSplitOptions.RemoveEmptyEntries);
//        int k = 0;
//        foreach (string word in words) {
//            foreach (string word2 in words) {
//                if (word == word2)
//                    k++;
//            }
//            if (k == 1) {
//                Console.WriteLine(word);
//            }
//            k = 0;
//        }
//    }
//}