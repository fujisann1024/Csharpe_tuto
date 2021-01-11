using System;

namespace Human
{
    class Human { 
        
        //get-onlyプロパティ
        public string Name { get; }
        public string Gender { get; }

        public Human(string name, string gender, int age)
        {
            //コンストラクタ内では代入可能
            Name = name;
            Gender = gender;
            Age = age;
        }

        /*
         * class Human 
         * {
            private readonly string _name;
            private readonly string _gender;
            
            public Human(string name,string gender)]
            {
                コンストラクター内だけ代入可能
                _name = name;
                _gender = gender;
            }
            
            public string Name{ get {return _name; }}
            public string Gender{ get { return _gender; }}
         */


        //自動プロパティVer3.0
        public string Address { get; set; }
        /*
         * 以下のコードと同じ
         フィールド
            private string __address;
         プロパティ
            public string Address
            {
                get { return this.__address; }
                set { this.__address = value;}
            }
         */

        //プロパティ初期化子Ver6.0
        public int Age { get; set; } = 0;
    }

}
