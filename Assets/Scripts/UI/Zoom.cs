using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zoom : MonoBehaviour
{
    public Vector3 scaleChange;
    Vector3 scale = new Vector3(1, 1, 1);
    public float min;
    public float max;
    float interactionNum = 0.25f;
    public GameObject[] objectsToZoom;
    public ChipInteraction _chipInteraction;
    float scroll;
    public float zoom = 1;
    void Update()
    {   
        scroll = Input.GetAxis("Mouse ScrollWheel");
        // Debug.Log(scroll);
        _chipInteraction = GameObject.FindWithTag("Interaction").GetComponent<ChipInteraction>(); 
        objectsToZoom = GameObject.FindGameObjectsWithTag("Zoom");
        if (scroll != 0) {
            scale.x -= scroll * zoom;
            scale.y -= scroll * zoom;
            scale.z -= scroll * zoom;
            interactionNum -= scroll * zoom;
        }

        _chipInteraction.selectionBoundsBorderPadding = interactionNum;
        for (int i = 0; i < objectsToZoom.Length; i++) {
            objectsToZoom[i].transform.localScale = scale;
        }
        // scale -= Input.GetAxis("Mouse ScrollWheel")
        // Debug.Log(Input.GetAxis("Mouse ScrollWheel"));
    }
}