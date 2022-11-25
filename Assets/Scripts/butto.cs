
using UnityEngine;
using UnityEngine.SceneManagement;

public class butto : MonoBehaviour
{
    // Start is called before the first frame update
    
    

    // Update is called once per frame
    public void one(){
        SceneManager.LoadScene("man1");
    }
    public void two(){
        SceneManager.LoadScene("man2");
    }
    public void three(){
        SceneManager.LoadScene("man3");
    }
    public void four(){
        SceneManager.LoadScene("man4");
    }

}
