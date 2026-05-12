using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Scene01Events : MonoBehaviour
{
    public GameObject fadeScreenIn;
    public GameObject CharMc;
    public GameObject textBox;

    [SerializeField] string textToSpeak;
    [SerializeField] int currentTextLength;
    int textLength;
    [SerializeField] GameObject mainTextObject;
    
    void Update()
    {
       textLength = TextCreator.charCount;
    }

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
        mainTextObject.SetActive(true);
        textToSpeak = "I'm late to school AGAIN. (names) Going to be sooo mad... I'd better hurry.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
       
        textBox.SetActive(true);
    }
}
