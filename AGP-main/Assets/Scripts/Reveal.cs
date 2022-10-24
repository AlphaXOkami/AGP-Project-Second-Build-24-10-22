using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;
using System;

public enum Character
{
    player,enemy
}

public class Reveal : MonoBehaviour
{
    public Image Back;
    public Sprite[] faces;
    private bool reveal = false;
    public Image Face;
    //public Card Card;
    public Animator anim;
    [FormerlySerializedAs("GameManager")] public GameManager gameManager;
    public Character character;
    [HideInInspector]public Action action;

    public void Reset()
    {
        Back.enabled = true;
        reveal = false;
    }

    public void Revealface(int CardNumber)
    {
        if (character==Character.player)
        {
            PlayerReveal(CardNumber);
        }
        else
        {
            EnemyReveal(CardNumber);
        }

    }


    private void PlayerReveal(int CardNumber)
    {
        if (reveal == false) 
        {
            Back.enabled = false;
            reveal = true;
            var doaction=DOACTION(gameManager.player1Cards[CardNumber]);
            Face.sprite = faces [doaction.Item1];
            action = doaction.Item2;
            gameManager.CardSelected(Character.player,action);
            

        }
        else
        {
            action.Invoke();
            Back.enabled = true;
            reveal = false;
        } 
    }
    private void EnemyReveal(int CardNumber)
    {
        if (reveal == false) 
        {
            Back.enabled = false;
            reveal = true;
            var doaction=DOACTION(gameManager.player2Cards[CardNumber]);
            Face.sprite = faces [doaction.Item1];
            action = doaction.Item2;
            gameManager.CardSelected(Character.enemy,action);
        }
        else
        {
            action.Invoke();
            Back.enabled = true;
            reveal = false;
        }
    }

    public (int,Action) DOACTION(PlayingCards Card)
    {
        switch (Card)
        {
            case PlayingCards.Strike:
               // Strike();
                return (0,Strike);
            case PlayingCards.Super:
                //anim.Play("Fireball");
                //anim.Play("Fireball shoot");
                //anim.speed = 1f;
                return (2,Strike);
            case PlayingCards.Defence:
               // anim.Play("Block Test");
               // anim.speed = 1f;
                return (1,Defence);
            case PlayingCards.Parry:
               // anim.Play("Block Test");
               // anim.speed = 1f;
                return (3,Defence);
            
            case PlayingCards.Grab:
               // anim.Play("Block Test");
               // anim.speed = 1f;
                return (4,Evade);
            default:
             //
             return (0,Evade);  
        }
    }
    
    void Strike()
    {
        anim.SetTrigger("Punch");
        anim.speed = 1f;
        
        //damage
    }
    
    void Defence()
    {
        anim.SetTrigger("Block");
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
