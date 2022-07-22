using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//INHERITANCE
public class VerticalDangerScript : DangerScript
{
    private float time = 0;
    private float space = 0;
    public float speed;
    private float amplitude = 2.5f;
    private float initialY;


    // Update is called once per frame
    private void Start()
    {

        initialY = this.transform.position.y;
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
        transform.position = new Vector3(this.transform.position.x, space + initialY, 0);
    }
}
