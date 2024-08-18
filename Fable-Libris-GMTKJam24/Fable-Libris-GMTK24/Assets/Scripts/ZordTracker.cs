using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZordTracker : MonoBehaviour
{
    public GameObject[] zordUI;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < zordUI.Length; i++)
        {
            zordUI[i].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CollectPart(int partNum)
    {
        zordUI[partNum].gameObject.SetActive(true);
    }
}
