using System;

namespace Noodlepop
{
    [Serializable]
    public class IntDepletableStat : DepletableStat<int>
    {
        public IntDepletableStat(int max) : base(max)
        {
        }

        public override void Add(int amount)
        {
            if (Max < 0)
                return;
            
            _amount += Math.Min(amount, Max);
            RaiseAddedEvent(amount);
            
            if(_amount >= Max)
                RaiseOnReplenishedEvent(); 
        }
        
        public override void Remove(int amount)
        {
            if (Max < 0)
                return;
            
            _amount = Math.Max(0, _amount - amount);
            
            RaiseRemovedEvent(amount);

            if (_amount == 0)
                RaiseDepletedEvent();
        }

        public void Deplete()
        {
            if (Max < 0)
                return;
            
            Remove(_amount);
        }

        public void Replenish()
        {
            if (Max < 0)
                return;
            
            Add(Max - _amount);
        }


    }
}