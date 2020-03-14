using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public const int EmaxHealth = 100;

    public int EcurrentHealth = EmaxHealth;
    public RectTransform EHealthBar,EHurt;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))

        {

            //接受傷害

            EcurrentHealth = EcurrentHealth - 50;
        }

        if(Input.GetKeyDown(KeyCode.L)){
            EcurrentHealth = EcurrentHealth + 10;
        }

        //將綠色血條同步到當前血量長度

        EHealthBar.sizeDelta = new Vector2(EcurrentHealth, EHealthBar.sizeDelta.y);

        //呈現傷害量

        if (EHurt.sizeDelta.x > EHealthBar.sizeDelta.x)

        {

            //讓傷害量(紅色血條)逐漸追上當前血量

            EHurt.sizeDelta += new Vector2(-1, 0)*Time.deltaTime*10;

        }

        if (EHurt.sizeDelta.x < EHealthBar.sizeDelta.x)

        {

            //讓傷害量(紅色血條)逐漸追上當前血量

            EHurt.sizeDelta += new Vector2(1, 0);

        }
    }
}
