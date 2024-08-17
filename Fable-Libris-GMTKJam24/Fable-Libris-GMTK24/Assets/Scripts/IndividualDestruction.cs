using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class IndividualDestruction : MonoBehaviour
{
    public DestructionManager manager;
    public int relatedFinder;
    public GameObject toyCounterpart;
    public GameManager gameManager;
    //bool mousedOver;
    // Start is called before the first frame update
    void Start()
    {
        //usedOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        print("I'm kinda working");
        if (gameManager.phase == GameManager.PlayPhase.Destroy)
        {
            manager.selectors[relatedFinder].piecesLeft++;
            manager.selectors[relatedFinder].text.text = "x" + manager.selectors[relatedFinder].piecesLeft;
            Destroy(toyCounterpart);
            Destroy(gameObject);
        }
    }

   /*Private void OnMouseEnter()
    {
        print("mouse entered");
        mousedOver = true;
    }

    private void OnMouseExit()
    {
        print("mouse left");
        mousedOver = false;
    }*/
}
