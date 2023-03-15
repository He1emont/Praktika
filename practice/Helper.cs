using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class Helper
    {
        private static AgencyEntities agencyEntities;
        public static AgencyEntities GetContext()
        {
            if (agencyEntities == null)
            {
                agencyEntities = new AgencyEntities();
            }
            return agencyEntities;
        }
        public string AddClient(Client client)
        {
            try
            {
                agencyEntities.Client.Add(client);
                agencyEntities.SaveChanges();
                return "Клиент добавлен";
            }
            catch(Exception ex)
            {
                return "Клиент не добавлен. Ошибка: " + ex.Message;
            }
        }
        public string UpdateClient(int id_clienta, string Familiy, string Name, string Otchestvo, Byte ID_Pol, Byte Vozrast, Int16 Ves, string Znak_zodiaka)
        {
            try
            {
                Client client = agencyEntities.Client.Where(x => x.ID_clienta == id_clienta).FirstOrDefault();
                client.Familiy = Familiy;
                client.Name = Name;
                client.Otchestvo = Otchestvo;
                client.ID_Pol = ID_Pol;
                client.Vozrast = Vozrast;
                client.Ves = Ves;
                client.Znak_zodiaka = Znak_zodiaka;
                agencyEntities.SaveChanges();
                return "Клиент изменен";
            }
            catch (Exception ex)
            {
                return "Клиент не изменен. Ошибка: " + ex.Message;
            }
        }
        public string RemoveClient(int id)
        {
            try
            {
                Client client = agencyEntities.Client.Find(id);
                agencyEntities.Client.Remove(client);
                agencyEntities.SaveChanges();
                return "Клиент удален.";
            }catch(Exception ex)
            {
                return "Клиент не удален. Ошибка: " + ex.Message;
            }
}
    }
}
