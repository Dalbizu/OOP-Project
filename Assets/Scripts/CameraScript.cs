using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject player;
    private Vector3 position;

    // Start is called before the first frame update
    void Start()
    {
        
        
        position = new Vector3(player.transform.position.x, player.transform.position.y, -10);
        transform.position = position;
        transform.LookAt(player.transform);
    }

    // Update is called once per frame
    void Update()
    {
        position = new Vector3(player.transform.position.x, player.transform.position.y, -10);
        transform.position = position;
        transform.LookAt(player.transform);
    }
}
