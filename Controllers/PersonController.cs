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
        [Route("Ejericio 1 Información de todas las personas")]
        public IActionResult GetAll()
        {
            var repository = new PersonRepository();
            var persons = repository.GetAll();
            return Ok(persons);
        } 

       [HttpGet]
        [Route("Ejericicio 2 Retorna únicamente el nombre completo de las personas, el correo y el año de nacimiento")]
        public IActionResult GetField()
        {
            var repository = new PersonRepository();
            var persons = repository.GetField();
            return Ok(persons);
        }

        [HttpGet]
        [Route("Ejercicio 3 Obtener por genero")]
        public IActionResult GetByGender(char gender)
        {
            var repository = new PersonRepository();
            var persons = repository.GetByGender(gender);
            return Ok(persons);
        } 

        [HttpGet]
        [Route("Ejericio 4 Personas cuya edad se encuentre entre los 20 y 30 años")]
        public IActionResult GetByRangeAge(int MinEdad, int MaxEdad)
        {
            var repository = new PersonRepository();
            var persons = repository.GetByRangeAge(MinEdad, MaxEdad);
            return Ok(persons);
        }


        [HttpGet]
        [Route("Ejercicio 5 Diferentes trabajos que tienen las personas")]
        public IActionResult GetJobs()
        {
            var repository = new PersonRepository();
            var persons = repository.GetJobs();
            return Ok(persons);
        } 

        [HttpGet]
        [Route("Ejercicio 6 Nombre contenga la palabra “ar”")]
        public IActionResult GetContains(string partName)
        {
            var repository = new PersonRepository();
            var persons = repository.GetContains(partName);
            return Ok(persons);
        } 

        [HttpGet]
        [Route("Ejercicio 7 Cuyas edades sean 25, 35 y 45 años")]
        public IActionResult GetByAger(int Age, int Age2, int Age3)
        {
            var repository = new PersonRepository();
            var persons = repository.GetByAger(Age, Age2, Age3);
            return Ok(persons);
        }

        [HttpGet]
        [Route("Ejercicio 8 Ordenar por edad para las personas que sean mayores a 40 años")]
        public IActionResult GetByMaxAge(int Age)
        {
            var repository = new PersonRepository();
            var persons = repository.GetByMaxAge(Age);
            return Ok(persons);
        }

        
        [HttpGet]
        [Route("Ejercicio 9 Ordenar por edad para las personas que sean mayores a 40 años")]
        public IActionResult GetPersonsOrdered(int age)
        {
            var repository = new PersonRepository();
            var persons = repository.GetPersonsOrdered(age);
            return Ok(persons);
        }
        
        [HttpGet]
        [Route("Ejercicio 10 Ordenar de manera descendente para todas las personas de género masculino y que se encuentren entre los 20 y 30 años de edad")]
        public IActionResult GetPersonsOrderedDesc(int MinEdad, int MaxEdad)
        {
            var repository = new PersonRepository();
            var persons = repository.GetPersonsOrderedDesc(MinEdad, MaxEdad);
            return Ok(persons);
        }
        
        [HttpGet]
        [Route("Ejercicio 11 retorne la cantidad de personas con género Femenino o Masculino")]
        public IActionResult CountPerson(char gender)
        {
            var repository = new PersonRepository();
            var persons = repository.CountPerson(gender);
            return Ok(persons);
        }
        
        [HttpGet]
        [Route("Ejercicio 12 Retorne si existen personas con el apellido “tal”.")]
        public IActionResult ExistPerson(string Apellido)
        {
            var repository = new PersonRepository();
            var persons = repository.ExistPerson(Apellido);
            return Ok(persons);
        }
       
        [HttpGet]
        [Route("Ejercicio 13 Retorne únicamente una persona cuyo trabajo sea “Software Consultant” y tenga 25 años de edad")]
        public IActionResult GetPerson(string job, int Age)
        {
            var repository = new PersonRepository();
            var persons = repository.GetPerson(job, Age);
            return Ok(persons);
        }
        

        [HttpGet]
        [Route("Ejercicio 14 Retorne la información de las primeras 3 personas cuyo puesto de trabajo sea “Tal”")]
        public IActionResult TakePerson(string job)
        {
            var repository = new PersonRepository();
            var persons = repository.TakePerson(job);
            return Ok(persons);
        }
        
        
        [HttpGet]
        [Route("Ejercicio 15 Retorne la información de las primeras 3 personas cuyo puesto de trabajo sea “Tal”")]
        public IActionResult SkipPerson(string job)
        {
            var repository = new PersonRepository();
            var persons = repository.SkipPerson(job);
            return Ok(persons);
        }
    
        [HttpGet]
        [Route("Ejercicio 16 Omita la información de las primeras 3 personas y que retorne la información de las siguientes 3 personas cuyo puesto de trabajo sea “Tal”")]
        public IActionResult SkipTakePerson(string job)
        {
            var repository = new PersonRepository();
            var persons = repository.SkipTakePerson(job);
            return Ok(persons);
        }

    }
}