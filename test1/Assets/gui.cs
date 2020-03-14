using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gui : MonoBehaviour
{
    string level;
   // public GameObject image;
   // public Button yes;
   // public Button saveornot;
    public Canvas ask;
    // Start is called before the first frame update
    void Start()
    {
        //level = Application.loadedLevelName;
      //  saveornot = this.GetComponent<Button>();
      //  saveornot.onClick.AddListener(click);
        ask = ask.GetComponent<Canvas>();
     //   Debug.Log("HI");
        ask.enabled = false;
        //yes.gameObject.SetActive(false);
        //  no.gameObject.SetActive(false);

        //Debug.Log(Application.loadedLevelName);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*  void click()
      {
          ask.enabled = true;
          Debug.Log("12");

      }*/
    void OnMouseDown()
    {
        ask.enabled = true;
    }
}
