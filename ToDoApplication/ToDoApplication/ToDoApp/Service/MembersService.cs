using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ToDoApplication.ToDoApp.Common
using ToDoApplication.ToDoApp.Entity

namespace ToDoApplication.ToDoApp.Service
{
    public class MembersService 
    {
        
        public List<MembersEntity> getMembersInfo()
        {
            var membersList = new List<MembersEntity>();

            var sql = @"
                SELECT name,age,address,gender,birthday 
                FROM members with(nolock)
            ";
        }
    }
}