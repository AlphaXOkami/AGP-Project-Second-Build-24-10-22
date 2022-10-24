using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player1 : MonoBehaviour
{
    
    [SerializeField]  float Maxhealth = 100;
    private float CurrentHealth;
    [Header("Punch Combo HitSpheres")]
    public GameObject Punchball;
    public GameObject Punchball2;
    public int punchdamage;

    public Text healthText;
    private Vector3 OriginalPos;
    
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
        Punchball.SetActive(true);
    }
    public void PunchOff()
    {
        Punchball.SetActive(false);
    }

    public void EndofPunchAnim()
    {
        transform.position = OriginalPos;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PunchBall"))
        {
          print("Attack");
          CurrentHealth -= punchdamage;
          
        }
    }
}
