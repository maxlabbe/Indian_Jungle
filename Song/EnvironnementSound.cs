using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironnementSound : MonoBehaviour
{
    private GameObject player;
    private float x;
    public float distance_log, distance, volume_max;
    // Start is called before the first frame update
    void Start()
    {
       

    }

    // Update is called once per frame
    void Update()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        x = Mathf.Abs(player.transform.position.x - transform.position.x);
       
        if (x >= 10 && x <= distance)
        {
            GetComponent<AudioSource>().volume =distance_log - Mathf.Log10(x);
        }
        
        if(x>distance)
        {
            
            GetComponent<AudioSource>().volume = 0;
            

        }
    }
}
