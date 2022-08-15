using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Rebinding : MonoBehaviour
{
    private InputManager inputManager;

    [SerializeField] private Keybindings keybindings;

    private string keybindText;


    [SerializeField] private TextMeshProUGUI keybindTextUI;

    private void Start()
    {
        keybindTextUI.text = keybindText;
        // inputManager = InputManager.instance;
    }

    private void Awake()
    {
        inputManager = InputManager.instance;
        Debug.Log("Awake");
        // Debug.Log(typeof(KeybindingActions));
        foreach(KeybindingActions action in System.Enum.GetValues(typeof(KeybindingActions)))
        {
            // Debug.Log("Action: " + action);
            keybindText += "<line-height=40%>\n</line-height><color=#D9D9D9><size=100%>"
            + action
            + "</size></color><line-height=40%>\n</line-height>";
            // Debug.Log(inputManager);
            // var keys = inputManager.GetKeysForAction(action);
            // Debug.Log(keys);
            // keybindText += keys;
            // foreach(var key in keys)
            // {   
            //     // Debug.Log(action);
            //     // Debug.Log("Key: " + key);
            // }
        }
    }


}
