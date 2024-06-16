using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public enum ResourceStatus
{
    Seed,
    Baby,
    Adult
}

public class Resource : MonoBehaviour
{
    [SerializeField] private ResourceStatus _resourceStatus;
    [SerializeField] private SpriteRenderer _spriteRenderer;
    [SerializeField] private Sprite _seedSprite, _babySprite, _adultSprite;
    [SerializeField] private int _grownDays = 0;
    public bool CanHarvested { get; private set; } = false;

    private void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _spriteRenderer.sprite = _seedSprite;
    }

    private void OnEnable()
    {
        EventManager.OnMoveToNextDay += GrownResource;
    }

    private void OnDisable()
    {
        EventManager.OnMoveToNextDay -= GrownResource;
    }

    public void SetGrownDays(int date)
    {
        _grownDays = date;
    }

    private void GrownResource(int date)
    {
        _grownDays--;
        UpdateResourceStatus();
    }

    private void UpdateResourceStatus()
    {
        switch (_resourceStatus)
        {
            case ResourceStatus.Seed:
                _resourceStatus = ResourceStatus.Baby;
                _spriteRenderer.sprite = _babySprite;
                break;
            case ResourceStatus.Baby:
                if (_grownDays == 0)
                {
                    _resourceStatus = ResourceStatus.Adult;
                    _spriteRenderer.sprite = _adultSprite;
                    CanHarvested = true;
                }
                break;
            case ResourceStatus.Adult:
                //Debug.Log("Collectable Resource");
                break;
        }
    }

    private void GenerateResource()
    {

    }

    private void OnMouseDown()
    {
        //UpdateResourceStatus();
    }
}


