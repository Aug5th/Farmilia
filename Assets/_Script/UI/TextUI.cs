using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _dateText;
    [SerializeField] TextMeshProUGUI _energyText;

    private void OnEnable()
    {
        EventManager.OnMoveToNextDay += OnNextDateUpdate;
        EventManager.OnEnergyUpdate += OnEnergyUpdate;
    }

    private void OnDisable()
    {
        EventManager.OnMoveToNextDay -= OnNextDateUpdate;
        EventManager.OnEnergyUpdate -= OnEnergyUpdate;
    }


    private void OnNextDateUpdate(int date)
    {
        _dateText.text = date.ToString();
    }

    private void OnEnergyUpdate(int energy)
    {
        if(energy < 0)
        {
            return;
        }
        _energyText.text = energy.ToString();
    }
}
