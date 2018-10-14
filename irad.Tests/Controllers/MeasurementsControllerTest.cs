using Microsoft.VisualStudio.TestTools.UnitTesting;
using irad.Controllers;
using irad.Models;

namespace irad.Tests.Controllers
{
    [TestClass]
    public class MeasurementsControllerTest
    {
        //[TestMethod]
        //public void Get()
        //{
        //    // Disponer
        //    MeasurementsController controller = new MeasurementsController();

        //    // Actuar
        //    IEnumerable<string> result = controller.Get();

        //    // Declarar
        //    Assert.IsNotNull(result);
        //    Assert.AreEqual(2, result.Count());
        //    Assert.AreEqual("value1", result.ElementAt(0));
        //    Assert.AreEqual("value2", result.ElementAt(1));
        //}

        //[TestMethod]
        //public void GetById()
        //{
        //    // Disponer
        //    MeasurementsController controller = new MeasurementsController();

        //    // Actuar
        //    string result = controller.Get(5);

        //    // Declarar
        //    Assert.AreEqual("value", result);
        //}

        [TestMethod]
        public void Post()
        {
            // Disponer
            MeasurementsController controller = new MeasurementsController();
            Measurements value = new Measurements(){ Value=9.0, Device="dronprueba" };

            // Actuar
            controller.Post(value);

            // Declarar
            
        }

        //[TestMethod]
        //public void Put()
        //{
        //    // Disponer
        //    MeasurementsController controller = new MeasurementsController();

        //    // Actuar
        //    controller.Put(5, "value");

        //    // Declarar
        //}

        //[TestMethod]
        //public void Delete()
        //{
        //    // Disponer
        //    MeasurementsController controller = new MeasurementsController();

        //    // Actuar
        //    controller.Delete(5);

        //    // Declarar
        //}
    }
}
