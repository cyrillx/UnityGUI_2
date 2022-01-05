using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private int _maxHealh;
    private int _currentHealth;

    void Start()
    {
        _currentHealth = _maxHealh;
    }

    public void Increase(int points)
    {
        _currentHealth += points;
        if (_currentHealth > _maxHealh)
            _currentHealth = _maxHealh;
        StartAnimation();
    }

    public void Decrease(int points)
    {
        _currentHealth -= points;
        if (_currentHealth < 0)
            _currentHealth = 0;
        StartAnimation();
    }

    private void StartAnimation()
    {
        float newScale = (float)_currentHealth / (float)_maxHealh;
        transform.DOScaleX(newScale, 1);
    }
}
