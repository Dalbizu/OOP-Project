using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//INHERITANCE
public class HorizontalDangerScript : DangerScript
{
    private float time = 0;
    private float space = 0;
    public float speed = 3.0f;
    private float amplitude = 2.5f;
    private float initialX;



    // Update is called once per frame
    private void Start()
    {

        initialX = this.transform.position.x;
    }

    void Update()
    {
        time += Time.deltaTime;
        space = amplitude * Mathf.Sin(speed * time);
        //ABSTRACTION
        move(space);

    }

    public override void move(float space)
    {
        transform.position = new Vector3(space + initialX, this.transform.position.y, 0);
    }

    //POLIMORPHISM
    public override void DealDamage()
    {
        //ABSTRACTION
        base.DealDamage();
        base.DealDamage();
    }

}
