using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class Car
    {
        private string type;
        public string Name { get; set; }
        public string Type {
            get {
                return type; 
            }
            set {
                if (value.Equals("Hatchback") || value.Equals("Sedan") || value.Equals("SUV")) type = value;
                else throw new InvalidCarTypeException($"Invalid Car Type:{value}" + Environment.NewLine +
                  $"Valid Car Types - " + Environment.NewLine +
                  $"1) Hatchback" + Environment.NewLine +
                  $"2) Sedan" + Environment.NewLine +
                  $"3) SUV"); ;
            } 
        }

        public Car(string name, string type)
        {
            Name = name;
            Type = type;
        }

        public string GetCarDetails()
        {
            return $"Car Name:{Name}" + Environment.NewLine +
                $"Car Type:{Type}";
        }

    }
}
