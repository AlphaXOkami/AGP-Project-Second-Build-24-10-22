using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterController : MonoBehaviour
{
    private bool Character1 = true;
    public Image Banner1;
    public Image Banner2;

    private Image SelectedBanner;
    // Start is called before the first frame update
    void Start()
    {
        SelectedBanner = Banner1;
    }

    public Image GetBanner()
    {
        return SelectedBanner;
    }

    public  void SelectBanner()
    {
        if (Character1==true)
        {
            SelectedBanner=Banner2;
            Character1 = false;
        }
        else
        {
            SelectedBanner=Banner1;
            Character1 = true;
        }
    }

}
