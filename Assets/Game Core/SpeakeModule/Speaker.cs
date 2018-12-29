using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speaker : MonoBehaviour {

    /// <summary>
    /// Произносимы dialog
    /// </summary>
    string txt;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
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
