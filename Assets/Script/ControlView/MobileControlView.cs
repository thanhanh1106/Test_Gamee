using UnityEngine;

public class MobileControlView : MonoBehaviour, IPlayerControlView
{
    
    [SerializeField] private JoinStickView _joinStickView;
    [SerializeField] private ActionButtonView _basicAttackButtonView;
    [SerializeField] private ActionButtonView _fistSkillButtonView;
    [SerializeField] private ActionButtonView _secondButtonView;
    
    public IJoystickView JoystickView => _joinStickView;
    public IActionButtonView BasicAttackButtonView => _basicAttackButtonView;
    public IActionButtonView FistSkillButtonView => _fistSkillButtonView;
    public IActionButtonView SecondSkillButtonView =>  _secondButtonView;
    
    
}
