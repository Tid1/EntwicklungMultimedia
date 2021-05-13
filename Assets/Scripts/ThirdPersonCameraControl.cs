using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCameraControl : MonoBehaviour
{
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {  
        Vector3 offsetRotation = target.rotation * new Vector3(0, -5, 10);
        Vector3 cameraPos = target.position - offsetRotation;
        transform.position = cameraPos;
        transform.rotation = Quaternion.LookRotation(offsetRotation);
        //transform.LookAt(target.position);
    }
}
