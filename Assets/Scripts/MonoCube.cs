using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonoCube: MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if(transform.position.z >= 10) {
            transform.position += new Vector3(0.0f, 0.0f, -1.0f);
        }

        else if(transform.position.z <= -5)
        {
            transform.position += new Vector3(0.0f, 0.0f, 1.0f);
        }
    }
}
