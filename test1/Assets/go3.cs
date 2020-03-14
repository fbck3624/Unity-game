using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class go3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision r)
    {
        if (r.gameObject.name == "boy")
        {
            SceneManager.LoadScene("listen");
            Debug.Log("OK");
        }
        else
        {
            Debug.Log("!OK");
        }
    }
}
