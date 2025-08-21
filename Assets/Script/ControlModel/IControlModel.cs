using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

// các input dạng view hoặc dùng bàn phím, tay cầm hay bất cứ gì đều qua presenter báo cho model, character sẽ dùng model này để nhận input
public interface IControlModel
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
    public void Movement(Vector2 movement);
    public void BasicAttackPressed();
    public void FistSkillPressed();
    public void SecondSkillPressed();
    
    public void BasicAttackReleased();
    public void FistSkillReleased();
    public void SecondSkillReleased();
    public void ThirdSkillReleased();
    
    
}
