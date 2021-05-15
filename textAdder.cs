using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textAdder : MonoBehaviour
{
    float timeCount=0;
    int count=0;
    
    public float typingSpeed;
    public Text text;
    public TextAsset lines;
    
    void Start()
    {
        text.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        // The Time.deltaTime (the time for each frames) is added to the timeCount variable to obtain the time since the last change to the text.
        timeCount += Time.deltaTime;
        
        // Everytime the time count is above a certain time then it appends the text to the public text object.
        if (timeCount > 1/(typingSpeed))
        {
            // Checks if the count is still less than the length of the text inputted so that there isn't an OutOfBoundsError.
            if (count < lines.text.Length)
            {
                // Resets the timeCount variable.
                timeCount = 0;
                text.text += lines.text[count];
                count++;

            }

        }

    }
}
