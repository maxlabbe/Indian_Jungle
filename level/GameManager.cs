using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;

    public static GameManager Instance { get { return instance; } }



    [SerializeField]
    private Transform playerPrefab;

    private Transform playerInstanciate;

    private Player playerScript;
    [SerializeField]
    private Transform Spawn;
   

    private void Awake()
    {
        if(instance != null)
        {
            Destroy(gameObject);
        }
        instance = this;
       
    }
    // Start is called before the first frame update
    void Start()
    {
        InstanciatePlayer();
    }

    private void InstanciatePlayer()
    {
        playerInstanciate = Instantiate(playerPrefab, Spawn.position, Quaternion.identity);
        playerScript = playerInstanciate.GetComponent<Player>();

        playerScript.MonEvent += PlayerScript_MonEvent;
    }

    private void PlayerScript_MonEvent()
    {
        Destroy(playerInstanciate.gameObject);
        StartCoroutine(RespawnPlayer());
    }

    private IEnumerator RespawnPlayer()
    {
        yield return new WaitForSeconds(1);
        InstanciatePlayer();
    }
    
}
