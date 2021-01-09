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
                Console.WriteLine($"{i+1}番目の数字");
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
                Console.Write(sequence + ", ");

                if(sequences.Length % 10 == 0)
                {
                    Console.WriteLine();
                }
            }

            //初期化子
            //型名[] 変数名 = new 型名[] {値1,値2,・・・}
            //省略形 型名[] 変数名 = {値1,値2,・・・}
            //verで暗黙的型付け配列を宣言できる
            //ver 変数名 = new[] {値1,値2,・・・}

            //範囲アクセス(Ver8.0)
            var nums = new[] { 1, 2, 3, 4, 5 };

            //前後1要素ずつ削ったもの
            /*配列変数名[i..^j]
             i～先頭からi番目
            ^j～最後からj番目
            =>i番目からj番目までの要素を取り出すかつi番目とj番目の要素は含まない
             */

            var middle = nums[1..^1];

            foreach (var x in middle)
            {
                Console.Write(x);
            }
            Console.WriteLine();


            //多次元配列の宣言
            //型名[,] 変数名; //二次元配列
            //型名[,,] 変数名; //三次元配列
            //初期化
            /*型名[,] 変数名 = new 型名[,]{
                {値1_1,値1_2,値1_3,・・・},
                {値2_1,値2_2,値2_3,・・・},
                ・・・
            ];
             */

            //行列の掛け算
            //3行2列
            int[,] row_colum1 =
            {
                {1,3 },
                {2,4 },
                {2,5 }
            };
            int[,] row_colum2 =
            {
                {1,3,5 },
                {2,4,6 }
            };
            int[,] row_colum3 = new int[3, 3];

            //配列名.GetLength(0) = 配列の行数
            //配列名.GetLength(1) = 配列の列数
            for (int i = 0; i < row_colum1.GetLength(0); ++i)
            {
                for (int j = 0; j < row_colum2.GetLength(1); ++j)
                {
                    row_colum3[i, j] = 0;
                    for (int k = 0; k < row_colum1.GetLength(1); ++k)
                    {
                        row_colum3[i, j] += row_colum1[i, k] * row_colum2[k, j];
                    }
                }
            }

            for (int i = 0; i < row_colum3.GetLength(0); ++i)
            {
                for (int j = 0; j < row_colum3.GetLength(1); ++j)
                {
                    Console.Write(row_colum3[i,j] + ",");
                }
                Console.WriteLine("\n");
            }


        }
    }
}
