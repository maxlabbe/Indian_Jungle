using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class music : MonoBehaviour
{
    public Object[] myMusic;

    public void Awake()
    {
        myMusic = Resources.LoadAll("Music", typeof(AudioClip));
        GetComponent<AudioSource>().clip = myMusic[0] as AudioClip;
    }
    // Start is called before the first frame update
    public void Start()
    {
        GetComponent<AudioSource>().Play();
    }

    // Update is called once per frame
    public void Update()
    {
        if ((!GetComponent<AudioSource>().isPlaying))
        {
            playRandomMusic();
        }
    }
    public void playRandomMusic()
    {
        GetComponent<AudioSource>().clip = myMusic[Random.Range(0, myMusic.Length)] as AudioClip;
        GetComponent<AudioSource>().Play();
    }
}
