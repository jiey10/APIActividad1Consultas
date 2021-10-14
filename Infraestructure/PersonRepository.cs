using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.IO;
using QueryApi.Domain;
using System.Threading.Tasks;

namespace QueryApi.Repositories
{
    public class PersonRepository
    {
        List<Person> _persons;

        public PersonRepository()
        {
            var fileName = "dummy.data.queries.json";
            if(File.Exists(fileName))
            {
                var json = File.ReadAllText(fileName);
                _persons = JsonSerializer.Deserialize<IEnumerable<Person>>(json).ToList();
            }
        }

        //Ejercicio 1
        // retornar todos los valores
        public IEnumerable<Person> GetAll()
        {
            var query = _persons.Select(person => person);
            return query;
        }

        //Ejercicio 2
        // retornar campos especificos
        public IEnumerable<Object> GetField(){
            var query = _persons.Select(person => new {
                NombreCompleto = $"{person.FirstName} {person.LastName}",
                AnioNacimiento = DateTime.Now.AddYears(person.Age *-1).Year,
                CorreoElectronico = person.Email
            });
            return query;
        }

        //Ejercicio 3
        // retornar elementos que sean iguales
        public IEnumerable<Person> GetByGender(char gender){
            //var gender = 'M';
            var query = _persons.Where(person => person.Gender == gender);
            return query;
        }
        
        //Ejercicio 8
        public IEnumerable<Person> GetByMaxAge(int Age){
            //var age = 30;
            var query = _persons.Where(person => person.Age <= Age);
            return query;
        }

        /*
        // Retornar elementos que sean diferentes
        public IEnumerable<Person> GetDiference(){
            var job = "Civil Engineer";
            var query = _persons.Where(person => person.Job != job);
            return query;
        }*/
        
        //Ejercicio 5
        public IEnumerable<string> GetJobs(){
            var query = _persons.Select(person => person.Job).Distinct();
            return query;
        }

        //Ejercicio 6
        // retornar valores que contengan
        public IEnumerable<Person> GetContains(string partName){
            //var partName = "ar";
            var query = _persons.Where(person => person.FirstName.Contains(partName));
            return query; //no me importa donde lo contenga
        }

        //Ejercicio 7
        public IEnumerable<Person> GetByAger(int Age, int Age2, int Age3){
            var ages = new List<int>{Age, Age2, Age3};
            var query = _persons.Where(person => ages.Contains(person.Age));
            return query; 
        }

        //Ejercicio 4
        // retornar valores entre un rango
        public IEnumerable<Person> GetByRangeAge(int MinEdad, int MaxEdad){
            //var minage = 30;
            //var maxage = 40;
            var query = _persons.Where(person => person.Age >= MinEdad && person.Age <= MaxEdad);
            return query;
        }

        //Ejercicio 9
        // retornar elementos ordenados
        public IEnumerable<Person> GetPersonsOrdered(int age){
            //var job = "Payment Adjustment Coordinator";
            var query = _persons.Where(person => person.Age > age)
                        .OrderBy(person => person.Age);
            return query;
        }

        //Ejercicio 10
        public IEnumerable<Person> GetPersonsOrderedDesc(int MinEdad, int MaxEdad){
            //var job = "Paralegal";
            var gender = 'M';
            var query = _persons.Where(person => person.Gender == gender && person.Age >= MinEdad && person.Age <= MaxEdad)
                        .OrderByDescending(person => person.FirstName);
            return query;
        }

        /*
        // retorno cantidad de elementos
        public int CountPeople(){
            var age = 37;
            var query = _persons.Count(person => person.Age == age);
            return query;
        }*/
        
        //Ejercicio 11
        public int CountPerson(char gender)
        {
            //var gender = 'F';
            var query = _persons.Count(person => person.Gender == gender);
            return query;
        }

        //Ejercicio 12
        // Evalua si un elemento existe
        public bool ExistPerson(string Apellido)
        {
            //var lastName = "Tuffell";
            var query = _persons.Exists(person => person.LastName == Apellido);
            return query;
        }

        /*
        public bool AnyPerson()
        {
            var lastName = "Mullett";
            var query = _persons.Any(person => person.LastName == lastName);
            return query;
        }*/

        //Ejercicio 13
        // retornar solo un elemento
        public Person GetPerson(string job, int Age)
        {
            //var id = 340;
            var query = _persons.FirstOrDefault(person => person.Job == job && person.Age == Age);
            return query;
        }

        /*
        public Person GetPerson2()
        {
            var generador = new Random(DateTime.Now.Millisecond);
            var id  = generador.Next(1000); 
            var query = _persons.FirstOrDefault(person => person.Id == id);
            return query;

        }
        */

        //Ejercicio 14
        // retornar solamente unos elementos
        public IEnumerable<Person> TakePerson(string job)
        {
            //var job = "Geological Engineer";
            var take = 3;
            var query = _persons.Where(person => person.Job == job).Take(take);
            return query;
        }

        /*
        public IEnumerable<Person> TakeLastPerson()
        {
            var job = "Geological Engineer";
            var take = 3;
            var query = _persons.Where(person => person.Job == job).TakeLast(take);
            return query;
        }
        */

        //Ejercicio 15
        // retornar elementos saltando posición
        public IEnumerable<Person> SkipPerson(string job)
        {
            //var job = "Professor";
            var skip = 3;
            var query = _persons.Where(person => person.Job == job).Skip(skip);
            return query;
        }

        //Ejercicio 16
        public IEnumerable<Person> SkipTakePerson(string job)
        {
            //var job = "Professor";
            var skip = 3;
            var take = 3;
            var query = _persons.Where(person => person.Job == job).Skip(skip).Take(take);
            return query;
        }

    }
}