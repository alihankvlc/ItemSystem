using UnityEngine;

namespace ItemSystem.Scripts.DataManager
{
    public enum ItemType
    {
        Weapon,
        Consumable
    }

    public abstract class ItemData : ScriptableObject, IItem
    {
#if UNITY_EDITOR
        [Multiline, Space] public string EDITOR_DESCRIPTION;
#endif
        [SerializeField] private int _id;
        [SerializeField] private string _name;
        [SerializeField] private string _description;
        [SerializeField] private Sprite _icon;

        public int ID => _id;
        public string Name => _name;
        public string Description => _description;
        public Sprite Icon => _icon;

        public virtual ItemType Type { get; protected set; }

        public virtual void Use(params object[] args)
        {
        }
    }
}