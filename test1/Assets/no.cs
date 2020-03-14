using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class no : MonoBehaviour
{
    // Start is called before the first frame update
    public Button noo;
    public Canvas ask;
    void Start()
    {
        ask = ask.GetComponent<Canvas>();
        noo = this.GetComponent<Button>();
        noo.onClick.AddListener(NO);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void NO()
    {
        ask.enabled = false;
    }
}
