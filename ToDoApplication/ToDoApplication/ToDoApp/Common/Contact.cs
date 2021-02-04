using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToDoApplication.ToDoApp.Common
{
   public static class membersSQLKey
    {
        public static readonly string TableName = "members";

        /// <summary>
        /// メンバーid
        /// </summary>
        public static readonly string id = "id";

        /// <summary>
        /// 名前
        /// </summary>
        public static readonly string name = "name";

        /// <summary>
        /// 年齢
        /// </summary>
        public static readonly string age = "age";

        /// <summary>
        /// 住所
        /// </summary>
        public static readonly string address = "address";

        /// <summary>
        /// メールアドレス
        /// </summary>
        public static readonly string email = "email";

        /// <summary>
        /// パスワード
        /// </summary>
        public static readonly string password = "password";

        /// <summary>
        /// 性別
        /// </summary>
        public static readonly string gender = "gender";

        /// <summary>
        /// 誕生日
        /// </summary>
        public static readonly string birthday = "birthday";

        /// <summary>
        /// アカウントロックフラグ
        /// </summary>
        public static readonly string lock_account_flag = "lock_account_flag";

        /// <summary>
        /// 退会フラグ
        /// </summary>
        public static readonly string leave_flag = "leave_flag";

        /// <summary>
        /// 作成日
        /// </summary>
        public static readonly string created_at = "created_at";

        /// <summary>
        /// 更新日
        /// </summary>
        public static readonly string updated_at = "updated_at";
    }

}