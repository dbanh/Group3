using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManagementSystem
{
    public enum MemberStatus
    {
        Invalid = 0,
        Valid = 1, 
    }

    public struct ClientInfo
    {
        public string Name;
        public MemberStatus Status;
        public List<DateTime> Appointments;

        public ClientInfo(string name, MemberStatus status)
        {
            Name = name;
            Status = status;
            Appointments = new List<DateTime>();
        }
    }

    public struct ProviderInfo
    {
        public string Name;
        public List<DateTime> Appointments;

        public ProviderInfo(string name)
        {
            Name = name;
            Appointments = new List<DateTime>();
        }
    }

    public struct AppointmentInfo
    {
        public int ClientNumber;
        public int ProviderNumber;
        public int ServiceId;
        public int Price;
        public string Comments;
    }

    public static class Database
    {
        public static Dictionary<int, ClientInfo> ClientRecords = new Dictionary<int, ClientInfo>();
        public static Dictionary<int, ProviderInfo> ProviderRecords = new Dictionary<int, ProviderInfo>();
        public static Dictionary<System.DateTime, AppointmentInfo> AppointmentRecords = new Dictionary<DateTime, AppointmentInfo>();

        public static void Initialize()
        {
            try
            {
                // Read information from files into the dictionary objects

                // Example for adding a client record and an appointment record:
                /*
                ClientInfo clientInfo = new ClientInfo("Sophia Weeks", MemberStatus.Valid);
                ClientRecords.Add(1, clientInfo);

                AppointmentInfo apptInfo = new AppointmentInfo();
                apptInfo.ClientNumber = 1;
                apptInfo.ProviderNumber = 0;
                apptInfo.ServiceId = 0;
                apptInfo.Price = 0;
                apptInfo.Comments = "example";

                DateTime appointmentTime = DateTime.Now;
                AppointmentRecords.Add(appointmentTime, apptInfo);
                ClientRecords[1].Appointments.Add(appointmentTime);
                */

            }
            catch
            {
                Console.WriteLine("Error initializing database.");
                Console.ReadLine();
                return;
            }
        }

        public static void WriteChangesToFile()
        {
            try
            {

            }
            catch
            {
                Console.WriteLine("Error writing database to disk.");
                Console.ReadLine();
                return;
            }
        }
    }
}
