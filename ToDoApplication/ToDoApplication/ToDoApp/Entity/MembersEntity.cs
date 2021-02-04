using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToDoApplication.ToDoApp.Entity
{
    public class MembersEntity
    {

        
        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public string Address { get; set; }

        public string Email { get; set; }


        public string Password { get; set; }

        public string Gender { get; set; }

        public DateTime Birthday { get; set; }

        public bool LockAccountFlag { get; set; }
        
        public bool LeaveFlag { get; set; }

        public DateTime CreatedAt { get; set; }
        

        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// ユーザー
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="address"></param>
        /// <param name="gender"></param>
        /// <param name="birthday"></param>
        public MembersEntity(
            string name,
            int age,
            string address,
            string gender,
            DateTime birthday
            ) 
        {
            this.Name = name;
            this.Age = age;
            this.Address = address;
            this.Gender = gender;
            this.Birthday = birthday;
        }

        /// <summary>
        /// ユーザー情報
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="address"></param>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <param name="gender"></param>
        /// <param name="birthday"></param>
        /// <param name="lockAccountFlag"></param>
        /// <param name="leaveFlag"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        public MembersEntity(
            int id,
            string name,
            int age,
            string address,
            string email,
            string password,
            string gender,
            DateTime birthday,
            bool lockAccountFlag,
            bool leaveFlag,
            DateTime createdAt,
            DateTime updatedAt
            ) 
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;
            this.Address = address;
            this.Email = email;
            this.Password = password;
            this.Gender = gender;
            this.Birthday = birthday;
            this.LockAccountFlag = lockAccountFlag;
            this.LeaveFlag = leaveFlag;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;

        }

    }
}