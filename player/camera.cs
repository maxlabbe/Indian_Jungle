using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
    
{
    private GameObject player;

    private Vector3 camposition;


    // Start is called before the first frame update
    
    // Update is called once per frame
    void Update()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        camposition.x = player.transform.position.x;
        camposition.y = player.transform.position.y + 3;
        camposition.z = -20;
        transform.position = camposition;
        
        

    }
}
