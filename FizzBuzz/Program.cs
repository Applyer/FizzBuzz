using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    // 定数クラス
    static class Invariant
    {
        public const int Fizznum      = 3;       // Fizzの数値
        public const int Buzznum      = 5;       // Buzzの数値
        public const int Maxnum       = 100;     // 最高値

        public const string Fizz      = "Fizz";  // Fizzの文字
        public const string Buzz      = "Buzz";  // Buzzの文字
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 現在値が最高値になるまでループ
            for(int currentnum = 1; currentnum <= Invariant.Maxnum; currentnum++)
            {
                // 現在値を3で割る
                var isFizz = currentnum % Invariant.Fizznum == 0;

                // 現在値を5で割る
                var isBuzz = currentnum % Invariant.Buzznum == 0;

                // 3の倍数ならFizzを表示
                if (isFizz) Console.Write(Invariant.Fizz);

                // 5の倍数ならBuzzを表示
                if (isBuzz) Console.Write(Invariant.Buzz);

                // どちらでもない場合現在値を表示
                if (!isFizz && !isBuzz) Console.Write(currentnum);

                // 改行
                Console.WriteLine();
            }
            // 画面閉じ防止
            Console.ReadLine();
        }
    }
}
