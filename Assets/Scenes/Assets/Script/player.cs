using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{

    public float horizontalInput; 
    public float speed;
    public float jumpForce;
    public Rigidbody2D rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Jump();

    }


    void Move()
    {
       
        //o dir.y usa o rigidbody pq a velocidade nao pode ser igual a 0, entao o eixo y vai ser igual a velocidade atual do player

        horizontalInput = Input.GetAxisRaw("Horizontal");
        gameObject.transform.Translate(new Vector2(horizontalInput * speed * Time.deltaTime, 0));

    }
    

    void Jump()
    {

        if(Input.GetKeyDown(KeyCode.W))
        {
            rigidbody.velocity = new Vector2(0, jumpForce);
        }
    }
}
