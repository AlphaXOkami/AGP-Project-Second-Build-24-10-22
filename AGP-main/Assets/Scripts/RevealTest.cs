using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class RevealTest : MonoBehaviour
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

      // public void DOACTION()
    // {
    //     switch (Card)
    //     {
    //         case Card.Strike:
    //             anim.Play("");
    //             anim.speed = 1f;
    //             break;
    //         case Card.Super:
    //             anim.Play("Fireball");
    //             anim.Play("Fireball shoot");
    //             anim.speed = 1f;
    //             break;
    //         case Card.Defence:
    //             anim.Play("Block Test");
    //             anim.speed = 1f;
    //             break;
    //         case Card.Parry:
    //             anim.Play("Block Test");
    //             anim.speed = 1f;
    //             break;
    //      default:
    //          //
    //           break;  
     //     }
     // }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
