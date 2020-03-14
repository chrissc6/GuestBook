using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuestBookLibrary.Models;

namespace ConsoleUI
{
    class Program
    {
        private static List<GuestModel> guests = new List<GuestModel>();

        static void Main(string[] args)
        {
            GetGuestInfo();
            PrintGuestInfo();         
        }

        private static void GetGuestInfo()
        {
            string moreGuestComing = "";
            do
            {
                GuestModel guest = new GuestModel();
                
                guest.FirstName = GetInfo("What is your first name?: ");
                guest.LastName = GetInfo("What is your last name?: ");
                guest.MessageToHost = GetInfo("What message would you like to tell your host?: ");
                moreGuestComing = GetInfo("Are more guest coming (yes/no)?: ");

                guests.Add(guest);

                Console.Clear();

            } while (moreGuestComing.ToLower() != "no");
        }

        private static void PrintGuestInfo()
        {
            foreach (GuestModel g in guests)
            {
                Console.WriteLine(g.GuestInfo);
            }
            Console.ReadLine();
        }

        private static string GetInfo(string m)
        {
            Console.Write(m);
            string output = Console.ReadLine();
            return output;
        }
    }
}
