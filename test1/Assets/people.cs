using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class people : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool who = false;
    void Start()
    {
      //  Debug.Log("0");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static void load()
    {
        if (who == true)
        {
            SceneManager.LoadScene("tt");
        }
    }
}
