using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Car
    {

        // Id

        private int id;
        private int speed;
        private string model;


        public string Model

        {

            get { return model; }

            set { model = value; }

        }
        public int Speed
        {
            get { return speed; }

            set { speed = value; }
        }
        public int id {
            get { return id; }
            set { id = value; }

        }
        // CLR Will Generate Parameterless Constructor

        // This Constructor Do Nothing
        // CTOR

        //public Car(){
        //Id = default;
        //Model = default;
        //    speed = default;

        //}


        public Car(int id, int speed, string model) : this(id, speed)
        {

            Id = id;
            Speed = speed;
            Model = model;
        }
        public Car(int id, int speed) : this(id)

        {
            Id = id;
            Speed = speed;
            Model = model;

        }
        public Car(int id)
        {
            Id = id;
           
        }


        public override string ToString()
        { 
         return $"Id: {Id}: Speed: {Speed}::Model: {Model}";
    }
    }
}