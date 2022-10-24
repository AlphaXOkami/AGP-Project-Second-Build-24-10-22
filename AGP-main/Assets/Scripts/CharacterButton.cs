using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterButton : MonoBehaviour
{
    public Sprite CharacterPortraits;
    private Image Banner;
    public CharacterController CC;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void ViewImage()
    {
        Banner = CC.GetBanner();
        Banner.sprite = CharacterPortraits;
        Banner.preserveAspect = true;
        var Alpha = Banner.color;
        Alpha.a = 1;
        Banner.color = Alpha;
    }

    public void SelectImage()
    {
        CC.SelectBanner();
    }
}
