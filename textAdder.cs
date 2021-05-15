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
    // Start is called before the first frame update
    void Start()
    {
        text.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        
        timeCount += Time.deltaTime;
        if (timeCount > 1/(typingSpeed))
        {
            if (count < lines.text.Length)
            {
                timeCount = 0;
                text.text += lines.text[count];
                count++;

            }

        }

    }
}
