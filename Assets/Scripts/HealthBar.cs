using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private float _animationDuration;

    public void Animate(float newHealth, float maxHealth)
    {
        float targetValue = newHealth / maxHealth;
        transform.DOScaleX(targetValue, _animationDuration);
    }
}
