using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillCheck.Tests.Senior
{
    public class ThreadSafetyTests
    {
        /*
         * Тест на использование блокировки для доступа к общему ресурсу:
         */

        [Test]
        public void increment_shared_resource_safely_in_multithreaded_environment()
        {
            var sharedResource = new SharedResource();
            Parallel.For(0, 1000, _ => sharedResource.Increment());

            Assert.AreEqual(1000, sharedResource.Count);
        }
    }
}
