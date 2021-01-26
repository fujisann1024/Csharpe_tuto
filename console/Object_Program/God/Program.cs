using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace God
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    


    //意味のないメソッドが生成されるのを回避したい

    //パターン1 何かしら意味を持つ値を返すようにする
    //          クラスをインスタンス化しないようにする
    class Person
    {
        protected int age;

        //外部からコンストラクタを呼び出せない
        protected Person(int age) { this.age = age;  }
        
        
        public virtual int Age
        {
            
            get
            {
                return 0;
            }
        }
    }
    
    //ただしサブクラスでわざわざオーバーライドしないとスーパクラス
    //のメソッドが使われてしまう。

    //抽象クラス
    abstract class Person2
    {
        protected string name2;
        protected int age2;

        public Person2(int age2,string name2) { 
            this.age2 = age2;
            this.name2 = name2;
        }

        public string Name { get { return this.name2; } }
        public abstract int Age { get; }
        
      }

    /// <summary>
    /// 正直者
    /// </summary>
    class Truepenny : Person2
    {
        public Truepenny(int age2, string name2) : base(age2, name2) { }

        public override int Age
        {
            get
            {
                return this.age2;
            }
        }
    }

    /// <summary>
    /// 嘘つきもの
    /// </summary>
    
    class Liar : Person2
    {
        public Liar(int age2, string name2) : base(age2, name2) { }

        public override int Age
        {
            get
            {
                //年を取るほどサバを読む
                if (this.age2 < 20) return this.age2;
                if (this.age2 < 25) return this.age2 - 1;
                if (this.age2 < 30) return this.age2 - 2;
                if (this.age2 < 35) return this.age2 - 3;
                if (this.age2 < 40) return this.age2 - 4;
                return this.Age - 5;
            }
        }
    }

    class ItemList<T> : IEnumerable<T>
    {
       
    }

}
