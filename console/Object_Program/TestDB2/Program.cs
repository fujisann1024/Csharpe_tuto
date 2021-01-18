using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDB2
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<EmployeesEntity> EmployeesList = new List<EmployeesEntity>();

            EmployeesList = EmployeesService.GetConnectString();
            foreach(EmployeesEntity empData in EmployeesList)
            {
                Console.Write($"{empData.Id}");
                Console.Write($"{empData.Name}");
                Console.Write($"{empData.Address}\n");
            }

            // OOP(Object Oriented Programming)とデータベース問い合わせ
            //との統合

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
                where student.age >= 17
                orderby student.id
                select student.name;

            foreach (var name in students)
            {
                Console.WriteLine(name);
            }
        }
    }
}
