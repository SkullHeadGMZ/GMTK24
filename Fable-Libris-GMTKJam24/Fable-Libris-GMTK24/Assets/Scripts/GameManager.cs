using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public PlayPhase phase;
    public GameObject placeButt;
    public GameObject destroyButt;
    public GameObject kidUI;
    public GameObject toyUI;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void SwitchToToyMode() {
        phase = PlayPhase.Toy;
        kidUI.SetActive(false);
        toyUI.SetActive(true);
    }
    public void SwitchToDestructionMode()
    {
        phase = PlayPhase.Destroy;
        kidUI.SetActive(true);
        toyUI.SetActive(false);
        placeButt.SetActive(true);
        destroyButt.SetActive(false);
    }
    public void SwitchToPlacingMode()
    {
        phase = PlayPhase.Place;
        kidUI.SetActive(true);
        toyUI.SetActive(false);
        placeButt.SetActive(false);
        destroyButt.SetActive(true);
    }

    public enum PlayPhase
    {
        Toy,
        Destroy,
        Place
    }
}
