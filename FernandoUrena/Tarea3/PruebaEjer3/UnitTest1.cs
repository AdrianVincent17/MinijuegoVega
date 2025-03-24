using System.Text;

namespace Tarea3
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

        public void Closing()
        {
            stringWriter.Dispose();
        }

        [Test]
        public void PruebaTablaMultiplicarCorrecta()
        {
            //Ejecutamos la funcion que imprime las tablas de multiplicar
            Tarea3.Program.ImprimirTablaMultiplicar();

            //Capturamos la salida
            String salida=stringWriter.ToString().Trim();

            //Construimos la salida esperada
            StringBuilder salidaEsperada = new StringBuilder();

            for (int i = 1; i <= 10; i++)
            {
                salidaEsperada.AppendLine($"Tabla del {i}:");
                for(int j = 0; j <= 10; j++)
                {
                    salidaEsperada.AppendLine($"{i} x {j} = {i * j}");
                    
                }
                
            }

            //comparamos la salida capturada con la esperada
            Assert.AreEqual(salidaEsperada.ToString().Trim(), salida," La tabla de multiplicar no se imprimio correctamente ");

        }
        public void Test2()
        {
            Assert.Pass();
        }
        public void Test3()
        {
            Assert.Pass();
        }

        [Test]
        public void Test4()
        {
            
        }
    }
}