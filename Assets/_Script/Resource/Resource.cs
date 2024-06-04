using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resource : MonoBehaviour
{
    [SerializeField] private ResourceType _resourceType;
    [SerializeField] private SpriteRenderer _spriteRenderer;
    [SerializeField] private Sprite _seedSprite, _babySprite, _adultSprite;

   

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

    private void GrownResource(int date)
    {
        UpdateResourceStatus();
    }

    private void UpdateResourceStatus()
    {
        switch (_resourceType)
        {
            case ResourceType.Seed:
                _resourceType = ResourceType.Baby;
                _spriteRenderer.sprite = _babySprite;
                break;
            case ResourceType.Baby:
                _resourceType = ResourceType.Adult;
                _spriteRenderer.sprite = _adultSprite;
                break;
            case ResourceType.Adult:
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

[Serializable]
public enum ResourceType
{
    Seed,
    Baby,
    Adult
}
