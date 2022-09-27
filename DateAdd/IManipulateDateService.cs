using System;
using System.Collections.Generic;
using System.Text;

namespace DateAdd
{
    public interface IManipulateDateService
    {
        DateTime ManipulatedDate(DateTime date, int day);
    }
}
