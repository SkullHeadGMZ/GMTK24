using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOffPlacing : MonoBehaviour
{
    // Start is called before the first frame update
    public ObjectPlacer placer;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseOver()
    {
        placer.canPlace = true;
    }

    private void OnMouseExit()
    {
        placer.canPlace = false;
    }
}
