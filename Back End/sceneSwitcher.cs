using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class sceneSwitcher : MonoBehaviour
{
    Scene m_Scene;
    string sceneName;
     
    // Start is called before the first frame update
    private void Start()
     {
        //Player = GameObject.Find();
        m_Scene = SceneManager.GetActiveScene();
        sceneName = m_Scene.name;
        Debug.Log(sceneName);
     }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnMouseDown(){
        var go = EventSystem.current.currentSelectedGameObject;
        if (go != null){
            Debug.Log("Clicked on : "+ go.name);
            if(go.name == "Play game"){
                SwitchScene();
            } else if(go.name == "Instructions"){
                LoadInstructions();
            } else if(go.name == "Exit"){
                QuitApplication();
            }
        }
        else
            Debug.Log("currentSelectedGameObject is null");
    }
    public void SwitchScene(){
        SceneManager.LoadScene("PlayGame");
    }   

    public void LoadInstructions(){
        SceneManager.LoadScene("Instructions");
    }   

    public void QuitApplication(){
        Application.Quit();
        Debug.Log("User quit");
    }
}
