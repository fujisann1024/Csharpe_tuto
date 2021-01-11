using System;

namespace Parts
{
    partial class Parts
    {
        public string Name;//タイヤ名
        public bool Fault = false;      //故障状態f(falseならば正常)




    }

    partial class Parts
    {
        /// <summary>
        /// パーツの名前を表示
        /// </summary>
        public void dispPartsName()
        {
            //thisは分割された変数フィールドを参照している
            Console.WriteLine($"このパーツの名前は{this.Name}です"); 
        }

        /// <summary>
        /// 故障してるかの表示
        /// </summary>
        public void judgeFault()
        {
            if (this.Fault)
            {
                Console.WriteLine($"{this.Name}は何らかの原因で故障しています");
                return;
            }
            Console.WriteLine($"{this.Name}は正常です");
        }

        public static void Main()
        {
            Parts parts = new Parts();
            parts.Name = "タイヤ";
            parts.Fault = true;

            parts.dispPartsName();
            parts.judgeFault();

            //匿名型Ver 3.0
            var rectangle = new { width = 2, height = 3 };
            /*
             下記のコードと同じ
             class a {
                private int width;
                private int height;

                public __a(int width,int height){
                    this.width = width;
                    this.height =~height;
                }

                public int width{
                    get { return this.width }
                }

                public int height{
                    get { return this.height }
                }
            }
             
             */
            Console.WriteLine($"幅:{rectangle.width},高さ:{rectangle.height}");
        }

    }
}
