﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class normal_idle : SceneLinkedSMB<EnemyBehaviour>
{
    float timer = 0f;
    public override void OnSLStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

        m_MonoBehaviour.skeletonAnimation.AnimationState.SetAnimation(0, "normal_idle", true);

    }

    public override void OnSLStateNoTransitionUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

        // We do this explicitly here instead of in the enemy class, that allow to handle obstacle differently according to state
        // (e.g. look at the ChomperRunToTargetSMB that stop the pursuit if there is an obstacle) 
        float dist = m_MonoBehaviour.speed;
        if (m_MonoBehaviour.CheckForObstacle(dist))
        {

        }


        m_MonoBehaviour.ScanForPlayer();
    }



    public override void OnSLStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {


    }
}
