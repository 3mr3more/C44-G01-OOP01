using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal struct Employee

    {

        private int id;
        private string name;
        private double salary;
        private string address;
        // Apply Encapsulation User Setter Getter Method

        // Setter

        public void SetId(int id)

        {

            this.id = id;

        }

        // Getter

        public int GetId()

        {

            return id;
        }
        // Setter Name

        public void SetName(string name)

        {
            if (name.Length >= 8 && name.Length <= 20)
                this.name = name;

        }
        // Getter Name

        public string GetName()

        {

            return name;
        }
        public void SetSalary(double salary)

        {
            if (salary > 0)
                this.salary = salary;
        }
        public double GetSalary()

        {

            return salary;
        }
        public string Address

        {
            set

            {

                address = value;
            }

            get

            {

                return address;

            }
        }

// 2. Automatic Property
public string Address { set; get; }

        // 3. Special Property [Indexer]



        public Employee(int id, string name, double salary)

        {

            SetId(id);
            SetName(name);
            SetSalary(salary);
        }
        public override string ToString()

        {

            return $"Id: {id}:: Name: {name}:: Salary: {salary}";

        }

        //Apply Encapsulation User Properties:

        // 1. Full Property

        // Id

        public int Id
        {

            // set
            // get

            set

            {

                id = value;
            }
            get
            {

                return id;

            }

        }
        // Name

        public string Name
        {

            set
            {
                if (value.Length >= 8 && value.Length <= 20)
                    name = value;
            }

            get
            {
                    return name;
            }
        }
        public double Salary
        {

            set
            {
                if (value > 0)
                    salary = value;
            }

            get
            {

                return salary;
            }
        }

}
    }



