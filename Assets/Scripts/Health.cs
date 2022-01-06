using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private int _maxHealth;
    [SerializeField] private HealthBar _healthBar;
    private int _currentHealth;
    private int _healPoints;
    private int _damagePoints;

    private void Start()
    {
        _currentHealth = _maxHealth;
    }

    public void ApplyChange(int points)
    {
        _currentHealth += points;
        if (_currentHealth > _maxHealth)
            _currentHealth = _maxHealth;
        else if (_currentHealth < 0)
            _currentHealth = 0;
        _healthBar.Animate(_currentHealth, _maxHealth);
    }
}
