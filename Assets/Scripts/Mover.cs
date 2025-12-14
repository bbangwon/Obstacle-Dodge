using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering.Universal;

public class Mover : MonoBehaviour, MyActions.IPlayerActions
{
    private MyActions m_Actions;
    private MyActions.PlayerActions m_Player;
    Vector2 inputVec2;
    [SerializeField] float moveSpeed = 10f;

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

    void Start()
    {
        PrintInstruction();    
    }

    void Update()
    {
        MovePlayer();
    }

    void PrintInstruction()
    {
        Debug.Log("게임에 오신 것을 환영합니다!");
        Debug.Log("WASD 키나 화살표키로 움직이세요!");
        Debug.Log("오브젝트에 부딪히지 마세요!");
    }

    void MovePlayer()
    {
        float xValue = inputVec2.x * Time.deltaTime * moveSpeed;
        float yValue = 0f;
        float zValue = inputVec2.y * Time.deltaTime * moveSpeed;

        transform.Translate(xValue, yValue, zValue);
    }

    #region 인풋 콜백 함수들
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
    #endregion
}
