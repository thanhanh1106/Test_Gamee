public interface IPlayerControlView
{
    public IJoystickView JoystickView { get;}
    public IActionButtonView BasicAttackButtonView { get;}
    public IActionButtonView FistSkillButtonView { get;}
    public IActionButtonView SecondSkillButtonView { get;}
}

public interface IJoystickView
{
    /// <summary>
    /// hướng hiện tại của join stick
    /// </summary>
    public UnityEngine.Vector2 Direction { get;}
    
    /// <summary>
    /// event trả về hướng hiện tại khi join stick di chuyển
    /// </summary>
    public event System.Action<UnityEngine.Vector2> OnDirectionChanged; 
}

public interface IActionButtonView
{
    /// <summary>
    /// Gọi khi người chơi nhấn nút.
    /// </summary>
    event System.Action OnPressed;

    /// <summary>
    /// Gọi khi người chơi nhả nút.
    /// </summary>
    event System.Action OnReleased;

    /// <summary>
    /// Bật/tắt nút
    /// </summary>
    void SetInteractable(bool interactable);

    /// <summary>
    /// Cập nhật progress cooldown (0 = ready, 1 = full cooldown).
    /// </summary>
    void SetCooldownProgress(float progress);
}