using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Text;
using System.IO;
using System.Collections.Generic;

public class save : MonoBehaviour
{
    // Start is called before the first frame update
    string level;
  //  public GameObject image;
    public Button yes;
  //  public Button no;
    string m_FileName;
    public static string[] str;
    public Canvas ask;
    void Start()
    {
        /* image.SetActive(true);
         yes = this.GetComponent<Button>();
         yes.onClick.AddListener(YES);
         no = this.GetComponent<Button>();
         no.onClick.AddListener(NO);*/
        ask = ask.GetComponent<Canvas>();
        yes = this.GetComponent<Button>();
        yes.onClick.AddListener(YES);
    }

    // Update is called once per frame
    void Update()
    {
       

    }
    void YES()
    {
        // image.SetActive(false);
        ask.enabled = false;
       //Debug.Log("11");
        Write();
    }
 /*   void NO()
    {
        image.SetActive(false);
    }*/
    void Write()
    {
        level = Application.loadedLevelName;
        m_FileName = "load.txt";
        str = File.ReadAllLines(m_FileName);
      //  Debug.Log("11");
        FileStream fs = new FileStream("trueb.txt", FileMode.Open, FileAccess.Write);
        StreamWriter sw = new StreamWriter(fs, Encoding.Default);
        for (int i = 0; i < str.Length; i++)
        {
           // Debug.Log(str[i]);
            sw.WriteLine(str[i]);
        }
        sw.Close();
        FileStream fr = new FileStream("scene.txt", FileMode.Open, FileAccess.Write);
        StreamWriter sr = new StreamWriter(fr, Encoding.Default);
        sr.WriteLine(level);
        sr.Close();
    }
}
