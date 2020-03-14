using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class back : MonoBehaviour
{
    // Start is called before the first frame update
    public Button jback;
    public GameObject image;
    void Start()
    {
        image.SetActive(true);
        jback = this.GetComponent<Button>();
        jback.onClick.AddListener(bback);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void bback()
    {
        image.SetActive(false);
    }
}
