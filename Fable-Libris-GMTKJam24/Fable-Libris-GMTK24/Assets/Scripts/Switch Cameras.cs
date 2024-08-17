using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCameras : MonoBehaviour
{
    public Camera kidCam;
    public Camera playCam;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            SwapCams();
        }
    }

    public void SwapCams()
    {
        if (kidCam.gameObject.activeSelf == true)
        {
            kidCam.gameObject.SetActive(false);
            playCam.gameObject.SetActive(true);
        }
        else if (kidCam.gameObject.activeSelf == false)
        {
            kidCam.gameObject.SetActive(true);
            playCam.gameObject.SetActive(false);
        }
    }
}
