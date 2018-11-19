using BotFactory.Interface;
using Common.Tools;
using Interfaces.Common;
using System;
using System.Collections.Generic;

namespace Factories
{
    public class UnitFactory : IUnitFactory
    {
        public int QueueCapacity { get; }
        public int StorageCapacity { get; }
        public int QueueFreeSlots { get; set; }
        public int StorageFreeSlots { get; set; }
        public List<IFactoryQueueElement> Queue { get; set; }
        public List<ITestingUnit> Storage { get; set; }
        public TimeSpan QueueTime { get; set; }

        public Action<object, EventArgs> FactoryStatus { get; set; }

        private readonly object addLock = new object();

        public UnitFactory(int queueCapacity, int storageCapacity)
        {
            this.QueueCapacity = queueCapacity;
            this.StorageCapacity = storageCapacity;
            Queue = new List<IFactoryQueueElement>();
            Storage = new List<ITestingUnit>();
        }
        
        public bool AddWorkableUnitToQueue(Type model, string name, Coordinates parkingPos, Coordinates workingPos)
        {
            lock (addLock)
            {
                FactoryQueueElement factoryQueueElement = new FactoryQueueElement(model, name, parkingPos, workingPos);
                if (Queue.Count < QueueCapacity)
                {
                    Queue.Add(factoryQueueElement);
                }else
                {
                    return false;
                }
                if (Storage.Count < StorageCapacity)
                {
                    //Storage.Add();
                }
                return true;
            }
        }
    }
}
