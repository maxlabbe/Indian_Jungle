using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class end_level : MonoBehaviour
{
    public string levelname = "Enter Level name here";
    // Start is called before the first frame update
    

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            Application.LoadLevel(levelname);
        }
    }
}
