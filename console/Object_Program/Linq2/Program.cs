using System;
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
        }
    }
}
