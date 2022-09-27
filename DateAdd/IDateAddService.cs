using System;
using System.Collections.Generic;
using System.Text;

namespace DateAdd
{
    public interface IDateAddService
    {
        DateTime AddDateToInputDate(DateTime inputDate, int AddDays);
    }
    
}
