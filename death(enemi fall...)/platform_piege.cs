using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platform_piege : MonoBehaviour
{
    public AudioClip sound;
    public bool hasplayed = false;
    public Vector3 basePosition;
    public Quaternion rotation;
    GameObject platform;


    // Start is called before the first frame update
    public void Start()
    {
        basePosition = transform.position;
        rotation = transform.rotation;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
            Debug.Log("player piégé");
        {
            if (hasplayed == false)
            {
                GetComponent<AudioSource>().PlayOneShot(sound);
                hasplayed = true;
            }
            transform.GetComponent<Rigidbody2D>().mass = 100;
            transform.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
            

        }
    }

   public void reset()
    {
        
        transform.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
        transform.position = basePosition;
        transform.rotation = rotation;
        print("platformes reset");


    }
}
