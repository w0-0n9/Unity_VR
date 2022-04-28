using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ItemClick : MonoBehaviour
{
    public UnityEvent unityEvent;
    public GameObject button;
    
    // Start is called before the first frame update
    void Start()
    {
        button = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(ray, out hit) && hit.collider.gameObject == gameObject)
            {
                unityEvent.Invoke();
            }
        }
    }
}
