using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class coins : MonoBehaviour
{
    public int coin;
    string saveString;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        saveString = File.ReadAllText(Application.dataPath + "/Score_coin.txt");
        coin = int.Parse(saveString);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            
            coin++;
            saveString = coin.ToString();
            File.WriteAllText(Application.dataPath + "/Score_coin.txt", saveString);
            Destroy(gameObject);
            
        }
    }
    
}
