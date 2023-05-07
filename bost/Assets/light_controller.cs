using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class light_controller : MonoBehaviour
{
    public Light2D light;
    public enum lighttype {onoff,hold };
    public enum Eventtype { colid,other}
    public lighttype Lighttype;
    public Eventtype eventtype;
    public float onofftime;
    private float currentime;
    public Color Aftercolor;
    // Start is called before the first frame update

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Damager>())
            if(eventtype==Eventtype.other)
            light.color = Aftercolor;

    }
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        if (Lighttype == lighttype.onoff)
        {
            light.intensity = Mathf.Sign(2f);
        }

    }
}
