using System;

namespace Tutorial4
{
    class Program
    {
        static void Main(string[] args)
        {
            //配列のメリット
            //変数の場合
            int a, b, c, d, e;
            Console.Write("数値を5回入力して下さい");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());
            e = int.Parse(Console.ReadLine());

            //値の計算
            int square_sum = a * a + b * b + c * c + d * d + e * e;

            //値の出力
            Console.WriteLine($"二乗和は{square_sum}です"+ "\n");

            //繰り返しの記述が増えるため修正しにくい
            //配列
            //宣言:型名[] 変数名;
            //初期化: 配列変数名 = new 型名[配列の長さ];

            int[] numbers = new int[5];
            Console.Write("数値を5回入力して下さい");
            //値の入力
            for (int i = 0; i < numbers.Length; ++i)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            //for each element in an array ～ 配列の中のそれぞれの要素に対して処理を行う
            //foreach文
            /*
             foreach(変数宣言 in 配列名){
                配列の中身を変数に格納して配列の中身をすべて取り出すまで実行する処理
            }
             */

            int square_sum2 = 0;
            foreach(int number in numbers)
            {
                square_sum2 += number*number;
            }

            Console.WriteLine($"二乗和は{square_sum2}です");

            //フィボナッチ数列の20項目までを求める
            int[] sequences = new int[20];

            //最初の2項を入力
            Console.Write("pea1=");
            sequences[0] = int.Parse(Console.ReadLine());
            Console.Write("pea2=");
            sequences[1] = int.Parse(Console.ReadLine());

            //漸化式を使って20項目までを計算
            for (int i = 2; i < sequences.Length; ++i)
            {
                //数列の第二項と第一項の和を第三項に代入する
                sequences[i] = sequences[i-1] + sequences[i-2];
                //各項を1つ右にずらす⇒繰り返す
            }

            //結果の出力
            Console.Write("{");
            foreach(int sequence in sequences)
            {
                Console.WriteLine(sequence + ", ");

                if(sequences.Length % 10 == 0)
                {
                    Console.WriteLine("\n");
                }
            }


        }
    }
}
