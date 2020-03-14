using UnityEngine;
using System.Collections;
using System.IO;
using UnityEngine.UI;
using System.Collections.Generic;

public class load : MonoBehaviour {
    GUIText m_GUIText;
    TextAsset m_TextAsset1;
    string m_Str;
    string m_FileName;                             
   public static string[] strs;                                        

    void Start()
    {
        m_GUIText = gameObject.GetComponent<GUIText>();               //找到該遊戲物體的GUIText元件，用來顯示讀取到 的文字
        m_FileName = "load.txt";                       //要讀取的檔名，這個是相對路徑
        ReadFile(m_FileName);
    }

    //滑鼠進入該遊戲物體執行 
    void ReadFile(string FileName)
    {
        strs = File.ReadAllLines(FileName);//讀取檔案的所有行，並將資料讀取到定義好的字元陣列strs中，一行存一個單元
        for (int i = 0; i < strs.Length; i++)
        {
            m_Str += strs[i];//讀取每一行，並連起來
            m_Str += "\n";//每一行末尾換行
       
            Debug.Log(strs[i]);
            // GetComponent<Text>().text = strs[i];
            
        }
        GameObject.Find("name").GetComponent<Text>().text = strs[0];
        GameObject.Find("buff").GetComponent<Text>().text = strs[1]+"\n"+ strs[2]+"\n"+ strs[3]+"\n"+ strs[4]+"\n"+ strs[5]+"\n"+strs[6];
    }

}