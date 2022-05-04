using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infraestructure.Repository
{
  
        public class RAFOpenWeather : IAbrirClima
        {
            public const int SIZE = 200;
            RandomAccessFile context;

            public RAFOpenWeather()
            {
                context = new RandomAccessFile("Ciudades", SIZE);
            }

            public void Add(OpenWeather t)
            {
                try
                {
                    context.Create<OpenWeather>(t);
                }
                catch (Exception)
                {
                    throw;
                }
            }

            public void Delete(OpenWeather t)
            {
                try
                {
                    context.Delete<OpenWeather>(t);
                }
                catch (Exception)
                {
                    throw;
                }
            }

            public OpenWeather GetById(int id)
            {
                try
                {
                    return context.Get<OpenWeather>(id);
                }
                catch (Exception)
                {
                    throw;
                }
            }

            public List<OpenWeather> Read()
            {
                try
                {
                    return context.GetAll<OpenWeather>();
                }
                catch (Exception)
                {
                    throw;
                }
            }

            public void Update(OpenWeather t)
            {
                try
                {
                    context.Update<OpenWeather>(t);
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
    }


