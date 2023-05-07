using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class elctric_device : MonoBehaviour
{
    
    public StoryFlag Activate;
    public GameObject Activeobjects;
    public UnityEvent callafter;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActivateMove()
    {
        Activate.SetFlag();
        Activeobjects.SetActive(true);
        callafter.Invoke();
    }
}
