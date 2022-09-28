using System;
using Xunit;
using DateAdd;

namespace DateAddTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            DateAddService ds = new DateAddService();
            DateTime FnDate = ds.AddDateToInputDate(Convert.ToDateTime("28/09/2022"), Convert.ToInt32(1));
            DateTime MockRes = Convert.ToDateTime("29/09/2022");
            Assert.Equal(FnDate, MockRes);
        }

        [Fact]
        public void Test2()
        {
            DateAddService ds = new DateAddService();
            DateTime FnDate = ds.AddDateToInputDate(Convert.ToDateTime("28/02/2022"), Convert.ToInt32(3));
            DateTime MockRes = Convert.ToDateTime("03/03/2022");
            Assert.Equal(FnDate, MockRes);                
        }
    }
}