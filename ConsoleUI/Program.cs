using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.Entity;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            //CarGetAllTest();
            //UserAddTest();
            //CustomerDtoGettAllTest();
            //CustomerAddTest();
            //RentalAddTest();
            //RentalGetAll();

            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            var result = rentalManager.GetAllByReturnDate();
            foreach (var rental in result.Data)
            {
                Console.WriteLine(rental.Id+ " " +rental.CarId + " " +rental.CustomerId + " " +rental.RentDate + " " +rental.ReturnDate);
            }

        }

        private static void RentalGetAll()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            var result = rentalManager.GetAll();
            foreach (var rental in result.Data)
            {
                Console.WriteLine(rental.Id + " " + rental.CarId + " " + rental.CustomerId + " " + rental.RentDate + " " + rental.ReturnDate);
            }
        }

        private static void RentalAddTest()
        {
            Rental rental = new Rental();
            rental.CarId = 1;
            rental.CustomerId = 1;
            rental.RentDate = DateTime.Now;
            rental.ReturnDate = DateTime.Parse("20.04.2022 17:27:26");



            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            var result = rentalManager.Add(rental);
            Console.WriteLine(result.Message);
        }

        private static void CustomerAddTest()
        {
            Customer customer = new Customer() { UserId = 1, CompanyName = "Techno Fual" };
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            var result = customerManager.Add(customer);
            Console.WriteLine(result.Message);
        }

        private static void CustomerDtoGettAllTest()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());

            var result = customerManager.GetAllDetails();
            if (result.Success == true)
            {
                foreach (var customer in result.Data)
                {
                    Console.WriteLine(customer.CustomerFirstName + " " + customer.CustomerLastName + " " + customer.CompanyName);
                }

            }
            Console.WriteLine(result.Message);
        }

        private static void UserAddTest()
        {
            User user = new User() { FirstName = "G", LastName = "Kariparduç", Email = "gizem@hotmail.com", Password = "absacad" };
            UserManager userManager = new UserManager(new EfUserDal());
            var result = userManager.Add(user);
            Console.WriteLine(result.Message);
        }

        private static void CarGetAllTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }
        }
    }
}
