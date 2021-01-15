using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB.Entity
{
    class EmployeesEntity
    {
        public EmployeesEntity(int id, string name, string address)
        {
            Id = id;
            Name = name;
            Address = address;
        }

        public int Id { get; }

        public string Name { get; }

        public string Address { get; }
    }
}
}
