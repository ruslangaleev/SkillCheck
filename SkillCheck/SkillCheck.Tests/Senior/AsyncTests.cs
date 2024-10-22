using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillCheck.Tests.Senior
{
    public class AsyncTests
    {
        /*
         * Тест на обработку отмены асинхронной операции (CancellationToken):
         */

        [Test]
        public async Task Cancel_async_operation_and_throw_task_cancelled_exception()
        {
            var cancellationTokenSource = new CancellationTokenSource();
            cancellationTokenSource.CancelAfter(100); // Отмена через 100 миллисекунд

            Assert.ThrowsAsync<TaskCanceledException>(async () =>
            {
                await AsyncHelper.RunLongTask(cancellationTokenSource.Token);
            });
        }
    }
}
