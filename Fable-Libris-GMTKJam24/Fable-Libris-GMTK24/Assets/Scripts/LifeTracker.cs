using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeTracker : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] lifesprites;
    public GameObject player;
    public int currentLifeSprite;
    void Start()
    {
        currentLifeSprite = lifesprites.Length-1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoseLife(int lifeLost)
    {
        player.GetComponent<CharacterControls>().life -= lifeLost;
        //if lifelost >0, turn find highest number in array that is turned on
        //turn that off and subtract 1 from life loss
        //repeat until lifeloss = 0
    }

    public void GainLife()
    {

    }
}
