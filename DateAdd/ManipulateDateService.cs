using System;
using System.Collections.Generic;
using System.Text;

namespace DateAdd
{
    public class ManipulateDateService: IManipulateDateService
    {
        private readonly IDateAddService _service;
        public ManipulateDateService(IDateAddService service)
        {
            _service = service;
        }

        public DateTime ManipulatedDate(DateTime Date, int day)
        {
            DateTime result = _service.AddDateToInputDate(Date, day);
            return result;
        }
    }
}
