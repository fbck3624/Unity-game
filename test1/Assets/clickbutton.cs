using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;
using System;
using System.Text;
using System.Collections.Generic;

public class clickbutton : MonoBehaviour
{
     public Button startnew;
     public Button exit;
     public Button load;
     string m_FileName;
    public static string[] str;
     public static string[] strs;
   

    // Start is called before the first frame update
    [System.Obsolete]
    void Start()
    {
        m_FileName = "trueb.txt";
        strs = File.ReadAllLines(m_FileName);
        str = File.ReadAllLines("scene.txt");
         Debug.Log(str[0]);
        startnew = this.GetComponent<Button>();
        startnew.onClick.AddListener(Startnew);
        exit= this.GetComponent<Button>();
        exit.onClick.AddListener(Exit);
        load = this.GetComponent<Button>();
        load.onClick.AddListener(Load);
      //  Debug.Log(str[0]);

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Exit()
    {
        //Debug.Log("123");
        Application.Quit();
    }
    public void Load()
    {
       // Debug.Log("1");
       
      //  Debug.Log("11");
        FileStream fs = new FileStream("load.txt", FileMode.Open, FileAccess.Write);
        StreamWriter sw = new StreamWriter(fs, Encoding.Default);
        for (int i = 0; i < strs.Length; i++)
        {
           // Debug.Log(str[i]);
            sw.WriteLine(strs[i]);
        }
        sw.Close();
     //   Debug.Log(str[0]);
        SceneManager.LoadScene(str[0]);

    }
    public void Startnew()
    {
        //Debug.Log("99");
        SceneManager.LoadScene("new");
        // Application.LoadLevel("D:\\game\\game\\Assets\\123.unity");
    }
    
}