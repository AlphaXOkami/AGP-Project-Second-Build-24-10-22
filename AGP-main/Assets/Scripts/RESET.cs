using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RESET : MonoBehaviour
{
    public Reveal[] buttons;
    public GameManager Game;

    public void reset()
    {
        foreach (var button in buttons)
        {
          button.Reset();  
        }
        Game.Reset();
    }
}
