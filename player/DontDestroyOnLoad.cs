using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyOnLoad : MonoBehaviour
{
    
   private GameObject spawn;
   public void Awake()
    {
        spawn = GameObject.FindGameObjectWithTag("Respawn");
        DontDestroyOnLoad(spawn.transform);
        //DontDestroyOnLoad(transform.gameObject);
    }
}
