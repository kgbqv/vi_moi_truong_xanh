using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ret : MonoBehaviour
{
    public bool enough;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        enough=false;
        player = GameObject.Find("player");
    }

    // Update is called once per frame
    public void OnCollisionEnter(Collision col){
        if (col.gameObject.layer==2 && enough){
            GameObject.Find("EventHandlers").GetComponent<complete>().finish_Game();
            Invoke("switc",4);
        }
    }

    void switc(){
        SceneManager.LoadScene("mainMenu");
    }
}
