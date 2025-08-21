using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharaterEx : MonoBehaviour
{
    private IControlModel _controlModel;


    public void InjectControl(IControlModel controlModel)
    {
        _controlModel = controlModel;
        _controlModel.OnMovement += Move;
        _controlModel.OnBasicAttackPressed += BasicAttack;
        _controlModel.OnFistSkillPressed += SpecialSkill;
        _controlModel.OnSecondSkillPressed += Dash;
    }

    private void Move(Vector2 direction)
    {
        Debug.Log("MOVE" +  direction);
    }

    private void BasicAttack()
    {
        Debug.Log("BasicAttack");
    }

    private void SpecialSkill()
    {
        Debug.Log("SpecialSkill");
    }

    private void Dash()
    {
        Debug.Log("Dash");
    }
}
