using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] 
    private GameObject[] Characters;
    // Start is called before the first frame update
    

    public void ChangeCharacter(int index)
    {
        for (int i = 0; i < Characters.Length; i++)
        {
            Characters[i].SetActive(false);
        }
        
        Characters[index].SetActive(true);
    }

    public void Start()
    {
        SceneManager.LoadScene(4);
    }
}
