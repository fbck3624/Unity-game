using UnityEngine;
using System.Collections;
using System.IO;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class loadScene : MonoBehaviour
{
    // Start is called before the first frame update
    public static string[] str;
    public Button load;
    void Start()
    {
        str = File.ReadAllLines("scene.txt");
        load = this.GetComponent<Button>();
        load.onClick.AddListener(Load);
    
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Load()
    {
        SceneManager.LoadScene(str[0]);
        Debug.Log("2");
    }
}
