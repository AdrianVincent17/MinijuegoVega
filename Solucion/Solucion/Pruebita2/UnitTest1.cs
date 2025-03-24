namespace Ejercicio2
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
        public void TestSumaBien()
        {
            int result=Ejercicio2.calculos.numeritos(2, 2);
            Assert.AreEqual(4, result, "El primer numero debe ser mayor o igual al segundo");
        }

        [Test]
        public void TestSumaMal()
        {
            int result = Ejercicio2.calculos.numeritos(1, 2);
            String salida= stringWriter.ToString().Trim();
            Assert.AreEqual("Error", salida, "El primer parametro es mayor o igual que el segundo numero ");
            Assert.AreEqual(0, result);
        }
    }
}