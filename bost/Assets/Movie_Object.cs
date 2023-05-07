using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movie_Object : MonoBehaviour
{
    public Flag_content finishflag;
    public StoryFlag flag;
    public Transform AfterMoive_Position;
    public Vector3 AfterSize;
    public enum objecttype {move,size,movesize };
    public objecttype type;
    private void Start()
    {
        if (type == objecttype.move){
            if (finishflag.flag)
                this.transform.position = AfterMoive_Position.position;
            if (flag.GetFlag())
                this.transform.position = AfterMoive_Position.position;
        }

        else if(type == objecttype.size)
        {
            if (flag.GetFlag())
                this.transform.localScale = AfterSize;

        }
        else if (type == objecttype.size)
        {
            if (flag.GetFlag())
            {
                this.transform.localScale = AfterSize;
                this.transform.position = AfterMoive_Position.position;
            }
        }

    }

}
