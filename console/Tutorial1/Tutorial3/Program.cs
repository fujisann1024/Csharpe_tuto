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
            /*
             if(条件式a){
                条件式aがtrueの時の処理
            }else if(条件式b){
                条件式bがtrueの時の処理
            }else{
                すべての条件式がfalseの時の処理
            }
            ※else,else ifは省略可能
             */
            int number1;
            Console.Write("整数を入力して下さい:");
            number1 = int.Parse(Console.ReadLine());

            //if文
            if (number1 == 0)
            {
                //0が入力された場合,エラーメッセージだけ表示
                Console.Write("0が入力されました");
            }else if (number1 == 100)
            {
                Console.Write("100が入力されました");
            }
            else
            {
                //0以外が入力された場合,入力された数値の逆数を求めて表示
                double number1_inv = 1.0 / number1;
                Console.Write("1/{0} = {1}", number1, number1_inv);
            }
            Console.Write("");

            Console.Write("整数を入力して下さい:");

            //条件演算子
            var number2 = int.Parse(Console.ReadLine());

            //ifで偶奇判定({}は省略可能)
            string parity1;
            string parity2;
            if (number2 % 2 == 1) parity1 = "odd";
            else parity1 = "even";

            //条件演算子(参考演算子)で偶奇判定
            parity2 = number2 % 2 == 1 ? "odd" : "even";

            //switch文
            Console.Write("if{0},三項演算子{1}",parity1,parity2);
            Console.Write("");

            Console.Write("整数を入力して下さい");

            int number3;
            number3 = int.Parse(Console.ReadLine());

            /*switch文
             switch(値){
                case 値1:
                    値1が一致したときの処理
                break;
                case 値2:
                    値2が一致したときの処理
                break;
                ...
                default:
                    どの値とも一致しなかった場合の処理
                break;
            }

            switch(){
                case 1:
                case 2:
                    値が1または2に一致したら実行
                break;
            }
             */

            switch (number3) {
                //caseの値が一致したときに実行する
                case 1:
                    Console.WriteLine("あなたが入力した数字は1です");
                    break;
                case 2:
                    Console.WriteLine("あなたが入力した数字は2です");
                    break;
                case 3:
                    Console.WriteLine("あなたが入力した数字は3です");
                    break;
                //変数の値がどの値とも異なるときに実行される
                default:
                    Console.WriteLine("あなたが入力した数字はデータに入っていません");
                    break;

            }

            Console.Write("");

            Console.Write("整数を入力して下さい");


            //型による分岐(Ver7)
            int number4 = int.Parse(Console.ReadLine());
            switch (number4)
            {
                case int checkNum:
                    //型が一致しているときに実行
                    //その方に変換した結果が変数にはいる
                    Console.WriteLine("結果" + checkNum);
                    break;

            }

            //when句で条件を付与することも可能
            switch (number4) {
                //値が0より大きいときnに値を代入しコンソールに表示される
                case int n when n > 0:
                    Console.WriteLine("結果" + n);
                    break;
            }

            //複数の値でswitch(タプルswitch)(Ver. 8.0)
            //switch式(Ver 8.0)
            //理解できなかったのでストップ

            //反復処理

            //while文
            /*
             * 初期値
             while(条件式){
                条件式がfalseになるまで反復処理
            }
             */
            int a, b;

            Console.WriteLine("一つ目の整数を入力して下さい");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("二つ目の整数を入力して下さい");
            b = int.Parse(Console.ReadLine());


            Console.Write($"{a}と{b}の最大公約数は");

            //ユークリッド互徐法を使ってaとboの最大公約数を求める
            while (b != 0)
            {
                int r = a % b; //余りを求める
                               //a～割られる数,b～割る数
                a = b;         //aにbを代入
                b = r;         //bにr(余り)を代入
            }

            Console.WriteLine($"{a}");

            //for文
            /*
             for(初期値; 条件式; 更新式){
                条件式がfalseになるまで反復処理
            }
             */


            //九九表の生成
            //ネスト～制御構文の中に制御構文を入れ子にしている
            for (int x = 1; x <= 9; ++x)  //xを1～9まで、1ずつ増やして繰り返し
            {
                for (int y = 1; y <= 9; ++y) //yを1～9まで、1ずつ増やして繰り返し
                {
                    //x,yの値を幅をそろえて表示
                    Console.Write((x * y).ToString().PadRight(3, ' '));
                }
                Console.Write("\n");
            }
           
        }
    }
}
