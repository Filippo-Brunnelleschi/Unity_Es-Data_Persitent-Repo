using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class MenuHandler : MonoBehaviour
{
     public string playerName;
    public GameController gameControllerScript; 


   




    public void EnterName(string s)
    {
        playerName = s;
        gameControllerScript.AAAH();
       // Debug.Log(playerName);
    }





    public void StartGame()
    {
        //gameControllerScript.Save(0);
        SceneManager.LoadScene(1);

    }


    public void ExitGame()
    {

#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit(); // original code to quit Unity player
#endif

    }

    public void BackToMenu()
    {
        SceneManager.LoadScene(0);

    }

 


}
