using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touch : MonoBehaviour
{
    //public CapsuleCollider a = GetComponent<CapsuleCollider>();
    // public CapsuleCollider a;
    // Start is called before the first frame update

    void Start()
    {
        Debug.Log("rr");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision r)
    {
        if (r.gameObject.name == "boy") 
        {
            people.who = true;
            people.load();
          //  Debug.Log("OK");
        }
        else
        {
          //  Debug.Log("!OK");
        }
    }
}
