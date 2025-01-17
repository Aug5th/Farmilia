using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _dateText;
    [SerializeField] TextMeshProUGUI _energyText;
    [SerializeField] TextMeshProUGUI _goldText;

    private void OnEnable()
    {
        EventManager.OnDateUpdate += OnDateUpdate;
        EventManager.OnEnergyUpdate += OnEnergyUpdate;
        EventManager.OnGoldUpdate += OnGoldUpdate;
    }

    private void OnDisable()
    {
        EventManager.OnDateUpdate -= OnDateUpdate;
        EventManager.OnEnergyUpdate -= OnEnergyUpdate;
        EventManager.OnGoldUpdate -= OnGoldUpdate;
    }

    private void OnDateUpdate(int date)
    {
        _dateText.text = "Date: " + date.ToString();
    }

    private void OnEnergyUpdate(int energy)
    {
        if(energy < 0)
        {
            return;
        }
        _energyText.text = "Energy: " + energy.ToString();
    }

    private void OnGoldUpdate(int gold)
    {
        _goldText.text = "Gold: " + gold.ToString();
    }
}
