using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Scene01Events : MonoBehaviour
{
    public GameObject fadeScreenIn;
    public GameObject CharMc;
    public GameObject textBox;
    [SerializeField] GameObject nextButton;
    [SerializeField] int EventPos = 0;
   
   

    void Start()
    {
        StartCoroutine(EventStarter());
    }

    IEnumerator EventStarter()
    {
        // event 0
        yield return new WaitForSeconds(1);
        fadeScreenIn.SetActive(false);
        CharMc.SetActive(true);
        yield return new WaitForSeconds(1);
        // this is where our text function will go in future turotial
        nextButton.SetActive(true);
        EventPos = 1;
        
    }

    IEnumerator EventOne()
    {
        nextButton.SetActive(false);
        textBox.SetActive(true);
      yield return new WaitForSeconds(1);
    }

    public void NextButton()
    {
        if (EventPos == 1)
        {
           StartCoroutine(EventOne());
        }
    }
}
