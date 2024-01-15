using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Moves : MonoBehaviour
{
    [SerializeField]
    private float speed = 20f;

    Vector2 direction;
    Rigidbody rgb;


    //public Transform fLCamera;


    private void Awake()
    {
        rgb = GetComponent<Rigidbody>();
        
    }
    private void Start()
    {
        
    }
    private void Update()
    {
        



    }

    private void FixedUpdate()
    {
        Vector3 veloZ = new Vector3(direction.x * speed, rgb.velocity.y, direction.y * speed);
        rgb.velocity = veloZ * speed / 10;
        PlayerLook();


    }


    public void OnMove(InputAction.CallbackContext c)
    {
        direction = c.ReadValue<Vector2>();
        
    }

    private void PlayerLook()
    {
        if (direction.magnitude > 0)
        {
            Vector3 lookDirection = new Vector3(direction.x, 0 , direction.y);
            lookDirection.y = 0;
            Quaternion rotation = Quaternion.LookRotation(lookDirection);
            rotation = Quaternion.RotateTowards(rgb.rotation, rotation, speed);
            rgb.rotation = rotation;
          
        }
    }


}
