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

        public const string Nothing   = "";      // 何もない字
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
                // 現在値が1でなければ改行
                if (currentnum != 1)
                    Console.WriteLine(Invariant.Nothing);

                // 現在値が3の倍数ならFizzを表示
                if (currentnum % Invariant.Fizznum == 0)
                    Console.Write(Invariant.Fizz);

                // 現在値が3の倍数 又 5倍数ではない場合スキップ
                if (currentnum % Invariant.Fizznum == 0 && currentnum % Invariant.Buzznum != 0)
                    continue;

                // 現在値が5の倍数ならBuzzを表示
                // それ以外の場合現在値の数値を表示
                Console.Write(currentnum % Invariant.Buzznum == 0 ? Invariant.Buzz : currentnum.ToString());
            }
            // 画面閉じ防止
            Console.ReadLine();
        }
    }
}
