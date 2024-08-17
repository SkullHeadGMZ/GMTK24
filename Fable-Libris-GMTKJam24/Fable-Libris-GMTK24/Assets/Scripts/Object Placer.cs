using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPlacer : MonoBehaviour
{
    public GameObject playPiece;
    public GameObject toyPiece;
    public Vector3 placingCoordinates;
    public Vector3 kidCoordinates;
    public bool canPlace;
    public ObjectSelector selector;
    // Start is called before the first frame update
    void Start()
    {
        canPlace = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && canPlace == true)
        {
            PlaceObject();
        }
    }

    public void PlaceObject()
    {
        if (selector != null && selector.piecesLeft > 0)
        {
            Instantiate(playPiece, new Vector3(placingCoordinates.x, placingCoordinates.y, placingCoordinates.z), Quaternion.identity);
            Instantiate(toyPiece, new Vector3(kidCoordinates.x, kidCoordinates.y, kidCoordinates.z), Quaternion.identity);
            selector.piecesLeft --;
            selector.text.text = "x" + selector.piecesLeft;
        }
        else
        {
            return;
        }
    }
}
