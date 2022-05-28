using System;
using System.Collections.Generic;
using FreddysDailyPlanner.Models;

namespace FreddysDailyPlanner.Services.DateService
{
    public interface IDateService
    {
        WeekModel GetWeek(DateTime date);

        List<DayModel> GetDayList(DateTime firstDayInWeek, DateTime lastDayInWeek);
    }
}
