using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Health _health;

    public void OnDamage(int points)
    {
        _health.ApplyChange(-points);
    }

    public void OnHeal(int points)
    {
        _health.ApplyChange(points);
    }
}
