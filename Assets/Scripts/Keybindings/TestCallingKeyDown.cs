using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class TestCallingKeyDown : MonoBehaviour
{
    private InputManager inputManager;
    // Start is called before the first frame update
    private void Start()
    {
        inputManager = InputManager.instance;
    }

    // Update is called once per frame
    void Update()
    {
        if (inputManager.GetKeyDown(KeybindingActions.RotateLeft))
        {
            Debug.Log("Works");
        }
    }
}
