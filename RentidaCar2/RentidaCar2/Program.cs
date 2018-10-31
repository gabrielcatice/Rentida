using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using RentidaCar2.Model;

namespace RentidaCar2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        [DllImport("kernel32.dll")]
        static extern bool AttachConsole(int dwProccessId);
        private const int ATTACH_PARENT_PROCESS = -1;

        [STAThread]
        static void Main()
        {

            AttachConsole(ATTACH_PARENT_PROCESS);

            ClientAddress address = new ClientAddress("1", ClientAddress.AddressType.Road, "aaaaa", "123", "a", "a", "a", "a", "a");
            Client client = new Client("1", "fullName", "phone", address, Client.Gender.Male, "", DateTime.Today, DateTime.Today, Client.ClientStatus.Regular);
            Console.WriteLine(client.Address.AdddressName);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Home());
        }
    }
}
