using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : PlayerStats
{
    float x;
    float y;
    public GameObject[] platforms;
    private Animator anim;
    public int distance_death;

    public event Action MonEvent;

    public bool PlayerIsDead { get{ return PV <= 0f; } }

    // Start is called before the first frame update
    void Start()
    {
        x = gameObject.transform.position.y;
        y = 0;
        platforms = GameObject.FindGameObjectsWithTag("platforme_piege");
    }

    // Update is called once per frame
    void Update()
    {
        y = gameObject.transform.position.y;
        PlayerTombe(x,y);
        if (PlayerIsDead)
        {
            foreach (var x in platforms)
            {


                x.GetComponent<platform_piege>().reset();
                for(int i = 0; i<platforms.Length; i++)
                {
                    platforms[i].GetComponent<platform_piege>().hasplayed = false;
                }


            }
        }
        if (MonEvent != null && PlayerIsDead)
        {
            MonEvent();
            
        }
    }
    public void PlayerTombe(float x, float y)
    {

        
        if (x-y > distance_death)
        {
            RecevoirDegat(Mathf.Infinity);
        }

    } 

    public void RecevoirDegat(float degat)
    {
        PV -= degat;
    }

    
}
