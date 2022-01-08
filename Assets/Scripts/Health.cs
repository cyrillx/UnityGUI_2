using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    [SerializeField] private HealthEvent _changed;
    [SerializeField] private int _maxHealth;

    private int _currentHealth;

    private void Start()
    {
        _currentHealth = _maxHealth;
    }

    public void Damage(int points)
    {
        _currentHealth -= points;
        if (_currentHealth < 0)
            _currentHealth = 0;
        _changed.Invoke(_currentHealth, _maxHealth);
    }

    public void Heal(int points)
    {
        _currentHealth += points;
        if (_currentHealth > _maxHealth)
            _currentHealth = _maxHealth;
        _changed.Invoke(_currentHealth, _maxHealth);
    }
}
