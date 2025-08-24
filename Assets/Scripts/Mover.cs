using UnityEngine;
using UnityEngine.InputSystem;

public class Mover : MonoBehaviour, MyActions.IPlayerActions
{

    private MyActions m_Actions;
    private MyActions.PlayerActions m_Player;
    Vector2 inputVec2;


    void Awake()
    {
        m_Actions = new MyActions();
        m_Player = m_Actions.Player;
        m_Player.AddCallbacks(this);
    }

    void OnDestroy()
    {
        m_Actions.Dispose();
    }

    void OnEnable()
    {
        m_Player.Enable();
    }

    void OnDisable()
    {
        m_Player.Disable();
    }

    void Update()
    {
        float xValue = inputVec2.x;
        float yValue = 0f;
        float zValue = inputVec2.y;

        transform.Translate(xValue, yValue, zValue);
    }

    public void OnAttack(InputAction.CallbackContext context)
    {

    }

    public void OnLook(InputAction.CallbackContext context)
    {

    }

    public void OnMove(InputAction.CallbackContext context)
    {
        inputVec2 = context.ReadValue<Vector2>();
    }
}
