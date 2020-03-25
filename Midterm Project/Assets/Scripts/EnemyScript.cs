using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public GameObject Enemy;
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            print("Destroy");
            Destroy(Enemy);
        }
    }

    // Update is called once per frame
    void Update()
    {
        AudioSource audio = GetComponent<AudioSource>();
        transform.LookAt(target);
        bool detection()
        {
            return Physics.Raycast(transform.position, Vector3.forward, 50, gameObject.layer = 9);
        }
        if (detection())
        {
            audio.Play();
            Destroy(Enemy);
        }
    }
}
