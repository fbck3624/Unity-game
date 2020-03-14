using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class see : MonoBehaviour
{
    public GameObject image;
    public Button startnew;
    void Start()
    {
        image.SetActive(false);
        startnew = this.GetComponent<Button>();
        startnew.onClick.AddListener(show);
    }
    void show()
    {
        image.SetActive(true);
    }

}
