using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Stungun : Itemwrapper
{
    private bool istrigger;
    private GameObject target;
    private float timer = 0f;
    public LayerMask  type;
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<elctric_device>())
        {
            istrigger = true;
            target = collision.gameObject;
            Debug.Log("elec");
        }
        else
        {
            istrigger = false;
            target = null;
        }
    }



    public override void firstframeLeft(Rigidbody2D rb2d, Animator animator, Transform parent)
    {
        RaycastHit2D hitss = Physics2D.Raycast(rb2d.transform.position, Vector2.left,  1f, type);
        if(hitss)hitss.collider.gameObject.GetComponent<elctric_device>().ActivateMove();
        animator.CrossFadeInFixedTime("mask1", 0f);

        Debug.Log("elec");

    }

    public override void updateframeLeft(Rigidbody2D rb2d, Animator animator)
    {
        timer += Time.deltaTime;
        if (timer > 1.2f)
        {
            animator.CrossFadeInFixedTime("idle", 0f);
            timer = 0f;
        }
    }

    public override void endframeLeft()
    {

    }

    public override void firstframeRight(Rigidbody2D rb2d, Animator animator)
    {
        animator.CrossFadeInFixedTime("mask1", 0f);
        if (istrigger)
            target.GetComponent<elctric_device>().ActivateMove();
    }


    public override void updateframeRight(Rigidbody2D rb2d, Animator animator)
    {
        timer += Time.deltaTime;
        if (timer > 1.2f)
        {
            animator.CrossFadeInFixedTime("idle", 0f);
            timer = 0f;
        }
    }

    public override void endframeRight()
    {
     
    }

    public void moves(Rigidbody2D rb2d)
    {

    }
}
