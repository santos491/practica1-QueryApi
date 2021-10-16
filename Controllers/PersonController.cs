using System.Collections;
using Microsoft.AspNetCore.Mvc;
using QueryApi.Repositories;
using QueryApi.Domain;

namespace Controllers
{
    //Este GET obtiene todas las personas
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public IActionResult GetAll()
        {
            var repository = new PersonRepository();
            var persons = repository.GetAll();
            return Ok(persons);
        } 
    }
        //Este GET obtiene Nombre, Apellido,Correo y Edad de las personas
    [ApiController]
    [Route("api/[controller]")]
    public class DatosController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public IActionResult GetFields()
        {
            var repository = new PersonRepository();
            var Datos = repository.GetFields();
            return Ok(Datos);
        }
    } 
        //Este GET obtiene personas cuyo genero sea Femenino
    [ApiController]
    [Route("api/[controller]")]
    public class GeneroController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public IActionResult GetByGender()
        {
            var repository = new PersonRepository();
            var Genero = repository.GetByGender();
            return Ok(Genero);
        }
    } 
    //Este Get Obtiene personas cuya edad se encuentre entre los 20 y 30 años
    [ApiController]
    [Route("api/[controller]")]
    public class RangoEdadController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public IActionResult GetByRangeAge()
        {
            var repository = new PersonRepository();
            var RangoEdad = repository.GetByRangeAge();
            return Ok(RangoEdad);
        }
    } 
    //Este Get Obtiene diferentes trabajos que tienen las personas.
    [ApiController]
    [Route("api/[controller]")]
    public class TrabajosController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public IActionResult GetDistinct()
        {
            var repository = new PersonRepository();
            var Trabajos = repository.GetDistinct();
            return Ok(Trabajos);
        }
    } 
    //Este Get Obtiene personas cuyo nombre contenga la palabra “ar”
    [ApiController]
    [Route("api/[controller]")]
    public class PalabraARController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public IActionResult GetContains()
        {
            var repository = new PersonRepository();
            var PalabraAR = repository.GetContains();
            return Ok(PalabraAR);
        }
    } 
    // Este Get Obtiene personas cuyas edades sean 25, 35 y 45 años
    [ApiController]
    [Route("api/[controller]")]
    public class EdadesController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public IActionResult GetByAges()
        {
            var repository = new PersonRepository();
            var Edades = repository.GetByAges();
            return Ok(Edades);
        }
    }
    //Este Get Obtiene edad para las personas que sean mayores a 40 años 
    [ApiController]
    [Route("api/[controller]")]
    public class EdadMayorController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public IActionResult MayorAñosPerson()
        {
            var repository = new PersonRepository();
            var Edades = repository.MayorAñosPerson();
            return Ok(Edades);
        }
    }
    //Este Get Obtiene Escribe un método que retorne la información ordenas por edad para las personas que sean mayores a 40 años
    [ApiController]
    [Route("api/[controller]")]
    public class Mayor40añosController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public IActionResult MayorAñosPerson()
        {
            var repository = new PersonRepository();
            var Mayor40años = repository.MayorAñosPerson();
            return Ok(Mayor40años);
        }
    }
    //Este Get Obtiene  cantidad de personas con género femenino.
    [ApiController]
    [Route("api/[controller]")]
    public class GeneroFemeninoController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public IActionResult CountPerson()
        {
            var repository = new PersonRepository();
            var GeneroFemenino = repository.CountPerson();
            return Ok(GeneroFemenino);
        }
    }
    //Este Get Obtiene existen personas con el apellido “Shemelt”.
    [ApiController]
    [Route("api/[controller]")]
    public class ExistApellidoController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public IActionResult ExistPerson()
        {
            var repository = new PersonRepository();
            var ExistApellido = repository.ExistPerson();
            return Ok(ExistApellido);
        }
    }
    //Este Get Obtiene únicamente una persona cuyo trabajo sea “Software Consultant” y tenga 25 años de edad
    [ApiController]
    [Route("api/[controller]")]
    public class JobAgeController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public IActionResult GetPersonJob()
        {
            var repository = new PersonRepository();
            var JobAge = repository.GetPersonJob();
            return Ok(JobAge);
        }
    }
    //Este Get Obtiene primeras 3 personas cuyo puesto de trabajo sea “Software Consultant”
    [ApiController]
    [Route("api/[controller]")]
    public class PuestoTrabajoController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public IActionResult TakeLastPerson()
        {
            var repository = new PersonRepository();
            var PuestoTrabajo = repository.TakeLastPerson();
            return Ok(PuestoTrabajo);
        }
    }
    //Este Get OMITA primeras 3 personas cuyo puesto de trabajo sea “Software Consultant”
    [ApiController]
    [Route("api/[controller]")]
    public class OmitePuestoController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public IActionResult SkipPerson()
        {
            var repository = new PersonRepository();
            var OmitePuesto = repository.SkipPerson();
            return Ok(OmitePuesto);
        }
    }
    //omita la información de las primeras 3 personas y que retorne la
    //información de las siguientes 3 personas cuyo puesto de trabajo sea “Software Consultant”
    [ApiController]
    [Route("api/[controller]")]
    public class OmitarRetomarController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public IActionResult SkipTakePerson()
        {
            var repository = new PersonRepository();
            var OmitirRetomar= repository.SkipTakePerson();
            return Ok(OmitirRetomar);
        }
    }

}
