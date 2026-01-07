using System;

// ============================================================================
// RIDE-SHARING SYSTEM - Demonstrating OOP Concepts in C#
// ============================================================================

namespace sayeedBhai
{
    // ========================================================================
    // MAIN PROGRAM - Testing the System
    // ========================================================================
    class Program
    {
        static void MainClass02(string[] args)
        {
            // Create riders
            Rider rider = new(
                "John Doe",
                "123-456-7890",
                "john.doe@example.com",
                "123 Main St",
                "ABC123",
                "DL123456"
            );

            Rider rider2 = new(
                "Alice Brown",
                "555-555-5555",
                "alice.brown@example.com",
                "789 Pine Rd",
                "XYZ789",
                "DL789012"
            );

            // Create passenger
            Passenger passenger = new(
                "Jane Smith",
                "098-765-4321",
                "jane.smith@example.com",
                "456 Oak Ave",
                4.5,
                "O+"
            );

            // Display information
            rider.DisplayInfo();
            rider2.DisplayInfo();
            passenger.DisplayInfo();

            // Test reference equality
            Rider rider3 = new(
                "John Doe",
                "123-456-7890",
                "john.doe@example.com",
                "123 Main St",
                "ABC123",
                "DL123456"
            );

            Console.WriteLine($"Are rider and rider3 equal? {rider == rider3}");

            // Test record struct - value-based equality
            Cat cat1 = new() { Name = "Whiskers", Age = 3 };
            Cat cat2 = new() { Name = "Whiskers", Age = 3 };

            Console.WriteLine($"Are cat1 and cat2 equal? {cat1 == cat2}");

            // Process payments
            var payment1 = new Payment(rider, passenger, 25.0, "Credit Card");
            var payment2 = new Payment(rider2, passenger, 15.0, "Bkash");

            var paymentManager = new PaymentManager();
            paymentManager.ProcessPayment(payment1);
            paymentManager.ProcessPayment(payment2);
        }
    }

    // ========================================================================
    // DOMAIN CLASSES
    // ========================================================================

    abstract class Person
    {
        protected Person()
        {
            ID = GenerateUniqueID();
        }

        protected Person(string name, string mobileNo, string email, string currentLocation)
        {
            ID = GenerateUniqueID();
            Name = name;
            MobileNo = mobileNo;
            Email = email;
            CurrentLocation = currentLocation;
        }

        public string Name { get; protected set; }
        protected int ID { get; init; }
        protected string MobileNo { get; set; }
        protected string Email { get; set; }
        protected string CurrentLocation { get; set; }
        protected double Rating { get; set; }

        protected int GenerateUniqueID()
        {
            return new Random().Next(1000, 9999);
        }
    }

    class Rider : Person
    {
        public Rider(
            string name,
            string mobileNo,
            string email,
            string currentLocation,
            string vehicleRegistrationNo,
            string driverLicenseNo
        ) : base(name, mobileNo, email, currentLocation)
        {
            VehicleRegistrationNo = vehicleRegistrationNo;
            DriverLicenseNo = driverLicenseNo;
        }

        public string VehicleRegistrationNo { get; set; }
        public string DriverLicenseNo { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine(
                $"Rider: {Name} | ID: {ID} | Mobile: {MobileNo} | Email: {Email} | " +
                $"Location: {CurrentLocation} | Rating: {Rating} | " +
                $"Vehicle: {VehicleRegistrationNo} | License: {DriverLicenseNo}"
            );
        }
    }

    class Passenger : Person
    {
        public Passenger(
            string name,
            string mobileNo,
            string email,
            string currentLocation,
            double rating,
            string bloodGroup
        ) : base(name, mobileNo, email, currentLocation)
        {
            Rating = rating;
            BloodGroup = bloodGroup;
        }

        public string BloodGroup { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine(
                $"Passenger: {Name} | ID: {ID} | Mobile: {MobileNo} | Email: {Email} | " +
                $"Location: {CurrentLocation} | Rating: {Rating} | Blood Group: {BloodGroup}"
            );
        }
    }

    // ========================================================================
    // COMPOSITION OVER INHERITANCE
    // ========================================================================

    class Payment
    {
        public Payment(Rider rider, Passenger passenger, double amount, string paymentMethod)
        {
            Rider = rider;
            Passenger = passenger;
            Amount = amount;
            PaymentMethod = paymentMethod;
        }

        public Rider Rider { get; set; }
        public Passenger Passenger { get; set; }
        public double Amount { get; set; }
        public string PaymentMethod { get; set; }
    }

    class PaymentManager
    {
        public void ProcessPayment(Payment payment)
        {
            Console.WriteLine(
                $"Processing payment of ${payment.Amount} using {payment.PaymentMethod}"
            );
        }
    }

    // ========================================================================
    // COMPOSITION SUCCEEDS WHERE INHERITANCE FAILS
    // ========================================================================

    class Human
    {
        protected string Name;
    }

    class Teacher : Human
    {
        private readonly LateSchoolManager _lateSchoolManager = new();

        public void StayLateInSchool()
        {
            _lateSchoolManager.StaysLateInSchool();
        }
    }

    class Student : Human
    {
        protected string Roll;
    }

    class BlackStudent : Student
    {
        private readonly LateSchoolManager _lateSchoolManager = new();

        public void StayLateInSchool()
        {
            _lateSchoolManager.StaysLateInSchool();
        }
    }

    class WhiteStudent : Student
    {
        // Does not need late school behavior
    }

    class LateSchoolManager
    {
        public void StaysLateInSchool()
        {
            // Shared late-school logic
        }
    }

    // ========================================================================
    // RECORD STRUCT - VALUE BASED EQUALITY
    // ========================================================================

    record struct Cat
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
