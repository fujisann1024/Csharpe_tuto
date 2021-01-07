using System;

namespace Tutorial3
{
    class Program
    {
        static void Main(string[] args)
        {
            //構造化定理～エドガー　ダイクストラ
            /*
             ・制御フロー
             ・配列
             ・関数
             ・データ構造
             ・名前空間
             ・構造化例外処理
             */

            //条件分岐
            int number1;
            Console.Write("整数を入力して下さい:");
            number1 = int.Parse(Console.ReadLine());

            if (number1 == 0)
            {
                //0が入力された場合,エラーメッセージだけ表示
                Console.Write("0が入力されました");
            }
            else
            {
                //0以外が入力された場合,入力された数値の逆数を求めて表示
                double number1_inv = 1.0 / number1;
                Console.Write("1/{0} = {1}", number1, number1_inv);
            }

            Console.Write("整数を入力して下さい:");

            //条件演算子
            var number2 = int.Parse(Console.ReadLine());

            //ifで偶奇判定({}は省略可能)
            string parity1;
            string parity2;
            if (number2 % 2 == 1) parity1 = "odd";
            else parity1 = "even";

            //条件演算子で偶奇判定
            parity2 = number2 % 2 == 1 ? "odd" : "even";

            Console.Write("if{0},三項演算子{1}",parity1,parity2);

        }
    }
}
