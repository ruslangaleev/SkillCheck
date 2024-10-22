using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillCheck.Tests.Senior
{
    public class SolidTests
    {
        /*
         * Тест на соблюдение принципа SOLID (Принцип разделения интерфейсов):
         */

        [Test]
        public void process_data_using_interface_and_returns_correct_result()
        {
            IDataProcessor processor = new JsonDataProcessor();
            var result = processor.ProcessData("{ \"name\": \"test\" }");
            Assert.AreEqual("Processed JSON", result);

            processor = new XmlDataProcessor();
            result = processor.ProcessData("<name>test</name>");
            Assert.AreEqual("Processed XML", result);
        }
    }
}
