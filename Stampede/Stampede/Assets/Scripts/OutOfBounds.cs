using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBounds : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > 30f)
        {
            Destroy(gameObject);
        }
        if (transform.position.z < -15f)
        {
            Destroy(gameObject);
        }
    }
}
