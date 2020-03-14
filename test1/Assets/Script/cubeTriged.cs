using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeTriged : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator cubeAnimCtrl;
    private bool isTrigged;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggedEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            cubeAnimCtrl.SetBool("isTrigged", true);
        }
    }



}
