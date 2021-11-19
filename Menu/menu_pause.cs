using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu_pause : MonoBehaviour
{
    // Start is called before the first frame update
    public void main_menu()
    {
        Application.LoadLevel("menu");
    }
    public void quit_the_game()
    {
        Application.Quit();
    }
}
