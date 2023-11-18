using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace a {
    class Program {
        static void Main(string[] args) {
            string path_in = "D:\\C#\\input.txt";
            List<int> Numbers = new List<int>();
            string FileContent = File.ReadAllText(path_in);
            string[] string_numbers = FileContent.Split(new[] { ' ', '\n', '\r', '\t' },
            StringSplitOptions.RemoveEmptyEntries);
            foreach (string number in string_numbers) {
                Numbers.Add(int.Parse(number));
            }
            /*вариант 1*/
            //var SortedNumbers = Numbers.Where(x => x >= 10 && x <= 99).OrderByDescending(x => x).Select(x => -x).ToList();
            //string path_out = "D:\\C#\\output.txt";
            //using (StreamWriter fout = new StreamWriter(path_out, false)) {
            //    foreach (var n in SortedNumbers)
            //        fout.Write($"{n} ");
            //}
            /*вариант 2*/
            var SortedNumbers = Numbers.Where(x => x >= 10 && x <= 99).Select(x => -x).ToList();
            string path_out = "D:\\C#\\output.txt";
            using (StreamWriter fout = new StreamWriter(path_out, false)) {
                foreach (var n in SortedNumbers.OrderBy(x => x))
                    fout.Write($"{n} ");
            }
        }
    }
}

//Аннотация:
//Для хранения чисел использую список т.к. заранее неизвестно кол-во элементов,
//а в списке добавление элемента в конец занимает О(1). Остальные операции с коллекцией роли не играют.
//Т.к. мы не знаем как записаны значения в файле, в строку, или в столбец, или и так и так, я разбил весь текст
//на строки по пробелам, знакам переноса строки и возврата каретки.

//Данные для примера
//99 - 88 77 - 66 55
//43          28
//9




//0
