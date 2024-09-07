﻿namespace ItemSystem.Scripts.Interfaces
{
    public interface IEquippable
    {
        void Equip();
        void Unequip();
        
        bool IsEquipped { get; }
    }
}