using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Scene01Events : MonoBehaviour
{
    public GameObject fadeScreenIn;
    public GameObject CharMc;
    public GameObject textBox;

   
   

    void Start()
    {
        StartCoroutine(EventStarter());
    }

    IEnumerator EventStarter()
    {
        yield return new WaitForSeconds(1);
        fadeScreenIn.SetActive(false);
        CharMc.SetActive(true);
        yield return new WaitForSeconds(1);
        // this is where our text function will go in future turotial
    
        textBox.SetActive(true);
    }
}
