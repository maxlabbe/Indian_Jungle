using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mort : MonoBehaviour
{
    private string level_name;
    // Start is called before the first frame update
    void Start()
    {
        level_name = Application.loadedLevelName;
    }

    // Update is called once per frame
    void Update()
    {
        if(level_name == "level 1")
        {
            GetComponent<PlayerController>().chute = 5;
            GetComponent<Player>().distance_death = 20;
        }
        
    }
}
