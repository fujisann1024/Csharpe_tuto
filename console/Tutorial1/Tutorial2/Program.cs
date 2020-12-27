using System;

namespace Tutorial2
{
    class Program
    {
        static void Main(string[] args)
        {
            //オペランド～演算の対象
            int number1 = 9,number2 = 5;

            //算術演算子
            int sum = number1 + number2;
            int diff = number1 - number2;
            int pro = number1 * number2;
            double quo = number1 / number2;
            int rem = number1 % number2;

            //文字列挿入
            var formatted = $"(和={sum},差={diff},積={pro},商={quo},剰余={rem})";

            //複数行の文字列
            string profile = $@"
                名前：山田太郎
                年齢:25
                性別:男
            ";
            Console.WriteLine(profile);

            Console.WriteLine(formatted);
            //符号反転
            int number3 = 5;
            int revNumber = -number3;
            Console.Write("");

            //文字列連結
            string fullName = "山田" + "太郎";
            Console.WriteLine(fullName);


            //型変換
            int day = 365;
            short sho = (short)day;

            double pai = 3.141592;
            long lo = (long)pai;

            Console.WriteLine(sho);//365
            Console.WriteLine(lo); //3

            //オーバーフローのチェック
            sbyte a = 64;           // 2進表現では 0100 0000。
            sbyte b = 65;           // 2進表現では 0100 0001。
            sbyte c = (sbyte)(a + b); // 2進表現では 1000 0001 ←これは sbyte では -127 を表す。
            Console.Write("{0} + {1} = {2}", a, b, c); // 64 + 65 = -127 と表示される。
            
            //オーバーフローを起こしたら例外を投げる
            try {
                checked
                {
                    sbyte e = 64;           // 2進表現では 0100 0000。
                    sbyte f = 65;           // 2進表現では 0100 0001。
                    sbyte g = (sbyte)(a + b); // 2進表現では 1000 0001
                }
            }catch (OverflowException OE){
                Console.Write(OE.Message);
            }

            //定数
            const double PAI = 3.14;
            //PAI = 3 エラーになる

            int radius = 4;

            double circleArea = radius * radius * PAI;
            Console.WriteLine(circleArea);
        }
    }
}
