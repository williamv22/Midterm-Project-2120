using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDestroyer : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform target;
    void Start()
    {
        
    }

    void Update()
    {
        // Move this object to the position clicked by the mouse.
        transform.LookAt(target);
        bool detection()
        {
            return Physics.Raycast(transform.position, Vector3.forward, 15, gameObject.layer = 9);
        }

        if (detection()){

           // Destroy(gameObject.layer = 9);
        }
    }
}
