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

            if (_amount == Max)
                return;
            
            _amount += amount;
            
            if (_amount >= Max)
            {
                _amount = Max;
                
                RaiseAddedEvent(amount);
                RaiseOnReplenishedEvent();
            }
            else
            {
                RaiseAddedEvent(amount);
            }
        }
        
        public override void Remove(int amount)
        {
            if (Max < 0)
                return;
            
            if(_amount == 0)
                return;

            _amount -= amount;
            
            if (_amount <= 0)
            {
                _amount = 0;
                
                RaiseRemovedEvent(amount);
                RaiseDepletedEvent();
            }
            else
            {
                RaiseRemovedEvent(amount);
            }
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