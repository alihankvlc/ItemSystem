﻿using ItemSystem.Scripts.Interfaces;
using UnityEngine;

namespace ItemSystem.Scripts.DataManager
{
    public abstract class WeaponData : ItemData, IEquippable
    {
        [SerializeField] private bool _isEquipped;

        public override ItemType Type => ItemType.Weapon;

        public bool IsEquipped
        {
            get => _isEquipped;
            protected set => _isEquipped = value;
        }

        public abstract void Equip();
        public abstract void Unequip();

        public override void Use(params object[] args)
        {
            if (IsEquipped) Unequip();
            else Equip();
        }
    }
}