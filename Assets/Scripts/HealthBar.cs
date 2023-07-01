using UnityEngine;
using DG.Tweening;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private float _animationDuration;

    public void Animate(int newHealth, int maxHealth)
    {
        float targetValue;

        if (maxHealth > 0)
            targetValue = (float)newHealth / maxHealth;
        else
            targetValue = 0;

        transform.DOScaleX(targetValue, _animationDuration);
    }
}
