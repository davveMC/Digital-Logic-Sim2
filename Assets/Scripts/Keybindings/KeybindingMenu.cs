using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// This script will be creating the Keybindings Menu in the future

public class KeybindingMenu : MonoBehaviour
{
    public static KeybindingMenu instance;
    [SerializeField] private Keybindings keybindings;



    // This is scrap for now
    void Start()
    {
        foreach(Keybindings.KeybindingCheck key in keybindings.keybindingChecks)
        {
            GameObject button = new GameObject();
            button.name = "Button";
        }
    }
}
