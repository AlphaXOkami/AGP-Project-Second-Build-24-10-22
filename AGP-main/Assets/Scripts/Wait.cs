using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Wait : MonoBehaviour
{
    public float waittime=5f;
    void Start()
    {
        StartCoroutine(Waitforintro());
    }

    IEnumerator Waitforintro()
    {
        yield return new WaitForSeconds(waittime);


        SceneManager.LoadScene(1);

    }

  
}
