using System.Runtime.ConstrainedExecution;

namespace Tarea4
{
    public class Tests
    {
        private StringWriter stringWriter;
        [SetUp]
        public void Setup()
        {
            stringWriter = new StringWriter();  
            Console.SetOut(stringWriter);
        }
        [TearDown]
        public void TearDown()
        {
            stringWriter.Dispose();

        }
        [Test]
        public void PruebaDivisionPorCero()
        {
            double resultado = Tarea4.Division.Dividir(10, 0);
            string salida = stringWriter.ToString().Trim();

            Assert.AreEqual(0,resultado,"El resultado debe ser 0 cuando se intenta dividir entre cero");
            Assert.AreEqual("No se puede dividir entre cero", salida, "Debe imprimirse el mensaje correcto cuando b, es 0");
        }

        [Test]
        public void PruebaDivisionValida()
        {
            double resultado = Tarea4.Division.Dividir(10, 2);
            Assert.AreEqual(5, resultado, "10 dividido por 2 debe ser 5.");
        }
    }
}