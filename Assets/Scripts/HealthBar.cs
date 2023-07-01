using UnityEngine;
using DG.Tweening;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private float _animationDuration;

    public void Animate(int newHealth, int maxHealth)
    {
        float targetValue = (float)newHealth / maxHealth;
        transform.DOScaleX(targetValue, _animationDuration);
    }
}
