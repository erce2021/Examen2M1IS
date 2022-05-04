using AppCore;
using Domain.Entities;
using Domain.Interfaces;
using infraestructure.OpenWeatherCarp;
using infraestructure.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppExamen
{
    public partial class Form1 : Form
    {
        public static string path = "C:\\Users\\Owner\\source\\repos\\CopyOfWearherConcurrencyApp\\CopyOfWearherConcurrencyApp\\Resources\\Ciudades.json";
        public List<string> departamentos;
        public JsonCiudades jsonCities = new JsonCiudades();
        public HttpAbrirClima httpOpenWeatherClient;
        public OpenWeather openWeather;
        public AppSettings appSetting;
        public String nmc;
        public IAbrirClima OpenWeatherServices;
        public Form1( IAbrirClima OpenWeatherServices)
        {
            this.OpenWeatherServices = OpenWeatherServices;
            httpOpenWeatherClient = new HttpAbrirClima();
            InitializeComponent();
        }
        public void agregarItems()
        {
            for (int i = 0; i < departamentos.Count; i++)
            {
                cmb.Items.Add(departamentos[i]);
            }
        }
    }
}
