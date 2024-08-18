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
       /*if (Input.GetKeyUp(KeyCode.Space))
        {
            GainLife(1);
            //print("Losing life");
        }*/
    }

    public void LoseLife(int lifeLost)
    {
            for (int i = lifesprites.Length; i > 0; i--)
            {
                if (lifeLost > 0)
                {
                    if (lifesprites[i - 1].activeSelf == true)
                    {
                        lifesprites[i-1].SetActive(false);
                        player.GetComponent<CharacterControls>().life--;
                        lifeLost--;
                    }
                }
            }
        }

    public void GainLife(int lifeGained)
    {
        for (int i = 0; i < lifesprites.Length; i++)
        {
            if (lifeGained > 0)
            {
                if (lifesprites[i].activeSelf == false)
                {
                    lifesprites[i].SetActive(true);
                    player.GetComponent<CharacterControls>().life++;
                    lifeGained--;
                }
            }
        }
    }
}
