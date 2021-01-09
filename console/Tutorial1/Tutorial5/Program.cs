using System;

namespace Tutorial5
{
    class Program
    {
        static void Main(string[] args)
        {
           //同じ処理は関数化してまとめる
           /*関数定義
            戻り値の型 関数名(引数1,引数2,・・・){
                処理
           }

            Ver.6
           戻り値の型 関数名(引数1,引数2,・・・) => 関数本体の式
            */

            //sinxを求める関数、テイラー展開を利用
            //Ver.7ローカル関数～関数の中(この場合はMain関数)に関数を記述できる
            static double Sin(double x)
            {
                double xx = -x * x;
                double fact = 1;
                double sin = x;

                for (int i = 1; i<100;)
                {
                    fact *= i; ++i;
                    fact *= i; ++i;
                    x *= xx;
                    sin += x / fact;
                }
                //戻り値
                return sin;
            }

            for(int i = 0; i < 10; i++)
            {
                double x = 0.01 * i;

                double y = Sin(x); //関数呼び出し

                Console.WriteLine("sin({0:f2}) = {1:f6}",x,y);
            }

            /*returnの位置
             returnは途中でも書けるがその場合returnより下の処理は実行されない
             */
            //引数はコンマで複数設けることができる～引数リスト
            double Norm(double x, double y, double z)
            {
                return x * x + y * y + z * z;
            }

            //引数のない関数
            ulong seed = 4275646295673547UL;
            ulong Random()
            {
                // 線形合同法による疑似乱数の生成
                unchecked { seed = seed * 1566083941UL + 1; }
                return seed;
            }

            //戻り値のない関数～サブルーチン,プロシージャ
            void writeArray(int[] array)
            {
                Console.Write("{");

                for (int i = 0; i < array.Length; ++i)
                {
                    Console.Write("{0},", array[i]);
                }
                Console.Write("}\n");
            }

            //Ver4.0オプション引数,名前付き引数
            static int Sum(int x = 0, int y = 2, int z = 1)
            {
                return x + y + z;
            }

            //引数の省略
            var s1 = Sum(); //Sum(0,2,1);
            var s2 = Sum(1, 4);//Sum(1,4,1);

            //名前付き引数を与える
            var s3 = Sum(x: 1, z: 3);//Sum(1,2,3);
            Console.WriteLine("引数の省略パターン1:{0},パターン2:{1}" +
                              "名前付き引数:{2}",s1,s2,s3);

            //匿名(無名)関数(ラムダ式)
            int r = 3;
            double f(int r) => r * r * 3.14;
            Console.WriteLine("円の面積:"+ f(r));

            //void型を使わず表記
            //メソッドグループ～いくつかあるメソッドA1のうちのいずれか状態
            Action<int> a1 = A1;
            Func<int, int> f1 = F1;
        }
        
        //void型だけ書き方を変えるのは不備
        static void A1(int x) { }  //戻り値あり
        static void A1(string x) { }
        static int F1(int x) => 0;  //戻り値なし

        


        //関数のオーバーロード～引数リストが異なる同名の関数
        void WriteTypeAndValue(string s)
        {
            Console.Write("文字列 : {0}\n", s);
        }

        void WriteTypeAndValue(int n)
        {
            Console.Write("整数   : {0}\n", n);
        }

        void WriteTypeAndValue(double x)
        {
            Console.Write("実数   : {0}\n", x);
        }

        //様々な方や実引数の数によって適用する処理を変えることができる
        /*
         オーバーロードできない関数
        関数名が違う
        戻り値が違う
         */

        //シグネチャ～関数の呼び分けに必要な情報
        /*例
         C,Go言語は関数のオーバーロード自体を認めていない⇒関数名がシグネチャ
        C#は仮引数の数や型によって適用する関数を決める=>引数の型と数がシグネチャ
         */

        //Ver.06
        //expression-bodied(本体が式の)関数
        //戻り値の型 関数名(引数リスト) => 戻り値;
        static double Norm(double x, double y, double z) => x * x + y * y + z * z;
        

    }
}
