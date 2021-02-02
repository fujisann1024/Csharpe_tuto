using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToDoApplication.ToDoApp.Entity
{
    public class MembersEntity
    {

        private int _id;
        private string _name;
        private int _age;
        private string _address;
        private string _email;
        private string _password;
        private string _gender;
        private DateTime _birthday;
        private bool _lockAccountFlag;
        private bool _leaveFlag;
        private DateTime _createdAt;
        private DateTime _updatedAt;



        public MembersEntity()
        {

        }
        
        public int Id {
            get
            {
                if(this._id != null)
                {
                    return this._id;
                }
                return 0;
            }
        }

        public string Name {
            get 
            {
                if (this._name != null)
                {
                    return this._name;
                }
                return "";
            } 
        }

        public int Age {
            get
            {
                if (this._age != null)
                {
                    return this._age;
                }
                return 0;
            }
        }

        public string Address {
            get
            {
                if (this._address != null)
                {
                    return this._address;
                }
                return "";
            }
        }

        public string Email {
            get
            {
                if (this._email != null)
                {
                    return this._email;
                }
                return "";
            }
        }

        public string Password {
            get
            {
                if (this._password != null)
                {
                    return this._password;
                }
                return "";
            }
        }

        public string Gender {
            get
            {
                if (this._gender != null)
                {
                    return this._gender;
                }
                return "";
            }
        }

        public DateTime Birthday {
            get
            {
                if (this._birthday != null)
                {
                    return this._birthday;
                }
                return "";
            }
        }

        public bool LockAccountFlag { get; }
        
        public bool LeaveFlag { get; }

        public DateTime CreatedAt {
            get
            {
                if (this._createdAt != null)
                {
                    return this.CreatedAt;
                }
                return "";
            }
        }

        public DateTime UpdatedAt {
            get
            {
                if (this._updatedAt != null)
                {
                    return this._updatedAt;
                }
                return "";
            }
        }

    }
}