using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyboardinputdetection : MonoBehaviour
{
    // Start is called before the first frame update
    string userInput;
    bool userValue;
    
    void Update () {
        
            userInput = bool.TrueString;
            userValue = bool.Parse(userInput);
        
            if (userValue) {
                OnGUI ();
            }
    }
    
    void OnGUI () {
            Event e = Event.current;
            if (e.isKey){
                string key = e.keyCode.ToString();
                Debug.Log(key);
            }
    }
}
