using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace SkillCheck.Tests.Senior
{
    public class TransactionTests
    {
        /*
         * Тест на правильную обработку транзакций в базе данных:
         */

        //[Test]
        //public void transaction_should_be_rolled_back_on_error()
        //{
        //    using (var transaction = new TransactionScope())
        //    {
        //        DatabaseHelper.InsertData("ValidData");

        //        Assert.Throws<Exception>(() => DatabaseHelper.InsertData("InvalidData")); // Ошибка при вставке

        //        transaction.Complete();
        //    }

        //    Assert.IsFalse(DatabaseHelper.IsDataInserted("ValidData")); // Данные должны быть откатаны
        //}
    }
}
