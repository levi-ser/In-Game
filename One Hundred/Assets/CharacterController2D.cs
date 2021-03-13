using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class CharacterController2D : MonoBehaviour
{
    Rigidbody2D rigidbody2d;
    [SerializeField] float speed = 2f;
    Vector2 motionVector;
    Animator animator;
    // Start is called before the first frame update
    void Awake()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        motionVector = new Vector2(
            Input.GetAxisRaw("Horizontal"),
            Input.GetAxisRaw("Vertical")
            );
        animator.SetFloat("horizontal", Input.GetAxisRaw("Horizontal"));
            animator.SetFloat("vertical", Input.GetAxisRaw("Vertical"));
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        move();
    }
    private void move()
    {
        rigidbody2d.velocity = motionVector * speed;
    }
}
