using System.Collections;
using System.Collections.Generic;
using System;
using System.Text;
public class SkillSystem
{
    public StringBuilder skill;
    public SkillSystem(){
        this.skill= new StringBuilder(CreateSkill(8));
    }
    public string CreateSkill(int length)
    {
            const string valid = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
    }
}
