using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private CharacterController _controller;
    [SerializeField] private Transform _groundCheck;
    [SerializeField] private LayerMask _groundMask;
    private Vector3 _velocity;
    private bool _isGrounded;

    public float speed = 12f;
    public float gravity = -9.81f;
    public float groundDistance = 0.4f;
    public float jumpHeight = 3f;

    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
        _isGrounded = Physics.CheckSphere(_groundCheck.position, groundDistance, _groundMask);

        if(_isGrounded && _velocity.y <0)
        {
            _controller.slopeLimit = 45.0f;
            _velocity.y = -2f;
        }

        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");
        Vector3 move = transform.right * x + transform.forward * z;

        _controller.Move(move.normalized * speed * Time.deltaTime);

        if(Input.GetButtonDown("Jump") && _isGrounded)
        {
            _controller.slopeLimit = 100.0f;
            _velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        _velocity.y += gravity * Time.deltaTime;

        _controller.Move(_velocity * Time.deltaTime);

        if (Input.GetKeyDown("e"))
        {
            anim.SetBool("choose", true);
        }

    }
}
