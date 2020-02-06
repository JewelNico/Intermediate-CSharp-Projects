using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3343_PerkinsA_Lab01
{
    public class Employee
    {
        // private field declaration

        private string _name;
        private int _id;
        private string _department;
        private string _position;

        public Employee()
        {
            _name = "";
            _id = 0;
            _department = "";
            _position = "";
        }

        // Constructor (parameterized)

        public Employee(string n, string d, string p, int i)
        {
            _name = n;
            _id = i;
            _department = d;
            _position = p;
        }

        /*Properties */

        //Name property

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        // ID property

        public int ID
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        
        // Department Property

        public string Department
        {
            get
            {
                return _department;
            }
            set
            {
                _department = value;
            }
        }

        // Position Property

        public string Position
        {
            get
            {
                return _position;
            }
            set
            {
                _position = value;
            }
        }


    }
    }

