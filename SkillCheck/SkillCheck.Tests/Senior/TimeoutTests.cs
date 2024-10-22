using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillCheck.Tests.Senior
{
    public class TimeoutTests
    {
        /*
         * Тест на асинхронную обработку нескольких задач с таймаутом:
         */

        [Test]
        public async Task Run_tasks_with_timeout_and_return_partial_results()
        {
            var tasks = new List<Func<Task<int>>>
        {
            async () => { await Task.Delay(200); return 1; },
            async () => { await Task.Delay(500); return 2; },
            async () => { await Task.Delay(1000); return 3; }
            };

            var result = await TaskHelper.RunTasksWithTimeout(tasks, 300); // Тайм-аут 300 мс
            CollectionAssert.AreEqual(new List<int> { 1 }, result); // Ожидается только первый результат, так как второй и третий задачи превысят тайм-аут
        }
    }
}
