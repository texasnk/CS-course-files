using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Async
{
    internal class AsyncExample
    {
        async Task<bool> IsLeapYear()
        {
            return await Task.FromResult<bool>(DateTime.IsLeapYear(DateTime.Now.Year));
        }

        async Task DoTask()
        {
            await Task.Delay(2000);
            FormAsyncTest.listRes1.Items.Add("Long task done.");
        }

        public async Task TaskLong()
        {
            bool leapYear = await IsLeapYear();
            FormAsyncTest.listRes1.Items.Add($"{DateTime.Now.Year} {(leapYear ? " is " : " isn't ")} a leap year!");
            await DoTask();
        }
    }
}
