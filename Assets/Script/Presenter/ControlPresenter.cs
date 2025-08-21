public class ControlPresenter
{
    private IPlayerControlView _playerControlView;
    private IControlModel _controlModel;

    public ControlPresenter(IPlayerControlView playerControlView, IControlModel controlModel)
    {
        _playerControlView = playerControlView;
        _controlModel = controlModel;

        _playerControlView.JoystickView.OnDirectionChanged += _controlModel.Movement;
        
        _playerControlView.BasicAttackButtonView.OnPressed += _controlModel.BasicAttackPressed;
        _playerControlView.FistSkillButtonView.OnPressed += _controlModel.FistSkillPressed;
        _playerControlView.SecondSkillButtonView.OnPressed += _controlModel.SecondSkillPressed;
    }
    
    // thay đổi model control thì viết thêm
}
