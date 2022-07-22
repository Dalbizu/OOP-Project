using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
 
{   

    public DangerScript [] danger;

    // Start is called before the first frame update
    void Start()
    {
        foreach (DangerScript danger in danger)
        {
            ((VerticalDangerScript)danger).speed = 3f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
