using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private GameObject Bullet;
    [SerializeField] private Transform PlayerPos;
    private Vector2 moveVelocity;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove();
       
    }

    void PlayerMove()
    {
        Vector2 moveInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        moveVelocity = moveInput.normalized * speed * Time.deltaTime;
        rb.MovePosition(rb.position + moveVelocity);
    }  

    /*void PlayerShoot()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(Bullet,PlayerPos.position,Quaternion.identity);
        }
    }*/
}
