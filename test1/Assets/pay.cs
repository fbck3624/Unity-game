using UnityEngine;
using System.Collections;
using System.IO;
using UnityEngine.UI;
using System.Collections.Generic;
using System;
using System.Text;

public class pay : MonoBehaviour
{
    // Start is called before the first frame update
    GUIText m_GUIText;
    TextAsset m_TextAsset1;
    string m_Str;
    string m_FileName;
    public static string[] str;
    public static string[] strs;
    int count = 0;

    void Start()
    {
        m_GUIText = gameObject.GetComponent<GUIText>();               //找到該遊戲物體的GUIText元件，用來顯示讀取到 的文字
        m_FileName = "load.txt";
     
        str = File.ReadAllLines(m_FileName);       
        Write();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
  
    void Write()
    {
   
        FileStream fs = new FileStream("load.txt", FileMode.Open, FileAccess.Write);
        StreamWriter sw = new StreamWriter(fs, Encoding.Default);
        string[] s = str[6].Split(':');
        str[6] = s[0] + ":" + Convert.ToString(int.Parse(s[1]) + 500);
        for (int i = 0; i < str.Length; i++)
            {
                Debug.Log(str[i]);
                sw.WriteLine(str[i]);
            }
        sw.Close();
    }
}

