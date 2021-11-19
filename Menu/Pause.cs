using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
   bool showGUI = false;
   public GameObject canvas;
    public void OnLevelWasLoaded()
    {
        canvas = GameObject.Find("Pause");


    }


    // Update is called once per frame
    public void Update()
    {
        

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            showGUI = !showGUI;
        }
        if(showGUI == true)
        {
            canvas.SetActive(true);
            Time.timeScale = 0;
        }
        else
        {
            canvas.SetActive(false);
            Time.timeScale = 1;
        }
    }
    
}
