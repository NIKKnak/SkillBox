using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Lists
{
    public class Worker
    {
        public string Fio { get; set; }
        public string Street { get; set; }
        public int HomeNumber { get; set; }
        public int ApartmentNumber { get; set; }
        public int PhoneNumber { get; set; }
        public int HomePhoneNumber { get; set; }

        public Worker()
        {

        }

        public Worker(string fio,string street ,int homeNumber, int apartmentNumber, int phoneNumber, int homePhoneNumber)
        {
            this.Fio = fio;
            this.Street = street;
            this.HomeNumber = homeNumber;
            this.ApartmentNumber = apartmentNumber;
            this.PhoneNumber = phoneNumber;
            this.HomePhoneNumber = homePhoneNumber;
        }

        public void Print(Worker worker)
        {
            Console.WriteLine($"Фио: {worker.Fio}" +
                $"\nУлица: {worker.Street}" +
                $"\nНомер дома: {worker.HomeNumber}" +
                $"\nНомер квартиры: {worker.ApartmentNumber}" +
                $"\nМобильный номер: {worker.PhoneNumber}" +
                $"\nДомашний дома: {worker.HomePhoneNumber}");
        }

        public void SerializeWorker(string path)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Worker));

            using (Stream stream = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                xmlSerializer.Serialize(stream, this);
            }
        }
    }
}
            