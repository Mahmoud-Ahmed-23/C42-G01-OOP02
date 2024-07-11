using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Car
    {

        #region Atrributes

        private int id;

        private string model;

        private double speed;

        #endregion

        #region Properties

        public double Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }



        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        #endregion

        #region Constructor

        //if the isn't a user-defined constructor, Compiler will Generate the Parameterless constructor

        ///public Car()
        ///{
        ///}

        //if the isn a user-defined constructor, Compiler will not Generate the Parameterless constructor

        public Car(int id,string model,double speed)
        {
            this.id = id;
            this.model = model;
            this.speed = speed;
            Console.WriteLine("Constructor 1");
        }

        public Car(int id, string model) : this(id, model, 200) // Constructor Chaining
        {
            Console.WriteLine("Constructor 2");
        }

        public Car(int id):this(id, "Mercedes Benz",250)
        {
            Console.WriteLine("Constructor 3");
        }


        #endregion

        #region Methods

        public override string ToString()
        {
            return $"Car Id: {id}\nModel: {model}\nSpeed: {speed} K/m";
        }


        #endregion
    }
}
