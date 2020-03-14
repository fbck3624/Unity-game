using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;
using UnityEngine.UI;
public class GetExp : MonoBehaviour
{
    // Start is called before the first frame update 
    public Text LevelText;
    public Text ExpText;
    private int level;
    private int count;
    
    void Start()
    {
        string s1;  //use to store string int .txt
        FileStream fs = new FileStream(Application.dataPath + "/save.txt", FileMode.Open);
        StreamReader sr = new StreamReader(fs, Encoding.Default);

        fs.Position = 0;

        string[] s2 = new string[2];//s2 store two integer now

        s1 = sr.ReadLine();
        s2 = s1.Split(' ');         //split numbers from ' '

        level = int.Parse(s2[0]);
        count = int.Parse(s2[1]);

        SetText();

        sr.Close();
        fs.Close();

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("pick"))
        {
            other.gameObject.SetActive(false);
            count = count + 5;
            SetText();
        }
        if (count >= 20)
        {
            level = level + count / 20;
            count = count % 20;
        }
        save(level, count);
    }

    void SetText()
    {
        LevelText.text = "Level: " + level.ToString();
        ExpText.text = "EXP: " + count.ToString();
    }

    void save(int level,int exp)
    {
        FileStream fs = new FileStream(Application.dataPath + "/save.txt", FileMode.Create);
        char space = ' ';   //use to split numbers
        byte[] byte_L = new UTF8Encoding().GetBytes(level.ToString());  //first number:level
        byte[] byte_S = new UTF8Encoding().GetBytes(space.ToString());  //add between numbers
        byte[] byte_E = new UTF8Encoding().GetBytes(exp.ToString());    //second number:exp(count)
        fs.Write(byte_L, 0, byte_L.Length);
        fs.Write(byte_S, 0, byte_S.Length);
        fs.Write(byte_E, 0, byte_E.Length);
        fs.Close();
    }
    void load()
    {

    }
}
