using System;
//using～名前空間

namespace Tutorial1
{
    class Program
    {
        //class～クラス
        static void Main(string[] args)
        {

            //標準出力
            Console.WriteLine("Hello World!");

            //標準入力
            //ユーザーの入力した文字列を一行読み込む
            Console.WriteLine("文字列を入力して下さい");
            var stringData = Console.ReadLine();

            //他の種類
            //ユーザーの入力した整数を読み込む
            Console.WriteLine("整数を入力して下さい");
            var numberData = int.Parse(Console.ReadLine());

            //ユーザーの入力した実数を読み込む
            Console.WriteLine("実数を入力して下さい");
            var doubleData = double.Parse(Console.ReadLine());

            int m = 1, n = 3;
            //フォーマット出力
            //Consele.Write(format,arg0,arg1...);
            Console.Write("m = {0},n = {1}", m,n);

            //変数の宣言
            bool dataB;  //論理値型
            int dataN;   //整数型
            double dataD; //実数型
            char dataC;   //文字型
            string dataS; //文字列型

            //リテラル～直定数、代入みたいなやつ
            //bool bo = true;
            //int num = 4;
            //double xble = 4.5;
            //char ch = 'a';
            //string str = "文字列";

            //型推論～右辺の値から型を推測(Ver3.0)
            var bo = true;
            var num = 4;
            var xble = 4.5;
            var ch = 'a';
            var str = "文字列";

            //ただし
            //var x;
            // = 1;
            //推論の手がかりがないのでコンパイルエラー

            //var num2 = 0;
            //n = "";
            //型が変わってしまっているのでエラー

            //タプル～複数の変数をまとめたり同時に宣言出来たりすること
            var (a, b) = (4, 5);
            var (sum, diff) = (a + b, a - b);
            Console.WriteLine("testタプル");
            Console.WriteLine(sum);
            Console.WriteLine(diff);

            //複文(ブロック)
            int number1 = 5, number2 = 4;
            {
                int number3 = number1 + number2;
                int number4 = number1 * number2;
                Console.WriteLine("test計算");
                Console.WriteLine(number3);
                Console.WriteLine(number4);
            }

        }
    }
}
