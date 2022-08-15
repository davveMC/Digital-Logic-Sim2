using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This script is creating an object (Keybindings) where you can edit your keybinds inside unity

[CreateAssetMenu(fileName = "Keybindings", menuName = "Keybindings")]
public class Keybindings : ScriptableObject
{
    
    [System.Serializable]

    public class KeybindingCheck
    {
        public KeybindingActions keybindingAction;
        public KeyCode[] keyCode; 
    }
    public KeybindingCheck[] keybindingChecks;


}
