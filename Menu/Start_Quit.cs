using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start_Quit : MonoBehaviour
{
    public void Start_the_game()
    {
        Application.LoadLevel("level 1");
    }
    public void Quit_the_game()
    {
        Application.Quit();
    }
}
