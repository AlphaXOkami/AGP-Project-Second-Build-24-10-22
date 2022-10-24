using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Block : MonoBehaviour
{
    
    [SerializeField]  float Maxhealth = 100;
    private float CurrentHealth;
    public GameObject BlockBall;
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
    public void BlockOn()
    {
        if (BlockBall != null)
        {
            BlockBall.SetActive(true);
        }
       
    }
    public void BlockOff()
    {
        if (BlockBall != null)
        {
            BlockBall.SetActive(false);
        }
    }
    
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("BlockBall"))
        {
            print("Blocked");
            CurrentHealth -= 0;
          
        }
    }
}
