using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VirtualButtonHandler: MonoBehaviour
{
    public GameObject player;
    public float moveSpeed;
    public float angle = 0;
    private bool forwardPressed;
    private bool backwardPressed;
    private bool leftPressed;
    private bool rightPressed;

    // Start is called before the first frame update
    void Start()
    {
        VirtualButtonBehaviour[] vbs = GetComponentsInChildren<VirtualButtonBehaviour>();
        Debug.Log(vbs.Length);
        for(int i = 0; i < vbs.Length; ++i) {
            vbs[i].RegisterOnButtonPressed(OnButtonPressed);
            vbs[i].RegisterOnButtonReleased(OnButtonReleased);
       }
    }

   public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        switch (vb.VirtualButtonName)
        {
            case "ForwardButton":
       
                forwardPressed = true;
                Debug.Log("Forward Button triggered");
                break;
            case "BackwardButton":
                
                backwardPressed = true;
                Debug.Log("Backward Button triggered");
                break;
            case "LeftRotationButton":
                leftPressed = true;
                Debug.Log("Left Button triggered");
                break;
            case "RightRotationButton":
                rightPressed = true;
                Debug.Log("Right Button triggered");
                break;
            default:
                break;
        }
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        switch (vb.VirtualButtonName)
        {
            case "ForwardButton":
                forwardPressed = false;
                Debug.Log("Forward Button released");
                break;
            case "BackwardButton":
                backwardPressed = false;
                Debug.Log("Backward Button released");
                break;
            case "LeftRotationButton":
                leftPressed = false;
                Debug.Log("Left Button released");
                break;
            case "RightRotationButton":
                rightPressed = false;
                Debug.Log("Right Button released");
                break;
            default:
                break;
        }
    }

    private void Update()
    {
        if (forwardPressed)
        {
            player.transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }

        if (backwardPressed) 
        {
            player.transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
        }

        if (leftPressed)
        {
            angle -= 5f * Time.deltaTime; 
        }

        if (rightPressed)
        {
            angle += 5f * Time.deltaTime;
        }
        Debug.Log("Angle: " + angle);
        Vector3 targetDirection = new Vector3(Mathf.Sin(angle), 0, Mathf.Cos(angle));
        player.transform.rotation = Quaternion.LookRotation(targetDirection);

    }
 
}
