using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEditor;

public class MenuUiHandler : MonoBehaviour
{
    public Text PlayerNameInput;
    // Start is called before the first frame update
    public void StartGame()
    {
        SceneManager.LoadScene(1);
        
    } 

    public void SetPlayerName()
    {
        PlayerDataHandler.instance.playerName = PlayerNameInput.text;
    } 

    public void ExitGame()
    {
#if UNITY_EDITOR
EditorApplication.ExitPlaymode(); 
#else 
Application.Quit();
#endif 

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
