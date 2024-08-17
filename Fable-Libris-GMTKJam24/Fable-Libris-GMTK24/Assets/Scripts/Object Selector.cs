using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectSelector : MonoBehaviour
{
    public ObjectPlacer placer;
    public GameObject selectedPiece;
    public GameObject toyPiece;
    public int piecesLeft;
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        text.text = "x" + piecesLeft;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void ChoosePiece()
    {
        placer.playPiece = selectedPiece; ;
        placer.toyPiece = toyPiece;
        placer.selector = gameObject.GetComponent<ObjectSelector>();
    }
}
