using System;
using UnityEngine;
public class JoinStickView : MonoBehaviour, IJoystickView
{
    [SerializeField] private DynamicJoystick _dynamicJoystick;

    public Vector2 Direction => _dynamicJoystick.Direction;

    public event Action<Vector2> OnDirectionChanged;

    private Vector2 _lastDirection;

    private void Update()
    {
        Vector2 current = _dynamicJoystick.Direction;
        
        if (current != _lastDirection)
        {
            _lastDirection = current;
            OnDirectionChanged?.Invoke(current);
        }
    }
}
