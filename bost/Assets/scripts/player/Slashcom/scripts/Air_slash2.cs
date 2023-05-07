﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Rewired.ComponentControls;
using DG.Tweening;

using Spine.Unity;
public class Air_slash2 : Kama_Compo
{

    private float currenttime = 0f;
    public string Nextattackname;
    public Tween attacks;
    private GameObject m_sound;
    private Damager damagess;
    // Start is called before the first frame update

    // Start is called before the first frame update
    public override void air_firstframes(Rigidbody2D rb2d, float newHorizontalMovement, Animator animator, Transform parent, SkeletonAnimation skeletonAnimation)
    {
      skeletonAnimation.timeScale = 2.1f;
       skeletonAnimation.AnimationState.SetAnimation(0, "air_slash7", false);
        currenttime = 0f;
        if (m_sound == null)
            m_sound = Instantiate(sounds, this.transform.position, Quaternion.identity);
        //Slash_first = parent.Find("sounds/Slash/Slash1").GetComponent<RandomAudioPlayer>();
        if (damagess == null)
            damagess = parent.Find("SkeletonUtility-SkeletonRoot/root/kama1").GetComponent<Damager>();
        Debug.Log(damagess);
        rb2d.velocity = new Vector2(Charactercontrolelr.CCInstance.m_SpriteForward.x * newHorizontalMovement, 0f);
        DOVirtual.DelayedCall(0.4f, () => Playsound(m_sound.GetComponent<RandomAudioPlayer>()), false);
        damagess.havemove = Damager.movestate.hold;
    }

    public override void air_updateframes(Rigidbody2D rb2d, float newHorizontalMovement, Animator animator, Transform parent)
    {
        Debug.Log("WWW");
        currenttime += Time.deltaTime;

        if (currenttime < 0.8f)
        {
            damagess.enabled = true;
            //joystick.SetVibration(2f,2f);
            rb2d.velocity = new Vector2(0f, 3f);
            if (Playerinput.Instance.Attack.Down)
            {
                if (currenttime > 0.4f)
                {
                    damagess.enabled = false;
                    DOVirtual.DelayedCall(0.4f, () => Playsound(Slash_second), false);
                    //  if (nextattck.Getflag())
                    {
                        DOVirtual.DelayedCall(0.4f, () => Playsound(Slash_second), false);
                        currenttime = 0;
                        animator.CrossFadeInFixedTime("air_slash4", 0f);
                        damagess.enabled = false;
                        //ここでcurrentcombを変える



                    }

                }

            }




        }
        else
        {
            animator.CrossFadeInFixedTime("jumpdown", 0f);
            damagess.enabled = false;
        }
        Debug.Log("fat22faffe32");
    }

}
