using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            
            //colorManager.Add(new Color { ColorId = 6, ColorName = "Gray" }); colorManager.Add(new Color { ColorId = 7, ColorName = "Green" });
            //brandManager.Add(new Brand { BrandId = 6, BrandName = "Opel" }); brandManager.Add(new Brand { BrandId = 7, BrandName = "Volkswagen" });
            //brandManager.Update(new Brand { BrandId = 4, BrandName = "Mercedes" });




            //EfTest();
            //InMemoryTest();
        }

        //private static void EfTest()
        //{
        //    CarManager carManager = new CarManager(new EfCarDal());
        //    //carManager.Add(new Car { CarId=3,BrandId=3,ColorId=5,ModelYear=2018,DailyPrice=800,Descriptions="Yellow BMW Car"});
        //    //carManager.Add(new Car { CarId = 4, BrandId = 3, ColorId = 2, ModelYear = 2015, DailyPrice = 500, Descriptions = "Old BMW Car" });
        //    foreach (var car in carManager.GetAll())
        //    {
        //        Console.WriteLine(car.CarId + ". car: " + car.Descriptions);
        //    }
        //    Console.WriteLine("--------------------------");

        //    Console.WriteLine(carManager.GetById(1).Descriptions);
        //    Console.WriteLine("--------------------------");

        //    foreach (var car in carManager.GetAllByBrandId(3))
        //    {
        //        Console.WriteLine(car.CarId + ". car: " + car.Descriptions);
        //    }
        //    Console.WriteLine("--------------------------");

        //    foreach (var car in carManager.GetByDailyPrice(700, 900))
        //    {
        //        Console.WriteLine(car.CarId + ". car: " + car.Descriptions + ": " + car.DailyPrice);
        //    }
        //    Console.WriteLine("--------------------------");

        //    //carManager.Add(new Car { CarId = 5, BrandId = 4, ColorId = 4, ModelYear = 2021, DailyPrice = 700, Descriptions = "New added car" });
        //    Console.WriteLine(carManager.GetById(5).Descriptions);
        //    //carManager.Update(new Car { CarId = 5, BrandId = 4, ColorId = 4, ModelYear = 2024, DailyPrice = 12000, Descriptions = "Future Car" });
        //    var updatedCar = carManager.GetById(5);
        //    Console.WriteLine(updatedCar.CarId + ". car " + updatedCar.BrandId + " " + updatedCar.ColorId + " " + updatedCar.ModelYear + " " + updatedCar.DailyPrice + " " + updatedCar.Descriptions);

        //    carManager.Delete(new Car { CarId = 5 }); // It works perfectly
        //}

        //private static void InMemoryTest()
        //{
        //    CarManager carManager = new CarManager(new InMemoryCarDal());
        //    foreach (var car in carManager.GetAll())
        //    {
        //        Console.WriteLine(car.CarId + ". car: " + car.Descriptions);
        //    }

        //    Console.WriteLine("-------------------------------");
        //    carManager.Add(new Car { CarId = 6, BrandId = 5, ColorId = 5, DailyPrice = 800, ModelYear = 2017, Descriptions = "New Car" });
        //    foreach (var car in carManager.GetAll())
        //    {
        //        Console.WriteLine(car.CarId + ". car: " + car.Descriptions);
        //    }

        //    //Console.WriteLine("-------------------------------");
        //    //foreach (var car in carManager.GetById(3))
        //    //{
        //    //    Console.WriteLine(car.Descriptions);
        //    //}

        //    Console.WriteLine("-------------------------------");
        //    carManager.Delete(new Car { CarId = 6 });
        //    foreach (var car in carManager.GetAll())
        //    {
        //        Console.WriteLine(car.CarId + ". car: " + car.Descriptions);
        //    }

        //    Console.WriteLine("-------------------------------");
        //    carManager.Update(new Car { CarId = 1, BrandId = 5, ColorId = 5, DailyPrice = 800, ModelYear = 2017, Descriptions = "Fast Car Edited Description" });
        //    foreach (var car in carManager.GetAll())
        //    {
        //        Console.WriteLine(car.CarId + ". car: " + car.Descriptions);
        //    }
        //}
    }
}