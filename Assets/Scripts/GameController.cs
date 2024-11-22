using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEditor.ShaderGraph.Internal.KeywordDependentCollection;
using System.IO;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif


public class GameController : MonoBehaviour
{

    public  MenuHandler menuHandlerScript;
    public static GameController Instance;
    public string playerName;
    public int MaxScore;
    public int sceneCount = 0;


   


    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
    public void Start()
    {

    }

    [System.Serializable]

    class SaveData
    {
        public string playerName;
        public int MaxScore;
    }

    public void Save(int MaxScor)
    {
       // Debug.Log(playerName);

        SaveData data = new SaveData();
        data.playerName = playerName;
        data.MaxScore = MaxScor;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);


        sceneCount++;
        

    }




    public void Load() 
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {

            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            playerName = data.playerName;
            MaxScore = data.MaxScore;

            //Debug.Log(playerName);
            //Debug.Log(MaxScore);
        }



    }




    public void AAAH()
    {
        playerName = menuHandlerScript.playerName;
    }






}




