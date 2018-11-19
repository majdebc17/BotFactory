using BotFactory.Interface;
using System;

namespace Models
{
    public class StatusChangedEventArgs: EventArgs, IStatusChangedEventArgs
    {
        public string NewStatus { get; set; }
    }
}
