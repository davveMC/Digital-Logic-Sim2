using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InputManager : MonoBehaviour
{
    public static InputManager instance;

    [SerializeField] private Keybindings keybindings;
    
    // Only one instance can run, destroys others.
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

    // This function down below could be neat in the future which is why I added it but it doesn't work properly
    // public KeyCode GetKeyForAction(KeybindingActions keybindingAction)
    // {
    //     foreach(Keybindings.KeybindingCheck keybindingCheck in keybindings.keybindingChecks)
    //     {
    //         if(keybindingCheck.keybindingAction == keybindingAction)
    //         {
    //             return keybindingCheck.keyCode0; // Didn't find a way to send all 4 keys

    //         }
    //     }
    //     return KeyCode.None;
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
                keybindingCheck.keyCode0, 
                keybindingCheck.keyCode1,
                keybindingCheck.keyCode2,
                keybindingCheck.keyCode3
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
                keybindingCheck.keyCode0, 
                keybindingCheck.keyCode1,
                keybindingCheck.keyCode2,
                keybindingCheck.keyCode3
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
                keybindingCheck.keyCode0, 
                keybindingCheck.keyCode1,
                keybindingCheck.keyCode2,
                keybindingCheck.keyCode3
                );
            }
        }

        return false;
    }
}
