using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IJsonModel
    {
        string ObtenerCiudadesDelJson(string path);
        List<string> MetodoDeserializar(string citiesJsonFromFile);
    }
}
