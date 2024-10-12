using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryController : MonoBehaviour
{
    [SerializeField] private InventorySlot[] _inventorySlots;

    private void Awake()
    { 
        LoadInventorySlotList();
    }

    private void LoadInventorySlotList()
    {
        _inventorySlots = GetComponentsInChildren<InventorySlot>();
    }

    public void SetSelectedSlot(InventorySlot slot)
    {
        ResetInventorySlots();
        slot.SelectResource();
    }

    public void ResetInventorySlots()
    {
        foreach (var _inventorySlot in _inventorySlots)
        {
            _inventorySlot.SetSelectedBorder(false);
        }
    }
}
