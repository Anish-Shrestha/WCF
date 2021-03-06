﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeService
{
    [DataContract(Namespace ="http://anishtech.com/2016/Employee")]
    public class Employee
    {
        private int _id;
        private string _name;
        private string _gender;
        private DateTime _dateOfBirth;
        [DataMember(Name="ID", Order = 1)]
        public int Id {
            get { return _id; }
            set { _id = value; }
        }
        [DataMember(Name="Name", Order = 2)]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        [DataMember(Name ="Gender", Order = 3)]
        public string Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }
        [DataMember(Name ="DateOfBirth", Order = 4)]
        public DateTime DateOfBirth
        {
            get { return _dateOfBirth; }
            set { _dateOfBirth = value; }
        }
    }
}
