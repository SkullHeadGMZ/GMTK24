using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSelector : MonoBehaviour
{
    public ObjectPlacer placer;
    public GameObject selectedPiece;
    public GameObject toyPiece;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void ChoosePiece()
    {
        placer.playPiece = selectedPiece; ;
        placer.toyPiece = toyPiece;
    }
}
