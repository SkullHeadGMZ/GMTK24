using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoordinateFinder : MonoBehaviour
{
    public ObjectPlacer placer;
    public Vector3 kidVector;
    public Vector3 PlayVector;
    // Start is called before the first frame update
    void Start()
    {
       kidVector = new Vector3(transform.position.x,transform.position.y,transform.position.z-5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseEnter()
    {
        placer.kidCoordinates = kidVector;
        placer.placingCoordinates = PlayVector;
    }

    private void OnMouseOver()
    {
        placer.canPlace = true;
    }
}
