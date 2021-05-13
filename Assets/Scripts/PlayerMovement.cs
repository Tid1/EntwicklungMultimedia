using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float moveHorizontal;
    float moveVertical;
    float movespeed = 10f;
    float rotationSpeed = 10f;
    float angle;
    Vector3 targetDirection;

    // Start is called before the first frame update
    void Start()
    {
      //  moveHorizontal = Input.GetAxis("Horizontal");
      //  moveVertical = Input.GetAxis("Vertical");
    }

    // Update is called once per frame
    void Update()
    {
        
        float translation = Input.GetAxis("Vertical") * movespeed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
    
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;

        angle += rotation;
        targetDirection = new Vector3(Mathf.Sin(angle), 0, Mathf.Cos(angle));
        transform.Translate(0, 0, translation);

        transform.rotation = Quaternion.LookRotation(targetDirection);

        /*if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * movespeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * movespeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            angle -= 20f * Time.deltaTime;
            transform.rotation = Quaternion.LookRotation(targetDirection);
        }
        if (Input.GetKey(KeyCode.D))
        {
            angle += 20f * Time.deltaTime;
            transform.rotation = Quaternion.LookRotation(targetDirection);
        }
    }*/
    }
}
