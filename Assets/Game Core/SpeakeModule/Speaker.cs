using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speaker : MonoBehaviour {

    /// <summary>
    /// Произносимы dialog
    /// </summary>
    string txt;

    public bool startSpeak;
    bool speachCreat;

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update() {
        if (startSpeak)
        {
            if (!speachCreat)
            {
                Speak("Why not take a look at our training.");
                speachCreat = true;
            }
        }
	}

    /// <summary>
    /// The character makes the speech.
    /// </summary>
    /// <param name="speech"></param>
    public void Speak(string speech)
    {
        txt = speech;
        Debug.Log("Speech: " + txt);
    }

    /// <summary>
    /// Speech weel repesat
    /// </summary>
    public void Repeat()
    {
        Debug.Log("Speech: " + txt);
    }


}
