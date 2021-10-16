using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

//Nombre de la escuela => Universidad Tecnologica Metropolitana
// Asignatura => Aplicaciones Web Orientadas a Servicios
// Nombre del Maestro => Ing. Joel I. Chuc Uc
// Nombre de la actividad => Actividad 1 (Unidad II) (Trabajo individual)
// Nombre del alumno o Alumnos => SANTOS ANTONIO PECH SANTIAGO
// Cuatrimestre =>4
// Grupo => 4B
// Parcial => SEGUNDO PARCIAL

namespace QueryApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
