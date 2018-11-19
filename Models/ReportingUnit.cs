using BotFactory.Interface;
using System;

namespace Models
{
    public abstract class ReportingUnit: IReportingUnit
    {
        public event EventHandler UnitStatusChanged;
        public void OnStatusChanged(StatusChangedEventArgs statusChangedEventArgs)
        {

        }
    }
}
