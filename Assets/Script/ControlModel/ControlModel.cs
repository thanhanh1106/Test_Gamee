
using System;
using UnityEngine;

public class ControlModel : IControlModel
{
    public event Action<Vector2> OnMovement;
    public event Action OnBasicAttackPressed;
    public event Action OnFistSkillPressed;
    public event Action OnSecondSkillPressed;
    public event Action OnThirdSkillPressed;
    public event Action OnBasicAttackReleased;
    public event Action OnFistSkillReleased;
    public event Action OnSecondSkillReleased;
    public event Action OnThirdSkillReleased;

    public void Movement(Vector2 movement)
    {
        OnMovement?.Invoke(movement);
    }

    public void BasicAttackPressed()
    {
        OnBasicAttackPressed?.Invoke();
    }

    public void FistSkillPressed()
    {
        OnFistSkillPressed?.Invoke();
    }

    public void SecondSkillPressed()
    {
        OnSecondSkillPressed?.Invoke();
    }

    public void BasicAttackReleased()
    {
        OnBasicAttackReleased?.Invoke();
    }

    public void FistSkillReleased()
    {
        OnFistSkillReleased?.Invoke();
    }

    public void SecondSkillReleased()
    {
        OnSecondSkillReleased?.Invoke();
    }

    public void ThirdSkillReleased()
    {
        OnThirdSkillReleased?.Invoke();
    }
}
