using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{

    private Rigidbody2D rigibodyPlayer;
    private float lateralForce = 30000f;
    public bool onGround;

    private int life;

    //ENCAPSULATION
    public int _life
        {
        get
        {
            return life;
        }
        set
        {
            life = value;
            if (life <0)
            {
                life = 0;
            }
        }
            
    } 

    private void Start()
    {
        rigibodyPlayer = gameObject.GetComponent<Rigidbody2D>();
        life = 3;
    }

    private void Update()
    {
        if (Input.GetKey("left"))
        {
            rigibodyPlayer.AddForce(new Vector2(-lateralForce * Time.deltaTime, 0));
            Debug.Log("left");
        }
        else if (Input.GetKey("right"))
        {
            rigibodyPlayer.AddForce(new Vector2(lateralForce * Time.deltaTime, 0));
            Debug.Log("right");
        }

        if (onGround && Input.GetKeyDown("up"))
        {
            onGround = false;
            rigibodyPlayer.AddForce(new Vector2(0, 300), ForceMode2D.Impulse);
            Debug.Log("up");          
        }

    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("collision");
        if (collision.gameObject.CompareTag("ground"))
        {
            onGround = true;
           
        }

        if (collision.gameObject.CompareTag("danger"))
        {
            collision.gameObject.GetComponent<DangerScript>().DealDamage();
            Debug.Log(life);
        }

    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log("collision");
        if (collision.gameObject.CompareTag("ground"))
        {
            onGround = false;

        }

    }




}
