using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextSequence : MonoBehaviour
{
    public TextMeshProUGUI textReference = null;
    public string[] textArray;
    public float secondsBetweenEachText = 2f;
    public float deltaSeconds = 0.2f;

    private void Start()
    {
        StartCoroutine(TextSequenceLoop());
    }

    private IEnumerator TextSequenceLoop(){
        int currentTextIndex = 0;
        while(true) {
            float randomValue = Random.Range(secondsBetweenEachText - deltaSeconds, secondsBetweenEachText);
            textReference.text = textArray[currentTextIndex++];

            if(currentTextIndex == textArray.Length) {
                currentTextIndex = 0;
            }

            yield return new WaitForSeconds(randomValue);
        }
    }
}
