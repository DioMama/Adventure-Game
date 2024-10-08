using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public float speed = 4;
    public InputAction moveAction;
    // Start is called before the first frame update
    void Start()
    {
        moveAction.Enable();

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 input = moveAction.ReadValue<Vector2>();
        Debug.Log(input);

        if (input.x != 0 || input.y != 0)
        {
            Vector3 movement = new Vector3(input.x, input.y, 0);
            Vector3 direction = movement.normalized;
            Debug.Log($"direction: {direction} ");
            transform.position += direction * Time.deltaTime * speed;
        }
    }
}
