using System;
using sayeedBhai;

namespace jahid
{
    abstract class Human 
    {
        protected Human(string name, string mobileNo, string email, string currentLocation )
        {
            ID = GenerateUniqueID();
            RegistrationDate = DateTime.Now;
            Name = name;
            MobileNo = mobileNo;
            Email = email;
            CurrentLocation = currentLocation;
        }

        protected int ID { get; init; }
        public string Name { get; protected set; }
        protected string MobileNo { get; set; }
        protected string Email { get; set; }
        protected string CurrentLocation { get; set; }
        protected double Rating { get; set; }
        protected DateTime RegistrationDate { get; init; }

        protected int GenerateUniqueID()
        {
            return new Random().Next(1000, 9999);
        }

        public abstract void DisplayInfo();
    }

    class Rider : Human
    {
        public string PaymentMethod { get; private set; }
        public bool IsActive { get; private set; }
        public int TotalRides { get; private set; }

        public Rider(string name, string mobileNo, string email, string currentLocation, double rating, string paymentMethod, bool isActive, int totalRides) : base(name, mobileNo, email, currentLocation)
        {
            Rating = rating;
            PaymentMethod = paymentMethod;
            IsActive = isActive;
            TotalRides = totalRides;
        }

        public void UpdatePaymentMethod(string newPaymentMethod)
        {
            if (!string.IsNullOrWhiteSpace(newPaymentMethod))
            {
                PaymentMethod = newPaymentMethod;
                Console.WriteLine($"Updated Payment Method to {newPaymentMethod}");
            }
            else
            {
                Console.WriteLine("Invalid payment method");
            }
        }

        public void UpdateLocation(string newLocation)
        {
            if (!string.IsNullOrWhiteSpace(newLocation))
            {   
                CurrentLocation = newLocation;
                Console.WriteLine($"Location updated to: {CurrentLocation}");
            }
        }

        public void IncrementTotalRides()
        {
            TotalRides++;
            Console.WriteLine($"Total rides updated: {TotalRides}");
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("\n=== RIDER INFORMATION ===");
            Console.WriteLine($"Name              : {Name}");
            Console.WriteLine($"ID                : {ID}");
            Console.WriteLine($"Mobile            : {MobileNo}");
            Console.WriteLine($"Email             : {Email}");
            Console.WriteLine($"Current Location  : {CurrentLocation}");
            Console.WriteLine($"Rating            : {Rating:F1}");
            Console.WriteLine($"Payment Method    : {PaymentMethod}");
            Console.WriteLine($"Active Status     : {(IsActive ? "Active" : "Inactive")}");
            Console.WriteLine($"Registration Date : {RegistrationDate:yyyy-MM-dd HH:mm:ss}");
            Console.WriteLine($"Total Rides       : {TotalRides}");
            Console.WriteLine("=========================\n");
        }
    }

    class Driver : Human
    {
        public long Earning { get; private set; }
        public bool Status { get; private set; }
        public string VehicleRegistrationNo { get; private set; }
        public string DrivingLicenseNo { get; private set; }

        public Driver(string name, string mobileNo, string email, string currentLocation, double rating, long earning, bool status, string vehicleRegistrationNo, string drivingLicenseNo) : base(name, mobileNo, email, currentLocation)
        {
            Rating = rating;
            Earning = earning;
            Status = status;
            VehicleRegistrationNo = vehicleRegistrationNo;
            DrivingLicenseNo = drivingLicenseNo;
        }

        public void AddEarning(long amount)
        {
            if (amount > 0)
            {
                Earning += amount;
                Console.WriteLine($"Earning added: ${amount}. Total: ${Earning}");
            }
        }

        public void ToggleStatus()
        {
            Status = !Status;
            Console.WriteLine($"Driver status changed to: {(Status ? "Online" : "Offline")}");
        }

        public void UpdateLocation(string newLocation)
        {
            if (!string.IsNullOrWhiteSpace(newLocation))
            {
                CurrentLocation = newLocation;
                Console.WriteLine($"Driver location updated to: {CurrentLocation}");
            }
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("\n=== DRIVER INFORMATION ===");
            Console.WriteLine($"Name              : {Name}");
            Console.WriteLine($"ID                : {ID}");
            Console.WriteLine($"Mobile            : {MobileNo}");
            Console.WriteLine($"Email             : {Email}");
            Console.WriteLine($"Current Location  : {CurrentLocation}");
            Console.WriteLine($"Rating            : {Rating:F1}");
            Console.WriteLine($"Total Earnings    : ${Earning}");
            Console.WriteLine($"Status            : {(Status ? "Online" : "Offline")}");
            Console.WriteLine($"Vehicle Reg No    : {VehicleRegistrationNo}");
            Console.WriteLine($"Driving License   : {DrivingLicenseNo}");
            Console.WriteLine($"Registered On     : {RegistrationDate:yyyy-MM-dd HH:mm:ss}");
            Console.WriteLine("==========================\n");
        }
    }
    
    class Program
    {
        static void Main()
        {
            Rider rider = new(
                "John Doe",
                "123-456-7890",
                "john.doe@example.com",
                "123 Main St",
                4.5,
                "bKash",
                true,
                19
            );

            Driver driver = new(
                "Jane Smith",
                "098-765-4321",
                "jane.smith@example.com",
                "456 Elm St",
                4.8,
                50000,
                true,
                "DHK-1234",
                "DL-987654"
            );

            rider.DisplayInfo();
            driver.DisplayInfo();

            Console.WriteLine("=== Testing Secure Data Modification ===\n");
            
            rider.UpdatePaymentMethod("Card");
            rider.UpdateLocation("456 New St");
            rider.IncrementTotalRides();
            
            driver.AddEarning(100);
            driver.ToggleStatus();
            driver.UpdateLocation("789 Highway Rd");

            Console.WriteLine("\n=== Updated Information ===");
            rider.DisplayInfo();
            driver.DisplayInfo();
        }
    }
}