using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _dateText;

    private void OnEnable()
    {
        EventManager.OnMoveToNextDay += UpdateDateText;
    }

    private void OnDisable()
    {
        EventManager.OnMoveToNextDay -= UpdateDateText;
    }


    private void UpdateDateText(int date)
    {
        _dateText.text = date.ToString();
    }
}
