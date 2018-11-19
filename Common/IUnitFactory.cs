using BotFactory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Tools;

namespace Interfaces.Common
{
    public interface IUnitFactory
    {
        int QueueCapacity { get; }
        int StorageCapacity { get; }
        int QueueFreeSlots { get; set; }
        int StorageFreeSlots { get; set; }
        List<IFactoryQueueElement> Queue { get; set; }
        List<ITestingUnit> Storage { get; set; }
        TimeSpan QueueTime { get; set; }
        Action<object, EventArgs> FactoryStatus { get; set; }

        bool AddWorkableUnitToQueue(Type item, string name, Coordinates coordinates1, Coordinates coordinates2);
    }
}
