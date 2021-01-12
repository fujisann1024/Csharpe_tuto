using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;

namespace SecondWebApplication.Entity
{
    //public class Employee : DbContext
    //{
    //    // コンテキストは、アプリケーションの構成ファイル (App.config または Web.config) から 'Employee' 
    //    // 接続文字列を使用するように構成されています。既定では、この接続文字列は LocalDb インスタンス上
    //    // の 'SecondWebApplication.Entity.Employee' データベースを対象としています。 
    //    // 
    //    // 別のデータベースとデータベース プロバイダーまたはそのいずれかを対象とする場合は、
    //    // アプリケーション構成ファイルで 'Employee' 接続文字列を変更してください。
    //    public Employee()
    //        : base("name=Employee1")
    //    {
    //    }

    //    // モデルに含めるエンティティ型ごとに DbSet を追加します。Code First モデルの構成および使用の
    //    // 詳細については、http://go.microsoft.com/fwlink/?LinkId=390109 を参照してください。

    //    // public virtual DbSet<MyEntity> MyEntities { get; set; }
    //}
    //①社員エンティティクラス
    public class Employee
    {
        //②社員ID。主キー
        //プロパティ名がIdだとや{クラス名}Idだと主キーとして扱う
        public int EmployeeId { get; set; }

        //③名前(最大長50文字)
        [StringLength(50)]
        public string Name { get; set; }

        //④誕生日
        //SQL⇒datetime
        public DateTime Birthday { get; set; }

        //⑤今期売上高
        //SQL⇒decimal
        public decimal Sales { get; set; }

        //⑥電話番号
        //StringLength(文字列の最大長)
        [StringLength(50)]
        public string TelNo { get; set; }

        //⑦性別
        //SQL⇒bit
        public bool Sex { get; set; }

        //⑧課ID
        public int DepartmentId { get; set; }

        //⑨所属する課のエンティティ
        //ナビゲーションプロパティ～リレーションシップを表すプロパティ
        public virtual Department Department { get; set; }

    }
}