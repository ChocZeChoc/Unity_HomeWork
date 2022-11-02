using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Transform groundCheckTransform = null;
    [SerializeField] private LayerMask playerMask;

    public int JumpSpeed = 6;
    private bool jumpKeyPressed;
    private float horizontalInput;
    private float verticalInput;
    private Rigidbody rigidbodyComponent;
    public float moveSpeed = 5;
    

    // Start is called before the first frame update
    void Start()
    {
        rigidbodyComponent = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jumpKeyPressed = true;
        }

        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
    }

    //Fixed update runs every Physic Update
    private void FixedUpdate()
    {
        if (Physics.OverlapSphere(groundCheckTransform.position, 0.1f, playerMask).Length == 0)
        {
            return;
        }

        if (jumpKeyPressed == true)
        {
            rigidbodyComponent.AddForce(Vector3.up * JumpSpeed, ForceMode.VelocityChange);
            jumpKeyPressed = false;
        }

        rigidbodyComponent.velocity = new Vector3(horizontalInput * moveSpeed, rigidbodyComponent.velocity.y, verticalInput * moveSpeed);
        
    }

}
