using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName = "PlayerProfile", menuName = "Scriptable Objects/Player Profile")]
public class SO_PlayerProfile : ScriptableObject
{
    [SerializeField] private PlayerStats _playerStats;
    public PlayerStats PlayerStats => _playerStats;
}

[Serializable]
public struct PlayerStats
{
    public int Date;
    public int Energy;
    public int Gold;
}
