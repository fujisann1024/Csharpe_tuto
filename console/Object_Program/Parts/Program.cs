using System;

namespace Parts
{
    partial class Parts
    {
        public string Name;//タイヤ名
        public bool Fault = false;      //故障状態




    }

    partial class Parts
    {
        public void dispPartsName()
        {
            //thisは分割された変数フィールドを参照している
            Console.WriteLine($"このパーツの名前は{this.Name}です"); 
        }

        public void judgeFault()
        {
            if (!this.Fault)
            {
                Console.WriteLine("このパーツは何らかの原因で故障しています");
                return;
            }
            Console.WriteLine("このパーツは正常です");
        }

    }
}
