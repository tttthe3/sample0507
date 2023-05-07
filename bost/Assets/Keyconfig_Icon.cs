using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Keyconfig_Icon : MonoBehaviour
{
    public Playerinput.InputButoon Target; //後でこちらも書き換え
    public enum button {Intract,jump,attack,dash,powerattack,skill1,skill2,skill3 };
    public button m_button;
    public Playerinput.PS4ControllerButton self;
    public GameObject lefticon;
    public GameObject righticon;
    public GameObject upicon;
    public GameObject downicon;
    public TextMeshProUGUI Texts;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Setbutton(Playerinput.InputButoon m3_button)
    {
        if (m_button == button.Intract)
            Playerinput.Instance.Intract = m3_button;
        else if (m_button == button.jump)
            Playerinput.Instance.Jump = m3_button;
        else if (m_button == button.attack)
            Playerinput.Instance.Attack= m3_button;
        else if (m_button == button.dash)
            Playerinput.Instance.Dash = m3_button;
        else if (m_button == button.powerattack)
            Playerinput.Instance.PowerAttack = m3_button;
        else if (m_button == button.skill1)
            Playerinput.Instance.Skill = m3_button;
        else if (m_button == button.skill2)
            Playerinput.Instance.Skill2 = m3_button;
        else if (m_button == button.skill3)
            Playerinput.Instance.Skill3 = m3_button;

    }

    public void settarget(button m2_button)
    {
        if (m2_button == button.Intract)
            Target = Playerinput.Instance.Intract;
        else if (m2_button == button.jump)
            Target = Playerinput.Instance.Jump;
        else if (m2_button == button.attack)
            Target = Playerinput.Instance.Attack;
        else if (m2_button == button.dash)
            Target = Playerinput.Instance.Dash;
        else if (m2_button == button.powerattack)
            Target = Playerinput.Instance.Pause;
        else if (m2_button == button.skill1)
            Target = Playerinput.Instance.Skill;
        else if (m2_button == button.skill2)
            Target = Playerinput.Instance.Skill2;
        else if (m2_button == button.skill3)
            Target = Playerinput.Instance.Skill3;
    }
    public void settarget2(Playerinput.InputButoon m2_button)
    {
        
            Target = m2_button;
        
    }

}
