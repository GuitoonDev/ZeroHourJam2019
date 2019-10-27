using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextSequence : MonoBehaviour
{
    public TextMeshProUGUI textReference = null;
    public string[] textArray = null;
    public float secondsBetweenEachText = 2f;
    public float deltaSeconds = 0.2f;

    private void Start()
    {
        StartCoroutine(TextSequenceLoop());
    }

    private IEnumerator TextSequenceLoop(){
        int currentTextSequenceIndex = 0;
        while(true) {
            textReference.text = textArray[currentTextSequenceIndex++];

            if(currentTextSequenceIndex == textArray.Length) {
                currentTextSequenceIndex = 0;
            }

            float randomValue = Random.Range(secondsBetweenEachText - deltaSeconds, secondsBetweenEachText);
            yield return new WaitForSeconds(randomValue);
        }
    }
}
