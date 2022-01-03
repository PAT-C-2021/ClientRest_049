using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Net;
using Newtonsoft.Json;
using static ClientRest_20160140049_HafidzEkaPradana.Program;

namespace ClientRest_20160140049_HafidzEkaPradana
{
    class ClassData
    {
        public void getData()
        {
            var json = new WebClient().DownloadString("http://localhost:1907/Mahasiswa");
            var data = JsonConvert.DeserializeObject<List<Mahasiswa>>(json);
            foreach (var mhs in data)
            {
                Console.WriteLine("NIM : " + mhs.nim);
                Console.WriteLine("Nama : " + mhs.nama);
                Console.WriteLine("Prodi : " + mhs.prodi);
                Console.WriteLine("Angkatan : " + mhs.angkatan);
            }
            Console.ReadLine();
        }
    }
}
