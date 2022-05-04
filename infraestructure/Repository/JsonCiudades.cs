using Domain.Entities;
using Domain.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infraestructure.Repository
{
    public class JsonCiudades : IJsonModel
    {

        public List<string> MetodoDeserializar(string citiesJsonFromFile)
        {
            List<string> Cties = new List<string>();
            List<City> Ciudades = JsonConvert.DeserializeObject<List<City>>(citiesJsonFromFile);
            foreach (City item in Ciudades)
            {
                Cties.Add(item.city);
            }
            return Cties;
        }

        public string ObtenerCiudadesDelJson(string path)
        {
            string CitysJsonfromfile;
            using (var reader = new StreamReader(path))
            {
                CitysJsonfromfile = reader.ReadToEnd();
            }
            return CitysJsonfromfile;
        }
    }
}
