using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class parralaxing : MonoBehaviour
{
    [SerializeField]
    private GameObject[] paralaxGo;
    [SerializeField]
    private float[] speedParralax;
    private Camera cam;


    private Vector2 previousCampos;
    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main; 
        previousCampos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < paralaxGo.Length; i++)
        {
            float speed = (previousCampos.x - cam.transform.position.x) * speedParralax[i];

            Vector3 newPosition = new Vector3(paralaxGo[i].transform.position.x + speed, paralaxGo[i].transform.position.y, paralaxGo[i].transform.position.z);

            paralaxGo[i].transform.position = newPosition;
        }

        previousCampos = cam.transform.position;
    }
}
