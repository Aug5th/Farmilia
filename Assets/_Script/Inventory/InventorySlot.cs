using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class InventorySlot : MonoBehaviour, IPointerDownHandler,IPointerEnterHandler,IPointerExitHandler
{
    [SerializeField] private Transform _selectedBorder;
    [SerializeField] private SO_Resource _resource;
    [SerializeField] private InventoryController _inventoryController;

    private void Awake()
    {
        _inventoryController = GetComponentInParent<InventoryController>();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Left)
        {
            _inventoryController.SetSelectedSlot(this);
        }     
    }

    public void SelectResource()
    {
        GameManager.Instance.SetSelectedResource(_resource);
        SetSelectedBorder(true);
    }

    public void SetSelectedBorder(bool isSelected)
    {
        _selectedBorder.gameObject.SetActive(isSelected);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        //Debug.Log("Pointer entered!");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        //Debug.Log("Pointer exited!");
    }
}
