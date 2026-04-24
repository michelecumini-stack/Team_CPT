using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputManager : MonoBehaviour
{
    public static PlayerInputManager Instance { get; private set; }
    public Vector2 _currentMoveInput;
    private AttitudeSensor attitudeSensor = null;

    public void Awake()
    {
        Instance = this;
        _currentMoveInput = Vector2.zero;
    }

    public void OnMove(InputValue value)
    {
        Vector2 moveInput = value.Get<Vector2>();
        Debug.Log("Move Input: " + moveInput);
        _currentMoveInput = moveInput;
    }

    public void OnAttack(InputValue value)
    {
        bool isPressed = value.isPressed;
        Debug.Log("Attack Pressed: " + isPressed);
    }

    public void Update()
    {
        attitudeSensor = AttitudeSensor.current;
        if (attitudeSensor != null)
        {
            if (!attitudeSensor.enabled)
            {
                InputSystem.EnableDevice(attitudeSensor);
            }
        }
    }

    public bool IsGyroEnabled()
    {
        return attitudeSensor != null;
    }

    public Quaternion GetGyroAttitude()
    {
        if (attitudeSensor != null)
        {
            return attitudeSensor.attitude.ReadValue();
        }
        else
        {
            return Quaternion.identity;
        }
    }
}
