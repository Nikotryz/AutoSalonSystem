
using AutoSalonSystem.Models;
using System;

namespace AutoSalonSystem.Services
{
    public class SalesService
    {
        public void SellCar(Car car, Client client)
        {
            Console.WriteLine($"Продан {car.Make} {car.Model} клиенту {client.Name}");
        }
    }
}
