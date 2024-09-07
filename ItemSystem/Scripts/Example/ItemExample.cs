using System;
using ItemSystem.Scripts.Data.Sub;
using ItemSystem.Scripts.DataManager;
using Sisus.Init;
using UnityEngine;

public sealed class ItemExample : MonoBehaviour<IDatabaseService>
{
    [SerializeField] private ItemData _rifle;
    [SerializeField] private ItemData _consumableData;

    [SerializeField] private int _potionQuantity;

    private IDatabaseService _database;

    protected override void Init(IDatabaseService argument)
    {
        _database = argument;
    }

    private void Start()
    {
        //Potion Id = 0
        //Rifle Id = 1

        _consumableData = _database.ItemDatabase.GetData(0);
        _rifle = _database.ItemDatabase.GetData(1);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            _rifle.Use();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            _consumableData.Use(65);
        }
    }
}