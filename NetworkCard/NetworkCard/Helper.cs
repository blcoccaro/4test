using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace NetworkCard
{
    public class Helper
    {
        public static System.Collections.Generic.List<String> GetAllNetworkInterfaces()
        {
            List<String> values = new List<String>();
            foreach (var nic in GetAllNetworkInterfacesFull())
            {
                values.Add(nic.Name);
            }
            return values;
        }
        public enum DoEnum
        {
            None,
            Enable,
            Disable,
        }
        public static void EnableDisable(string id)
        {
            DoEnum whatdo = DoEnum.None;


            System.Management.SelectQuery wmiQuery = new System.Management.SelectQuery("SELECT * FROM Win32_NetworkAdapter WHERE NetConnectionId != NULL");
            System.Management.ManagementObjectSearcher searchProcedure = new System.Management.ManagementObjectSearcher(wmiQuery);
            foreach (System.Management.ManagementObject item in searchProcedure.Get())
            {

                var aux = ((string)item["NetConnectionId"]);

                if (aux == id)
                {
                    var status = ((string)item["Status"]);
                    var NetConnectionStatus = int.Parse(item["NetConnectionStatus"].ToString());
                    //var NetEnabled = (bool)item["NetEnabled"];
                    if (NetConnectionStatus != 0) { whatdo = DoEnum.Disable; }
                    else { whatdo = DoEnum.Enable; }

                    switch (whatdo)
                    {
                        case DoEnum.Enable:
                            item.InvokeMethod("Enable", null);
                            break;
                        case DoEnum.Disable:
                            item.InvokeMethod("Disable", null);
                            break;
                    }
                }
            }
        }

        public static System.Collections.Generic.List<GridHelper> GetAllNetworkInterfacesFullDisabled()
        {
            List<GridHelper> values = new List<GridHelper>();
            System.Management.SelectQuery wmiQuery = new System.Management.SelectQuery("SELECT * FROM Win32_NetworkAdapter WHERE NetConnectionId != NULL");
            System.Management.ManagementObjectSearcher searchProcedure = new System.Management.ManagementObjectSearcher(wmiQuery);
            foreach (System.Management.ManagementObject item in searchProcedure.Get())
            {
                var aux = ((string)item["NetConnectionId"]);
                var status = ((string)item["Status"]);
                var NetConnectionStatus = int.Parse(item["NetConnectionStatus"].ToString());
                var NetEnabled = (bool)item["NetEnabled"];
                if (NetConnectionStatus == 0)
                {
                    values.Add(new GridHelper()
                    {
                        Name = aux,
                        Enabled = false,
                    });
                }
            }
            return values;
        }
        public static System.Collections.Generic.List<GridHelper> GetAllNetworkInterfacesFull()
        {
            List<GridHelper> values = new List<GridHelper>();
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                var ip = nic.GetIPProperties().UnicastAddresses?.FirstOrDefault(o => o.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)?.Address?.ToString();

                values.Add(new GridHelper()
                {
                    Description = nic.Description,
                    Enabled = true,
                    IP = ip,
                    IsReceiveOnly = nic.IsReceiveOnly,
                    Name = nic.Name,
                    NetworkInterfaceType = nic.NetworkInterfaceType.ToString(),
                    OperationStatus = nic.OperationalStatus.ToString(),
                });
            }
            values.AddRange(GetAllNetworkInterfacesFullDisabled());
            return values;
        }
    }

    public class GridHelper
    {
        public string Name { get; set; }
        public bool Enabled { get; set; }
        public bool IsConnected { get; set; }
        public string Description { get; set; }
        public string IP { get; set; }
        public string OperationStatus { get; set; }
        public bool IsReceiveOnly { get; set; }
        public string NetworkInterfaceType { get; set; }


    }
}
