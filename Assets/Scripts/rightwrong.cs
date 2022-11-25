using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;
using UnityEditor;

public class rightwrong : MonoBehaviour
{
    public bool crrect;
    public GameObject plus;
    public GameObject parent;
    public Animator anim;
    public bool collect(string l,int binNo){
        string[] l1 = {};
        string[] l2 = {"test"};
        string[] l3 = {"box","bag","can"};
        //sactivate compile
        switch (binNo){
            case 1:
                parent.GetComponent<RectTransform>().anchoredPosition = new Vector2(-276,-86);
                if (l1.Contains(l)){
                    correct();
                    return true;
                    
                } else {
                    incorrect();
                    return false;
                    
                }
                break;
            case 2:
                parent.GetComponent<RectTransform>().anchoredPosition = new Vector2(-111,-86);
                if (l2.Contains(l)){
                    correct();
                    return true;
                    
                }   else {
                    incorrect();
                    return false;
                    
                }
                break;
            case 3:
                parent.GetComponent<RectTransform>().anchoredPosition = new Vector2(84,-86);
                if (l3.Contains(l)){
                    correct();
                    return true;
                    
                } else {
                    incorrect();
                    return false;
                    
                }
                break;
            default:
                return false;
                break;
        }
    }
    void correct(){
        plus.GetComponent<Text>().text = "+1";
        call();
    }

    void call(){
        plus.SetActive(true);
        anim = plus.GetComponent<Animator>();
        anim.SetBool("Pop",true);
        
        Invoke("stop",0.5f);
    }

    void stop(){
        anim.SetBool("Pop",false);
        plus.SetActive(false);
    }

    void incorrect(){
        plus.GetComponent<Text>().text = "-1";
        call();
    }

}
