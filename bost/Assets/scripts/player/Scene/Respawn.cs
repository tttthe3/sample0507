﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Start is called before the first frame update
    public class Respawn : SceneLinkedSMB<Charactercontrolelr>
    {
        public override void OnSLStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            base.OnSLStateEnter(animator, stateInfo, layerIndex);

        m_MonoBehaviour.Locomotionchange();
        }
    }

