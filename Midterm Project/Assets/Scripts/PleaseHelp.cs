using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PleaseHelp : MonoBehaviour
{
    // Start is called before the first frame update
    Camera cam;
   // public GameObject Enemy;

    void Start()
    {
        cam = GetComponent<Camera>();
        // Enemy = GameObject.FindGameObjectWithTag("Enemy");
        
    }

    void Update()
    {
        Ray ray = cam.ViewportPointToRay(new Vector3(0.5F, 0.5F, 0));
        RaycastHit hit;

        AudioSource audio = GetComponent<AudioSource>();
        if (Physics.Raycast(ray, out hit))
               if (hit.transform.CompareTag("Enemy"))
               {
                   Destroy(GameObject.FindGameObjectWithTag("Enemy"));
                audio.Play();
            }


        
    }
}

