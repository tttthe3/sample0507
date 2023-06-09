﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damaged_turt : SceneLinkedSMB<EnemyBehaviour>
{
    public GameObject effect1;
    float timer = 0f;
    public override void OnSLStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        m_MonoBehaviour.skeletonAnimation.timeScale = 1.4f;
        m_MonoBehaviour.DisableDamage();
        //m_MonoBehaviour.skeletonAnimation.AnimationState.SetAnimation(0, "Zon_damaged", false);
        m_MonoBehaviour.Effectmaker(effect1);
    }

    public override void OnSLStateNoTransitionUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        m_MonoBehaviour.damagedgroundfix();
        
        timer += Time.deltaTime;
        if (timer > 1.2f)
        {
            m_MonoBehaviour.setidle();
            timer = 0f;
        }
        if (timer < 1.1f)
        {

           //m_MonoBehaviour.damagedfreez();
           // timer = 0f;
        }
        m_MonoBehaviour.timerreset(timer);
        
        //m_MonoBehaviour.setidle();
    }



    public override void OnSLStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        m_MonoBehaviour.skeletonAnimation.timeScale = 1f;
        m_MonoBehaviour.setreset();
       // m_MonoBehaviour.setidle();
        timer = 0f;
    }
}