using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InputManager : MonoBehaviour
{
    public static InputManager instance;

    [SerializeField] private Keybindings keybindings;
    
    // instance = this;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else if(instance != null)
        {
            Destroy(this);
        }
        DontDestroyOnLoad(this);
    }
    public KeyCode GetKeyForAction(KeybindingActions keybindingAction)
    {
        Debug.Log("HERE!123333123");
        foreach(Keybindings.KeybindingCheck keybindingCheck in keybindings.keybindingChecks)
        {
            if(keybindingCheck.keybindingAction == keybindingAction)
            {
                return keybindingCheck.keyCode;
            }
        }
        return KeyCode.None;
    }
    public bool GetKeyDown(KeybindingActions key)
    {
        Debug.Log("Herer fucker");
        foreach(Keybindings.KeybindingCheck keybindingCheck in keybindings.keybindingChecks)
        {
            Debug.Log("HERE123!");
            if(keybindingCheck.keybindingAction == key)
            {
                Debug.Log(keybindingCheck.keyCode);
                Debug.Log("HERE!");
                return Input.GetKeyDown(keybindingCheck.keyCode);
            }
        }

        return false;
    }
    public bool GetKey(KeybindingActions key)
    {
        foreach(Keybindings.KeybindingCheck keybindingCheck in keybindings.keybindingChecks)
        {
            if(keybindingCheck.keybindingAction == key)
            {
                return Input.GetKey(keybindingCheck.keyCode);
            }
        }

        return false;
    }
    public bool GetKeUp(KeybindingActions key)
    {
        foreach(Keybindings.KeybindingCheck keybindingCheck in keybindings.keybindingChecks)
        {
            if(keybindingCheck.keybindingAction == key)
            {
                return Input.GetKeyUp(keybindingCheck.keyCode);
            }
        }

        return false;
    }
}