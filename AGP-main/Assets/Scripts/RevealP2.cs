using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class RevealP2 : MonoBehaviour
{
    public Image Back;
    public Sprite[] faces;
    private bool reveal = false;
    public Image Face;
    //public Card Card;
    public Animator anim; 

    public void revealface()
    {

        if (reveal == false) 
        {
            Back.enabled = false;
            reveal = true;
            Face.sprite = faces[Random.Range(0, faces.Length)];
        }
        else
        {
            Back.enabled = true;
            reveal = false;
        }
    }
    public int DOACTION(PlayingCards Card)
    {
        switch (Card)
        {
            case PlayingCards.Strike:
                // Strike();
                return 0;
            case PlayingCards.Super:
                //anim.Play("Fireball");
                //anim.Play("Fireball shoot");
                //anim.speed = 1f;
                return 2;
            case PlayingCards.Defence:
                // anim.Play("Block Test");
                // anim.speed = 1f;
                return 1;
            case PlayingCards.Parry:
                 anim.Play("Block Test");
                 anim.speed = 1f;
                return 3;
            
            case PlayingCards.Grab:
                anim.Play("Evade");
                anim.speed = 1f;
                return 4;
            default:
                //
                return 0;  
        }
    }
    
    void Strike()
    {
        anim.Play("Punch");
        anim.speed = 1f;
        
        //damage
    }
    
    void Evade()
    {
        anim.SetTrigger("Evade");
        anim.speed = 1f;
        
        //damage
    }


}
