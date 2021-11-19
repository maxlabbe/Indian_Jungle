using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathTrigger : MonoBehaviour
{
    public Vector2 position;
    public GameObject[] platforms;
    public void Start()
    {
        platforms = GameObject.FindGameObjectsWithTag("platforme_piege");
       
    }
    public void OnTriggerEnter2D(Collider2D other)
        
    {
        
        if (other.tag == "Player")
        {
            other.transform.position = position;
            foreach(var x in platforms)
            {
                
                
                x.GetComponent<platform_piege>().reset();
               

            }
        }
    }

}
