using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plant : MonoBehaviour
{

    [SerializeField] private SpriteRenderer _spriteRenderer;

    [SerializeField] protected Sprite seedSprite;
    [SerializeField] protected Sprite babySprite;
    [SerializeField] protected Sprite adultSprite;

    [SerializeField] private PlantStats _stats;
    public PlantStats Stats => _stats;

    public void SetStats(PlantStats stats)
    {
        _stats = stats;
    }

    public int Date { get; private set; } = 0;

    public bool CanHarvested { get; private set; } = false;

    public void SetSprite(Sprite sprite)
    {
        _spriteRenderer.sprite = sprite;
    }

    #region Initialization
    private void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();

    }

    private void SetupStateMachine()
    {
        _stateMachine = new PlantStateMachine();
        SeedState = new PlantSeedState(this, _stateMachine, seedSprite);
        BabyState = new PlantBabyState(this, _stateMachine, babySprite);
        AdultState = new PlantAdultState(this, _stateMachine, adultSprite);
    }
    #endregion


    #region State Machine
    [SerializeField] private PlantStateMachine _stateMachine;
    public PlantSeedState SeedState;
    public PlantBabyState BabyState;
    public PlantAdultState AdultState;
    #endregion

    #region Stat-Update-FixedUpdate

    private void Start()
    {
        SetupStateMachine();
        _stateMachine.Initialize(SeedState);
    }

    private void Update()
    {
        _stateMachine.CurrentState.UpdateState();
    }

    private void FixedUpdate()
    {
        _stateMachine.CurrentState.FixedUpdateState();
    }

    private void OnEnable()
    {
        EventManager.OnMoveToNextDay += NextDay;
    }

    private void OnDisable()
    {
        EventManager.OnMoveToNextDay -= NextDay;
    }
    #endregion

    private void NextDay()
    {
        Date++;
    }

    public void ResetDay()
    {
        Date = 0;
    }

    public void SetCanHarvest()
    {
        CanHarvested = true;
    }
}
