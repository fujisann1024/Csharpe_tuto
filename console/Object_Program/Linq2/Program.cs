using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq2
{
    class Program
    {
        static void Main(string[] args)
        {

            //テーブルのイメージ

            var students = new[] {
                new{id = 1, name = "佐藤", age = 20},
                new{id = 2, name = "鈴木", age = 18},
                new{id = 3, name = "高橋", age = 17},
                new{id = 4, name = "山田", age = 16},
                new{id = 5, name = "田中", age = 18},
            };

            //Linq
            var meibo =
                from student in students
                where student.age >= 18
                orderby student.id
                select student.name;

            foreach (var name in students)
            {
                Console.WriteLine(name);
            }

            var evenNumbers = new[]{ 0, 2, 4, 6, 8, 10, 12 };

            var oddNumbers = new[] { 1, 3, 5, 7, 9, 11 };
            
            static void Show<T>(IEnumerable<T> a)
            {
                foreach (var x in a)
                {
                    Console.Write(x);
                }
                Console.WriteLine();
            }

            //パーティション分割子
            //先頭のn個のみ取り出す
            Show(evenNumbers.Take(5));
            //先頭n個を読み飛ばす
            Show(evenNumbers.Skip(5));
            //先頭から,条件を満たす間だけ取り出す
            Show(evenNumbers.TakeWhile(x => x == 2));
            //先頭から,条件を満たす間だけ読み飛ばす
            Show(evenNumbers.SkipWhile(x => x == 2));

            //連結演算子
            Show(evenNumbers.Concat(oddNumbers));

            //順序付け演算子
            Show(oddNumbers.Reverse());

            var SetA = new[] { 1, 4,4, 6,6, 7, 8, 10 };
            var SetB = new[] { 1, 3, 5, 7, 8, 9  };


            //セット演算子
            Show(SetA.Distinct());     //重複を取り除く
            Show(SetA.Union(SetB));    //和集合
            Show(SetA.Intersect(SetB));//積集合
            Show(SetA.Except(SetB));   //差集合


        }

    }
}
