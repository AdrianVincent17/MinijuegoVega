namespace Ejercicio1
{
    public class Tests
    {

        StringWriter stringWriter;

       
        [SetUp]
        public void Setup()
        {
            stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

        }

        [TearDown]
        public void cleanUp()
        {
            stringWriter.Dispose();
        }

        [Test]
        public void saludo()
        {
            Ejercicio1.saludar.hola();
            String salida= stringWriter.ToString().Trim();
            String bien = "Hola Uriel";
            Assert.AreEqual(bien,salida,"Fallo: las cadenas NO coinciden");
        }
    }
}