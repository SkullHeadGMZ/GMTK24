using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutlineChanger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ChangeColor();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeColor()
    {
        if (gameObject.GetComponentInParent<IndividualDestruction>() == null)
        {
            gameObject.GetComponent<SpriteRenderer>().color = Color.red;
        }

        else { 
            gameObject.GetComponent<SpriteRenderer>().color = Color.cyan;
        }
    }
}
