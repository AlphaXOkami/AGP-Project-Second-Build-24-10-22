using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Random = UnityEngine.Random;


public enum PlayingCards
{
    Strike,Defence,Super,Parry,Grab
}
public class GameManager : MonoBehaviour
{
    public List<PlayingCards> player1Cards;
    public List<PlayingCards> player2Cards;
    private  Action playerAction;
    private Action enemyAction;

    private int[] cardNumbers = new[] {0,1, 2, 3, 4};
    private bool EnemySelected = false;
    private bool PlayerSelected = false;

    public GameObject PlayButton;
    // Start is called before the first frame update
    void Start()
    {
        Reset();
    }

    public void CardSelected(Character character,Action action)
    {
        if (character==Character.player)
        {
            PlayerSelected = true;
            playerAction = action;
            
        }
        if (character==Character.enemy)
        {
            EnemySelected = true;
            enemyAction = action;
        }

        if (PlayerSelected==true && EnemySelected==true)
        {
            PlayButton.SetActive(true);
        }
    }
    
    
    
    // Update is called once per frame
    void Update()
    {
        
    }

     public void ShuffleCards()
    {
        for (int i = 0; i < 100; i++)
        {
            var r1 = Random.Range(0, 5);
            var r2 = Random.Range(0, 5);
            var temp = cardNumbers[r1];
            cardNumbers[r1] = cardNumbers[r2];
            cardNumbers[r2] = temp;
        }
        
    }

    public void FIGHT()
    {
        playerAction.Invoke();
        enemyAction.Invoke();
    }

    public void Reset()
    {
        player1Cards.Clear();
        player2Cards.Clear();
        
        ShuffleCards();
        for (int i = 0; i < 5; i++)
        {
            player1Cards.Add((PlayingCards)cardNumbers[i]);
        }
        ShuffleCards();
        for (int i = 0; i < 5; i++)
        {
            player2Cards.Add((PlayingCards)cardNumbers[i]);
        }
    }
}
