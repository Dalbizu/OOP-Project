using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class DangerScript : MonoBehaviour
{
    public GameObject playerObject;

    public abstract void move(float space);

    public void Awake()
    {
        playerObject = GameObject.FindGameObjectWithTag("player");
    }

    //POLIMORPHISM
    public virtual void DealDamage()
    {
        playerObject.GetComponent<PlayerScript>()._life--;

    }

}
