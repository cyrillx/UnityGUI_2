using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    [SerializeField] private HealthEvent _healthChanged;
    [SerializeField] private int _maxHealth;

    private int _minHealth = 0;
    private int _currentHealth;

    private void Start()
    {
        _currentHealth = _maxHealth;
    }

    private void FixWithinLimits()
    {
        _currentHealth = Mathf.Clamp(_currentHealth, _minHealth, _maxHealth);
    }

    private void NotifyChangeListeners()
    {
        _healthChanged.Invoke(_currentHealth, _maxHealth);
    }

    public void TakeDamage(int points)
    {
        _currentHealth -= points;
        FixWithinLimits();
        NotifyChangeListeners();
    }

    public void Heal(int points)
    {
        _currentHealth += points;
        FixWithinLimits();
        NotifyChangeListeners();
    }
}
