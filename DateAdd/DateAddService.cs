using System;
using System.Collections.Generic;
using System.Text;

namespace DateAdd
{    public class DateAddService: IDateAddService
    {
        public DateTime AddDateToInputDate(DateTime date, int day)
        {
            try {

                //string dt = Convert.ToString(date);
                //string[] dtarr = dt.Split("-");
                //int iday = Convert.ToInt32(dtarr[0]);
                //int imnth = Convert.ToInt32(dtarr[1]);
                //int iyr = Convert.ToInt32(dtarr[2]);

                int iday = date.Day;
                int imnth = date.Month;
                int iyr = date.Year;
                int x = day;

                var result = addDays(iday, imnth, iyr, x);
                // Find values of day and month from
                // offset of result year.
                int m2, d2;

                // Return if year is leap year or not.
                bool isLeap(int y)
                {
                    if (y % 100 != 0 && y % 4 == 0 || y % 400 == 0)
                        return true;

                    return false;
                }

                // Given a date, returns number of days elapsed
                // from the beginning of the current year (1st
                // jan).
                int offsetDays(int d, int m, int y)
                {
                    int offset = d;

                    if (m - 1 == 11)
                        offset += 335;
                    if (m - 1 == 10)
                        offset += 304;
                    if (m - 1 == 9)
                        offset += 273;
                    if (m - 1 == 8)
                        offset += 243;
                    if (m - 1 == 7)
                        offset += 212;
                    if (m - 1 == 6)
                        offset += 181;
                    if (m - 1 == 5)
                        offset += 151;
                    if (m - 1 == 4)
                        offset += 120;
                    if (m - 1 == 3)
                        offset += 90;
                    if (m - 1 == 2)
                        offset += 59;
                    if (m - 1 == 1)
                        offset += 31;

                    if (isLeap(y) && m > 2)
                        offset += 1;

                    return offset;
                }

                // Given a year and days elapsed in it, finds
                // date by storing results in d and m.
                void revoffsetDays(int offset, int y)
                {
                    int[] month = { 0, 31, 28, 31, 30, 31, 30,
                    31, 31, 30, 31, 30, 31 };

                    if (isLeap(y))
                        month[2] = 29;
                    int i;
                    for (i = 1; i <= 12; i++)
                    {
                        if (offset <= month[i])
                            break;
                        offset = offset - month[i];
                    }

                    d2 = offset;
                    m2 = i;
                }

                // Add x days to the given date.
                string addDays(int d1, int m1, int y1, int x)
                {
                    int offset1 = offsetDays(d1, m1, y1);
                    int remDays = isLeap(y1) ? (366 - offset1) : (365 - offset1);

                    // y2 is going to store result year and
                    // offset2 is going to store offset days
                    // in result year.
                    int y2, offset2 = 0;
                    if (x <= remDays)
                    {
                        y2 = y1;
                        offset2 = offset1 + x;
                    }

                    else
                    {
                        // x may store thousands of days.
                        // We find correct year and offset
                        // in the year.
                        x -= remDays;
                        y2 = y1 + 1;
                        int y2days = isLeap(y2) ? 366 : 365;
                        while (x >= y2days)
                        {
                            x -= y2days;
                            y2++;
                            y2days = isLeap(y2) ? 366 : 365;
                        }
                        offset2 = x;
                    }
                    revoffsetDays(offset2, y2);

                    return Convert.ToString(d2) + "-" + Convert.ToString(m2) + "-" + Convert.ToString(y2);
                }

                return Convert.ToDateTime(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }
    }
}
