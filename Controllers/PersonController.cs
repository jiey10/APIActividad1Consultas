using System.Collections;
using Microsoft.AspNetCore.Mvc;
using QueryApi.Repositories;
using QueryApi.Domain;

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

namespace Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {
        [HttpGet]
        [Route("Ejericio_1_Informacion_General")]
        public IActionResult GetAll()
        {
            var repository = new PersonRepository();
            var persons = repository.GetAll();
            return Ok(persons);
        } 

       [HttpGet]
        [Route("Ejericicio_2_Recoleccion_Datos")]
        public IActionResult GetField()
        {
            var repository = new PersonRepository();
            var persons = repository.GetField();
            return Ok(persons);
        }

        [HttpGet]
        [Route("Ejercicio_3_Obtener_Generos")]
        public IActionResult GetByGender(char gender)
        {
            var repository = new PersonRepository();
            var persons = repository.GetByGender(gender);
            return Ok(persons);
        } 

        [HttpGet]
        [Route("Ejericio_4_Rango_Edades")]
        public IActionResult GetByRangeAge(int MinEdad, int MaxEdad)
        {
            var repository = new PersonRepository();
            var persons = repository.GetByRangeAge(MinEdad, MaxEdad);
            return Ok(persons);
        }


        [HttpGet]
        [Route("Ejercicio_5_Trabajos")]
        public IActionResult GetJobs()
        {
            var repository = new PersonRepository();
            var persons = repository.GetJobs();
            return Ok(persons);
        } 

        [HttpGet]
        [Route("Ejercicio_6_Nombres_Vocales")]
        public IActionResult GetContains(string partName)
        {
            var repository = new PersonRepository();
            var persons = repository.GetContains(partName);
            return Ok(persons);
        } 

        [HttpGet]
        [Route("Ejercicio_7_Edades_Especificas")]
        public IActionResult GetByAger(int Age, int Age2, int Age3)
        {
            var repository = new PersonRepository();
            var persons = repository.GetByAger(Age, Age2, Age3);
            return Ok(persons);
        }

        [HttpGet]
        [Route("Ejercicio_8_Ordenar_Personas_Mayores")]
        public IActionResult GetByMaxAge(int Age)
        {
            var repository = new PersonRepository();
            var persons = repository.GetByMaxAge(Age);
            return Ok(persons);
        }

        
        [HttpGet]
        [Route("Ejercicio_9_Ordenar_Por_Edad")]
        public IActionResult GetPersonsOrdered(int age)
        {
            var repository = new PersonRepository();
            var persons = repository.GetPersonsOrdered(age);
            return Ok(persons);
        }
        
        [HttpGet]
        [Route("Ejercicio_10_Ordenar_Decendentemente")]
        public IActionResult GetPersonsOrderedDesc(int MinEdad, int MaxEdad)
        {
            var repository = new PersonRepository();
            var persons = repository.GetPersonsOrderedDesc(MinEdad, MaxEdad);
            return Ok(persons);
        }
        
        [HttpGet]
        [Route("Ejercicio_11_Personas_Por_Sexo")]
        public IActionResult CountPerson(char gender)
        {
            var repository = new PersonRepository();
            var persons = repository.CountPerson(gender);
            return Ok(persons);
        }
        
        [HttpGet]
        [Route("Ejercicio_12_Personas_Por_Apellido")]
        public IActionResult ExistPerson(string Apellido)
        {
            var repository = new PersonRepository();
            var persons = repository.ExistPerson(Apellido);
            return Ok(persons);
        }
       
        [HttpGet]
        [Route("Ejercicio_13_Personas_Por_Edad_Y_Trabajo")]
        public IActionResult GetPerson(string job, int Age)
        {
            var repository = new PersonRepository();
            var persons = repository.GetPerson(job, Age);
            return Ok(persons);
        }
        

        [HttpGet]
        [Route("Ejercicio_14_Personas_Por_Puesto")]
        public IActionResult TakePerson(string job, int take)
        {
            var repository = new PersonRepository();
            var persons = repository.TakePerson(job, take);
            return Ok(persons);
        }
        
        
        [HttpGet]
        [Route("Ejercicio_15_Personas_Por_Puesto_2")]
        public IActionResult SkipPerson(string job, int skip)
        {
            var repository = new PersonRepository();
            var persons = repository.SkipPerson(job, skip);
            return Ok(persons);
        }
    
        [HttpGet]
        [Route("Ejercicio_16_Personas_Por_Puesto_3")]
        public IActionResult SkipTakePerson(string job, int skip, int take)
        {
            var repository = new PersonRepository();
            var persons = repository.SkipTakePerson(job, skip, take);
            return Ok(persons);
        }

    }
}