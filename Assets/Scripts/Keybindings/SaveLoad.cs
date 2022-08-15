using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class SaveLoad : MonoBehaviour {

    string directoryPath = "";
    public FileInfo[] info;
    public List<string> keys = new List<string>();
    public List<string> keybindings = new List<string>();
    private string[] tmp;
    private List<string> keyAction = new List<string>();

    public void Start()
    { 
        // Debug.Log("Hello");
        directoryPath = Application.dataPath + "/StreamingAssets/Settings/";

        DirectoryInfo dir = new DirectoryInfo(directoryPath);
        info = dir.GetFiles("*.txt");
        // Debug.Log(info);
        // Debug.Log(info.Length);  
           
            foreach (FileInfo f in info) 
            {   
                string filePath = f.ToString();
                Debug.Log(f);

                // string fileNameWithTxt = filePath.Replace(directoryPath, "");
                // avaibleLanguages.Add(fileNameWithTxt.Substring(0, fileNameWithTxt.Length - 4));

                keys.Add(Path.GetFileNameWithoutExtension(filePath));

                StreamReader reader = new StreamReader(filePath); 
                string data = reader.ReadToEnd();
                reader.Close();
                // Take care of data
                // Debug.Log(data);
                string[] actions = data.Split(';');
                // Debug.Log(string.Join(" ", actions));
                // Debug.Log(actions.Length);

                foreach (string action in actions)
                {
                    if (action == "")
                    {continue;};
                    keyAction.Clear();
                    tmp = action.Split('=');
                    keyAction.Add(tmp[0]);
                    keyAction.Add(tmp[1]);
                    keybindings.Add(keyAction);
                    Debug.Log(action);
                }
                Debug.Log(keybindings);
            } 

    }
    public void Save()
    {

    }

    // private void Awake()
    // {
    //     Load();
    // }
}