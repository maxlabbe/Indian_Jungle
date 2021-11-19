using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public float PV { get; set; }

    public float Damage { get; set; }

    public PlayerStats()
    {
        PV = 100;
        Damage = 25;
    }
   
}
