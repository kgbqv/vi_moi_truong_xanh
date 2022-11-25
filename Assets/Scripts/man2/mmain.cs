using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class mmain : MonoBehaviour
{
    public Text b1;
    public Text b2;
    public Text b3;
    public Text t;
    public Text confirm;
    int index;
    int currtraloi;
    public GameObject yaey;
    CanvasGroup n = new CanvasGroup();
    public List<string> cHoi= new List<string> {"Chúng ta phải làm gì đối với chất thải rắn sinh hoạt có thể được tái chế?"};
    public List<string> cauA = new List<string> {"Làm phân bón"};
    public List<string> cauB = new List<string> {"Làm thức ăn chăn nuôi"};
    public List<string> cauC = new List<string> {"Chuyển giao cho tổ chức, cá nhân tái sử dụng, tái chế"};
    public List<int> cTL = new List<int> {2};
    void Start(){
        
        n = GameObject.Find("Canvas").GetComponent<CanvasGroup>();
        b1 = GameObject.Find("buttonA").transform.GetChild(0).GetComponent<Text>();
        b2 = GameObject.Find("buttonB").transform.GetChild(0).GetComponent<Text>();
        b3 = GameObject.Find("buttonC").transform.GetChild(0).GetComponent<Text>();
        t = GameObject.Find("quesT").GetComponent<Text>();
        confirm = GameObject.Find("confirm").GetComponent<Text>();
        
        disp();
    }
    void disp(){
        n.interactable=true;
        index = Random.Range(0,cHoi.Count);
        
        t.text = cHoi[index];
        b1.text = cauA[index];
        b2.text = cauB[index];
        b3.text = cauC[index];
        currtraloi = cTL[index];
        confirm.text="";
        b1.fontStyle=FontStyle.Normal;
        b2.fontStyle=FontStyle.Normal;
        b3.fontStyle=FontStyle.Normal;
    }
    public void press(int no){
        n.interactable = false;
        if (no == currtraloi){
            confirm.text="Đúng rồi!";
            switch(no){
                case 0:
                    b2.text = "";
                    b3.text = "";
                    b1.fontStyle = FontStyle.Bold;
                    break;
                case 1:
                    b1.text = "";
                    b3.text = "";
                    b2.fontStyle = FontStyle.Bold;
                    break;
                case 2:
                    b2.text = "";
                    b1.text = "";
                    b3.fontStyle = FontStyle.Bold;
                    break;
                default:
                    break;
                
            }
            cHoi.RemoveAt(index);
            cauA.RemoveAt(index);
            cauB.RemoveAt(index);
            cauC.RemoveAt(index);
            cTL.RemoveAt(index);

        } else {
            confirm.text="Chưa đúng, đáp án là:";
            switch(currtraloi){
                case 0:
                    b2.text = "";
                    b3.text = "";
                    b1.fontStyle = FontStyle.Bold;
                    break;
                case 1:
                    b1.text = "";
                    b3.text = "";
                    b2.fontStyle = FontStyle.Bold;
                    break;
                case 2:
                    b2.text = "";
                    b1.text = "";
                    b3.fontStyle = FontStyle.Bold;
                    break;
                default:
                    break;
            }
        }
        Invoke("done",2.5f);
        
    }
    public void done(){
        if (cHoi.Count == 0){
            yaey.SetActive(true);
            Invoke("sw",2.5f);
        } else {
            disp();
        }
    }
    void sw(){
        SceneManager.LoadScene("mainMenu");
    }
    
    
}
