using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem
{
    public int Healthmax;
    public int health;
    public int EHealthMax;
    public int ehealth;
    public HealthSystem(int h,int eh){
        this.Healthmax = h;
        this.EHealthMax = eh;
        this.health = this.Healthmax;
        this.ehealth = this.EHealthMax;
    }   
    public void IDamage(int d){
        this.health -= d;
        if(this.health < 0){
            this.health = 0;
        }
    }
    public void EDamage(int d){
        this.ehealth -= d;
        if(this.ehealth < 0){
            this.ehealth = 0;
        }
    }
    public void IHeal(int h){
        this.health += h;
        if(this.health > this.Healthmax){
            this.health = this.Healthmax;
        }
    }
    
}
