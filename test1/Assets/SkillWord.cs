using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class SkillWord : MonoBehaviour
{
    private TextMeshPro tm;
    private float disappeartime;
    private Color textColor;    
    private void Awake(){
        tm = transform.GetComponent<TextMeshPro>();
    }
    public void Setup(string sw){
        tm.SetText(sw);
        textColor = tm.color;
        disappeartime = 3f;
    }
    public void disappear(){
        textColor.a = 0;
        tm.color = textColor;
    }
    private void Update(){
        float Ymove = 0.7f;
        transform.position += new Vector3(0, Ymove) * Time.deltaTime;
        //disappeartime -= Time.deltaTime;
        if(disappeartime < 0){
            float disappearSpeed = 3f;
            textColor.a -= disappearSpeed * Time.deltaTime;
            tm.color = textColor;
            if(textColor.a < 0){

            }
        }
    }
    
}
