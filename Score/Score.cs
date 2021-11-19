using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Score : MonoBehaviour
{
    public int coins ;
    public GUISkin LabelSkin;
    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Load();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "piece")
        {
            Load();
        }
    }
    public void OnGUI()
    {
        GUI.skin = LabelSkin;
        GUI.Label(new Rect(65, 17, 300, 50), "" + coins);
        
        
    }
    void Load()
    {
        string saveString = File.ReadAllText(Application.dataPath + "/Score_coin.txt");
        coins = int.Parse(saveString);
    }
}
