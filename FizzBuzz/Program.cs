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
            for(int Currentnum = 1; Currentnum <= Invariant.Maxnum; Currentnum++)
            {
                // 現在値が3の倍数ならFizzを表示
                // それ以外の場合何も表示しない
                Console.Write(Currentnum % Invariant.Fizznum == 0 ? Invariant.Fizz : Invariant.Nothing);

                // 現在値が3の倍数なら改行しスキップ
                // ただし15の倍数なら次の処理へ
                if (Currentnum % Invariant.Fizznum == 0 && Currentnum % Invariant.Buzznum != 0)
                {
                    Console.WriteLine();
                    continue;
                }
                // 現在値が5の倍数ならBuzzを表示し改行
                // それ以外の場合現在値の数値を表示し改行
                Console.WriteLine(Currentnum % Invariant.Buzznum == 0 ? Invariant.Buzz : Currentnum.ToString());
            }
            // 画面閉じ防止
            Console.ReadLine();
        }
    }
}
