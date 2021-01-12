using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;

namespace SecondWebApplication.Entity
{
    //public class Department : DbContext
    //{
    //    // コンテキストは、アプリケーションの構成ファイル (App.config または Web.config) から 'Department' 
    //    // 接続文字列を使用するように構成されています。既定では、この接続文字列は LocalDb インスタンス上
    //    // の 'SecondWebApplication.Entity.Department' データベースを対象としています。 
    //    // 
    //    // 別のデータベースとデータベース プロバイダーまたはそのいずれかを対象とする場合は、
    //    // アプリケーション構成ファイルで 'Department' 接続文字列を変更してください。
    //    public Department()
    //        : base("name=Department")
    //    {
    //    }

    //    // モデルに含めるエンティティ型ごとに DbSet を追加します。Code First モデルの構成および使用の
    //    // 詳細については、http://go.microsoft.com/fwlink/?LinkId=390109 を参照してください。

    //    // public virtual DbSet<MyEntity> MyEntities { get; set; }
    //}

    public class Department {
        
        //主キー
        public int DepartmentId { get; set; }

        //部門名
        [StringLength(50)]
        public string Name { get; set; }

        //従業員リスト
        //Employeesエンティティを読み込んだ時には関連するDepartmentエンティティを読み込む
        //virtual～遅延ローディング機能を有効化
        public virtual ICollection<Employee> Employees { get; set; }

    }

}