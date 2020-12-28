using Entities;
using Entities.Exceptions;
using System;

namespace Excecoes01_CSharp {
    class Program {
        static void Main(string[] args) {
            try {
                Console.Write("Room number: ");
                int number = int.Parse(Console.ReadLine());

                Console.Write("Check-in date (dd/MM/yyyy): ");
                DateTime checkin = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);


                Console.Write("Check-out date (dd/MM/yyyy): ");
                DateTime checkout = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

                Reservation reservation = new Reservation(number, checkin, checkout);

                Console.WriteLine("Reservation: " + reservation);

                Console.WriteLine("\nEnter data to update the reservation:");
                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkin = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
                Console.Write("Check-out date (dd/MM/yyyy): ");
                checkout = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

                reservation.UpdateDates(checkin, checkout);
                Console.WriteLine("Reservation: " + reservation);
            }
            catch (DomainException e) {
                Console.WriteLine("Error in reservation: " + e.Message);
            }
            catch (FormatException e) {
                Console.WriteLine("Format error: " + e.Message);
            }
            catch (Exception e) {
                Console.WriteLine("Unexpected error: " + e.Message);
            }
        }
    }
}
