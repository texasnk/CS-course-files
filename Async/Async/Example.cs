using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Async
{
    internal class Example
    {

        bool IsLeapYear()
        {
            return DateTime.IsLeapYear(DateTime.Now.Year);
        }

        void DoTask()
        {
            Task.Delay(2000);
            FormAsyncTest.listRes1.Items.Add("Long task done.");
        }

        public void TaskLong()
        {
            bool leapYear = IsLeapYear();
            FormAsyncTest.listRes1.Items.Add($"{DateTime.Now.Year} {(leapYear ? " is " : " isn't ")} a leap year!");
            DoTask();
        }

    }
}
