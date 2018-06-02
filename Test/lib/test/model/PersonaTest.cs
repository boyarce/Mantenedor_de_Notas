using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MantenedorDeNotas.lib.model;

namespace Test
{
    [TestClass]
    public class PersonaTest
    {
        [TestMethod]
        public void TestCreatePersona()
        {
            //Creamos objeto persona
            Persona persona = new Persona();
            //Verificamos que se construyo un objeto
            Assert.IsNotNull(persona);

            //Verificar modificación id
            persona.Id = 1;
            Assert.AreEqual(1, persona.Id);
            //Verificar que no se realiza modificación id por
            //dato invalido
            persona.Id = -1;
            Assert.AreEqual(1, persona.Id);

            //Verificar que se modifica nombre con dato correcto
            persona.Nombres = "Juan Pedro";
            Assert.AreEqual("Juan Pedro", persona.Nombres);

            //Verificar que no se modifica nombre con dato incorrecto
            persona.Nombres = "J";
            Assert.AreEqual("Juan Pedro", persona.Nombres);

            //Verificar que se modifica apellido paterno con dato correcto
            persona.ApellidoPaterno = "Barrera";
            Assert.AreEqual("Barrera", persona.ApellidoPaterno);

            //Verificar que no se modifica apellido paterno con dato incorrecto
            persona.ApellidoPaterno = "B";
            Assert.AreEqual("Barrera", persona.ApellidoPaterno);

            //Verificar que se modifica apellido materno con dato correcto
            persona.ApellidoMaterno = "Ramirez";
            Assert.AreEqual("Ramirez", persona.ApellidoMaterno);

            //Verificar que no se modifica apellido materno con dato incorrecto
            persona.ApellidoMaterno = "R";
            Assert.AreEqual("Ramirez", persona.ApellidoMaterno);

            //Verificar que se modifica apellido materno con dato correcto
            persona.CorreoElectronico = "juan.barrera.ramirez@duoc.cl";
            Assert.AreEqual("juan.barrera.ramirez@duoc.cl", persona.CorreoElectronico);

            //Verificar que no se modifica apellido materno con dato incorrecto
            persona.CorreoElectronico = "J";
            Assert.AreEqual("juan.barrera.ramirez@duoc.cl", persona.CorreoElectronico);
        }
    }
}
