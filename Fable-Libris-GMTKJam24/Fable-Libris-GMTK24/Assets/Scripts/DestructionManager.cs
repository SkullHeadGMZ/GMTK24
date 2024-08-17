using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructionManager : MonoBehaviour
{
    public ObjectSelector[] selectors;
    public bool canDestroy;
    // Start is called before the first frame update
    void Start()
    {
        canDestroy = false; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
