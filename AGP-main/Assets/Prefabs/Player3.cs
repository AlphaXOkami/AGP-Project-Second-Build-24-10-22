using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class Player3 : MonoBehaviour
{
    
    [SerializeField]  float Maxhealth = 100;
    private float CurrentHealth;
    public GameObject Punchball;
    public GameObject BlockBall;
    public int punchdamage;

    public Text healthText;
    private Vector3 OriginalPos;
    public GameObject Endfont;
    private Vector3 StartingPos;
    
    // Start is called before the first frame update
    void Start()
    {
        CurrentHealth = Maxhealth;
        OriginalPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = CurrentHealth.ToString();
    }

    public void PunchOn()
    {
        if (Punchball != null)
        {
            Punchball.SetActive(true);
        }
       
    }
    public void PunchOff()
    {
        if (Punchball != null)
        {
            Punchball.SetActive(false);
        }
    }

    public void EndofPunchAnim()
    {
        transform.position = OriginalPos;
    }



    public void EvadeStart()
    {
        StartingPos = transform.position;
    }

    public void EvadeEnd()
    {
        transform.position = StartingPos;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PunchBall"))
        {
          print("Attack");
          CurrentHealth -= punchdamage;
          if (CurrentHealth<=0)
          {
              Endfont.SetActive(true);
              StartCoroutine(mainmenu());
          }
        }
        
        

        IEnumerator mainmenu()
        {
            yield return new WaitForSeconds(2f);
            SceneManager.LoadScene("Main Menu");

        }
    }
    
    
    
    
  
   
}

