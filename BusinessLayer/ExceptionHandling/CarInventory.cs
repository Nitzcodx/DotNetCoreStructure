using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class CarInventory
    {
        Car[] availableCars;
        Car jazz;
        Car city;
        Car innova;
        Car landrover;

        public CarInventory()
        {
            //availableCars = new Car[4];   uncommemt to check null reference exception
            availableCars = new Car[3];
            jazz = new Car("Jazz", "Hatchback");
            city = new Car("City", "Sedan");
            innova = new Car("Innova", "SUV");
            landrover = new Car("Landrover", "SUV");
        }

        public string GetInventory()
        {
            try
            {
                try     //nested try -
                        //outer catch block is not executed if inner catch match is found, outer finally will be executed
                {
                    Car nano = new Car("Nano", "Mini");
                    string inventory = string.Empty;
                    availableCars[0] = jazz;
                    availableCars[1] = city;
                    availableCars[2] = innova;
                    availableCars[3] = landrover;   //comment to check null reference exception
                    foreach (Car car in availableCars)
                    {
                        inventory += car.GetCarDetails();
                    }
                    return inventory;
                }
                catch (InvalidCarTypeException ex)
                {
                    return ex.Message;
                }
                catch (IndexOutOfRangeException ex)
                {
                    return $"No further details available" + Environment.NewLine +
                        $"Error Message:{ex.Message}" + Environment.NewLine +
                        $"Error Type:{ex.GetType()}" + Environment.NewLine +
                        $"Error Location:{ex.StackTrace}";
                }

            }
            catch (NullReferenceException ex)
            {
                return $"No further details available" + Environment.NewLine +
                    $"Error Message:{ex.Message}" + Environment.NewLine +
                    $"Error Type:{ex.GetType()}" + Environment.NewLine +
                    $"Error Location:{ex.StackTrace}";
            }
            catch(Exception ex)
            {
                return $"No further details available" + Environment.NewLine +
                    $"Error Message:{ex.Message}" + Environment.NewLine +
                    $"Error Type:{ex.GetType()}" + Environment.NewLine +
                    $"Error Location:{ex.StackTrace}";
            }
            finally
            {
                Console.WriteLine($"Thanks!");
            }
        }
    }
}
