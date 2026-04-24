using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [Header("Movement Settings")]
    [SerializeField, Range(1f, 20f)] private float moveSpeed = 5f;

    // Update is called once per frame

    private void Start()
    {
        Debug.Log("Tag del oggetto: " + gameObject.tag);
    }

    void Update()
    {
        //Movimento
        Vector2 currentInput = PlayerInputManager.Instance._currentMoveInput;
        if (currentInput == Vector2.zero) return;
        Vector3 moveDirection = new Vector3(currentInput.x, 0f, currentInput.y);
        transform.Translate(moveDirection * (moveSpeed * Time.deltaTime));
    }
}
