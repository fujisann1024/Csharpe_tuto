using System;

namespace Sports
{
    //基底クラス
    class SportsPlayer {
        public string name;
        public int age;
        public int height;
        public int weight;

        public int number1 = 1;
        protected int number2 = 2;
        private int number3 = 3;

        public SportsPlayer() {
            Console.WriteLine("明示したコンストラクタです");
        }
        public SportsPlayer(string name, int age, int height, int weight)
        {
            this.name = name;
            this.age = age;
            this.height = height;
            this.weight = weight;
            Console.WriteLine("基底クラスです");
        }

        

        public void getInfo()
        {
            Console.WriteLine($"この選手の情報は\n選手名:{this.name}\n年齢:{this.age}です");
        }

    }

    //派生クラス
    // class 派生クラス:基底クラス
    class SoccerPlayer : SportsPlayer
    {
        public string playerNumber;
        
        public SoccerPlayer():base("",0,0,0)
        {
            Console.WriteLine("派生クラスです");
        }

        public void dispNumber()
        {
            Console.WriteLine($"public:{this.number1}");
            Console.WriteLine($"protected:{this.number2}");
            //エラー:Console.WriteLine($"protected:{this.number3}");

        }

    }

    //継承できないクラス(sealed～封印された)
    sealed class NotExtends { }

    class A { }

    class B :A{ }

    class Parent { }

    class Children1 : Parent { }

    class Children2 : Parent { }

    class world
    {
        public static void Main()
        {
            SportsPlayer sportsplayer = new SportsPlayer();
            sportsplayer.name = "山田";
            sportsplayer.age = 20;


            //SportsPlayerのメンバーをそのまま利用できる
            SoccerPlayer soccerPlayer = new SoccerPlayer();
            soccerPlayer.name = "佐藤";
            soccerPlayer.age = 30;

            //サッカープレイヤーはスポーツプレイヤーの一種
            SportsPlayer player1 = soccerPlayer;

            /*SoccerPlayer player2 = sportsPlayer;
             * エラー
             * スポーツ選手はサッカー選手の一種×
             */

            Console.WriteLine(typeof(A));
            A b = new B();
            Console.WriteLine(b.GetType());

            //アップキャスト～基底クラスの変数に派生クラスの変数を渡すこと
            //ダウンキャスト～派生クラスの変数に基底クラスの変数を渡すこと
            Children1 chil1 = new Children1();
            Children2 chil2 = new Children2();

            Parent parent = new Parent();
            Children1 children = new Children1();

            parent = chil1;             //アップキャスト～明示的なキャスト不要
            parent = (Parent)children;  //ダウンキャスト～明示的なキャスト必要

        }   


    }

}
