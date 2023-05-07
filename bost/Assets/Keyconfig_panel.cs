using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.EventSystems;
using TMPro;
public class Keyconfig_panel : MonoBehaviour
{
    public enum States { None, Mainset, Subset, Skilltree, LR }
    public States states;
    [SerializeField]
    GameObject Configpanel;
    private int cout = 0;
    private int cout1 = 0;
    public GameObject currentselect;
    public GameObject currentselectframe;
    public GameObject subselect;
    public GameObject subselectgrame;
    public GameObject firstselect;

    private Transform defpos;


    public GameObject currentSubselect;
    public GameObject SubselectText_Left;
    public GameObject SubselectText_Right;



    public Image currenitemicon;
    private void Start()
    {
        states = States.None;
        currentselect = firstselect;
    }
    // Start is called before the first frame update
    void OnEnable()
    {
        currentselect = firstselect;

    }

    // Update is called once per frame
    void Update()
    {

        //if (!currentselect.GetComponent<EquipIcon>().Getskilltree().activeSelf&&states==States.Skilltree)
        // states = States.None;

        if (Playerinput.Instance.Select_Hoz.Value == 1 && cout1 == 0)
        {
            cout1 = 1;
            OnClickRight();

        }
        else if (Playerinput.Instance.Select_Hoz.Value < 0 && cout1 == 0)
        {
            cout1 = 1;
            OnClickLeft();
        }
        else if (Playerinput.Instance.Select_Vert.Value == 1 && cout == 0)
        {
            cout = 1;
            OnClickUp();

        }
        else if (Playerinput.Instance.Select_Vert.Value < 0 && cout == 0)
        {
            cout = 1;
            OnClickDown();
        }
        if (Playerinput.Instance.Skill.Down)
        {
            OnClickChoice();
        }
        if (Playerinput.Instance.Select_Vert.Value == 0)
            cout = 0;
        if (Playerinput.Instance.Select_Hoz.Value == 0)
            cout1 = 0;
    }

    public void OnClickUp()
    {
        if (states == States.None)
        {
            if (currentselect.GetComponent<Keyconfig_Icon>().upicon == null)
                return;
            currentselectframe.transform.position = currentselect.GetComponent<Keyconfig_Icon>().upicon.transform.position;
            currentselect = currentselect.GetComponent<Keyconfig_Icon>().upicon;
            subselect = currentselect;
            //  if (ItemDataBase.Instance.HasItem( currentselect.GetComponent<EquipIcon>().Getskillnamel()))
            defpos = currentselect.transform;
            //currentselect.GetComponent<Image>().DOColor(Color.black, 0.4f).SetLoops(-1, LoopType.Yoyo);
        }
        if (states == States.Mainset)
        {
            if (subselect.GetComponent<Keyconfig_Icon>().upicon == null)
                return;
            subselectgrame.transform.position = subselect.GetComponent<Keyconfig_Icon>().upicon.transform.position;
            subselect = subselect.GetComponent<Keyconfig_Icon>().upicon;

        }

        cout = 1;
    }

    public void OnClickDown()
    {
        if (states == States.None)
        {
            if (currentselect.GetComponent<Keyconfig_Icon>().downicon == null)
                return;
            currentselectframe.transform.position = currentselect.GetComponent<Keyconfig_Icon>().downicon.transform.position;
            currentselect = currentselect.GetComponent<Keyconfig_Icon>().downicon;
            subselect = currentselect;
            //  if (ItemDataBase.Instance.HasItem( currentselect.GetComponent<EquipIcon>().Getskillnamel()))
            defpos = currentselect.transform;
            //currentselect.GetComponent<Image>().DOColor(Color.black, 0.4f).SetLoops(-1, LoopType.Yoyo);
        }
        if (states == States.Mainset)
        {
            if (subselect.GetComponent<Keyconfig_Icon>().downicon == null)
                return;
            subselectgrame.transform.position = subselect.GetComponent<Keyconfig_Icon>().downicon.transform.position;
            subselect = subselect.GetComponent<Keyconfig_Icon>().downicon;
            

        }
        cout = 1;

    }

    public void OnClickLeft()
    {
        if (states == States.None)
        {
            if (currentselect.GetComponent<Keyconfig_Icon>().lefticon == null)
                return;
            currentselectframe.transform.position = currentselect.GetComponent<Keyconfig_Icon>().lefticon.transform.position;
            currentselect = currentselect.GetComponent<Keyconfig_Icon>().lefticon;
            subselect = currentselect;
            //  if (ItemDataBase.Instance.HasItem( currentselect.GetComponent<EquipIcon>().Getskillnamel()))
            defpos = currentselect.transform;
            //currentselect.GetComponent<Image>().DOColor(Color.black, 0.4f).SetLoops(-1, LoopType.Yoyo);
        }
        if (states == States.Mainset)
        {
            if (subselect.GetComponent<Keyconfig_Icon>().lefticon== null)
                return;
            subselectgrame.transform.position = subselect.GetComponent<Keyconfig_Icon>().lefticon.transform.position;
            subselect = subselect.GetComponent<Keyconfig_Icon>().lefticon;

        }
        cout = 1;

    }

    public void OnClickRight()
    {
        if (states == States.None)
        {
            if (currentselect.GetComponent<Keyconfig_Icon>().righticon == null)
                return;
            currentselectframe.transform.position = currentselect.GetComponent<Keyconfig_Icon>().righticon.transform.position;
            currentselect = currentselect.GetComponent<Keyconfig_Icon>().righticon;
            subselect = currentselect;
            //  if (ItemDataBase.Instance.HasItem( currentselect.GetComponent<EquipIcon>().Getskillnamel()))
            defpos = currentselect.transform;
            //currentselect.GetComponent<Image>().DOColor(Color.black, 0.4f).SetLoops(-1, LoopType.Yoyo);
        }
        if (states == States.Mainset)
        {
            if (subselect.GetComponent<Keyconfig_Icon>().righticon == null)
                return;
            subselectgrame.transform.position = subselect.GetComponent<Keyconfig_Icon>().righticon.transform.position;
           subselect = subselect.GetComponent<Keyconfig_Icon>().righticon;

        }
        cout = 1;

    }

    public void OnClickChoice() //トリガースキルの状態のみ管理　残りポイントを見てcurrentkamaに追加する　各スキルのnextattacknameを変更する　SCの更新のみkamapの野良べ替えはattackwrapper
    {
        Playerinput.InputButoon  Change;

        if (states == States.None)
        {
          
            {
                subselectgrame.SetActive(true);
                subselectgrame.transform.position = currentselect.transform.position;
                states = States.Mainset;


            }

        }
        else if (states == States.Mainset)
        {
                Change = subselect.GetComponent<Keyconfig_Icon>().Target;
                subselect.GetComponent<Keyconfig_Icon>().Setbutton(currentselect.GetComponent<Keyconfig_Icon>().Target);
                currentselect.GetComponent<Keyconfig_Icon>().Setbutton(Change);
                currentselect.GetComponent<Keyconfig_Icon>().settarget2(Change);
                subselect.GetComponent<Keyconfig_Icon>().settarget2(currentselect.GetComponent<Keyconfig_Icon>().Target);
                subselect.GetComponent<TextMeshProUGUI>().text = currentselect.GetComponent<TextMeshProUGUI>().text;

                subselectgrame.SetActive(false);
                states = States.None;
            //subselect.GetComponent<Keyconfig_Icon>().Texts = currentselect.GetComponent<Keyconfig_Icon>().Texts;

        }

       
        

    }



}
