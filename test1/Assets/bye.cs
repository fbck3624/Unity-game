using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class bye : MonoBehaviour
{
    public Button jback;
    // Start is called before the first frame update
    void Start()
    {
        jback = this.GetComponent<Button>();
        jback.onClick.AddListener(bback);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void bback()
    {
       Application.Quit();
        Debug.Log("OK");
    }
}
