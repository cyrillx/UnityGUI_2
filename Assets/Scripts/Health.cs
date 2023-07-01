using UnityEngine;

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

    private void OnValidate()
    {
        if (_maxHealth < _minHealth)
            _maxHealth = _minHealth;
    }

    public void TakeDamage(int points)
    {
        _currentHealth -= points;
        Clamp();
        NotifyChangeListeners();
    }

    public void Heal(int points)
    {
        _currentHealth += points;
        Clamp();
        NotifyChangeListeners();
    }

    private void Clamp()
    {
        _currentHealth = Mathf.Clamp(_currentHealth, _minHealth, _maxHealth);
    }

    private void NotifyChangeListeners()
    {
        _healthChanged.Invoke(_currentHealth, _maxHealth);
    }
}
