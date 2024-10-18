using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Dog : MonoBehaviour
{
    public InputAction moveAction;
    public float speed = 4;
    // Start is called before the first frame update
    void Start()
    {
        //moveAction.Enable();을 해줘야 moveAction을 쓸 수 있음
        moveAction.Enable();
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 move = moveAction.ReadValue<Vector2>();
        Debug.Log(move);

        if (move.x != 0 || move.y !=0)
        {
            Vector3 movement = new Vector3(move.x, move.y, 0);
            Vector3 direction = movement.normalized;
            Debug.Log($"direction: {direction} ");
            transform.position += direction * Time.deltaTime * speed;
        }
    }
}
