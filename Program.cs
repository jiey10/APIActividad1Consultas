using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

/*
Universidad Tecnologica Metropolitana
Asignatura: Aplicaciones Web Orientadas a Servicios
Maestro: Chuc Uc Joel Ivan
Actividad: Consultas
Alumno: Estrella Yah Jesus Ivan
4to Cuatrimestre
Grupo: 4B
Parcial: 2do
*/

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
