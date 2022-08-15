using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InputManager : MonoBehaviour
{
    public static InputManager instance;

    [SerializeField] private Keybindings keybindings;
    
    // Only one instance can run, destroys others. also don't destroys when changing scenes
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

    // Returns all the keys corresponding to the action
    
    // public KeyCode[] GetKeysForAction(KeybindingActions keybindingAction)
    // {
    //     foreach(Keybindings.KeybindingCheck keybindingCheck in keybindings.keybindingChecks)
    //     {
    //         if(keybindingCheck.keybindingAction == keybindingAction)
    //         {
    //             Debug.Log(keybindingCheck.keyCode);
    //             return keybindingCheck.keyCode;
    //         }
    //         return keybindingCheck.keyCode;
    //     }
    // }


    // Checks if the corresponding key to the action is pressed and returns a boolean
    // This also uses AnyOfTheseKeysDown() which I found amost the files (scripts/interactions/InputHelper)
    public bool GetKeyDown(KeybindingActions key)
    {
        // Checks all our keys corresponding to our Action and sends back the result
        foreach(Keybindings.KeybindingCheck keybindingCheck in keybindings.keybindingChecks)
        {
            if(keybindingCheck.keybindingAction == key)
            {
                return InputHelper.AnyOfTheseKeysDown(
                keybindingCheck.keyCode
                );
            }
        }

        return false;
    }

    // Same as upper but with GetKey instead
    public bool GetKey(KeybindingActions key)
    {
        
        foreach(Keybindings.KeybindingCheck keybindingCheck in keybindings.keybindingChecks)
        {
            if(keybindingCheck.keybindingAction == key)
            {
                return InputHelper.AnyOfTheseKeys(
                keybindingCheck.keyCode
                );
            }
        }

        return false;
    }

    // Same as upper but uses GetKeyUp instead
    public bool GetKeyUp(KeybindingActions key)
    {
        foreach(Keybindings.KeybindingCheck keybindingCheck in keybindings.keybindingChecks)
        {
            if(keybindingCheck.keybindingAction == key)
            {
                return InputHelper.AnyOfTheseKeysUp(
                keybindingCheck.keyCode
                );
            }
        }

        return false;
    }
}
