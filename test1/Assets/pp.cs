using UnityEngine;
using System.Collections;
using System.IO;
using UnityEngine.UI;
using System.Collections.Generic;

/**
 * <summary>
 * <para>作者：巨星電藝</para> 
 * <para>編寫日期：巨星電藝</para>
 **/
public class pp : MonoBehaviour
{
    public TextAsset txtRawFile;
    public Text uiText;

    private int[,] spaces;

    private List<string> eachLine;
    private string theWholeFileAsOneLongString;

    // Use this for initialization
    void Start()
    {

        theWholeFileAsOneLongString = txtRawFile.text;

        eachLine = new List<string>();
        eachLine.AddRange(theWholeFileAsOneLongString.Split("\n"[0]));

        int[,] spaces = new int[eachLine.Count, 6];         // 獲取整數陣列

        for (int i = 0; i < eachLine.Count; i++)
        {               // 逐行轉換
            string st = eachLine[i];            // 取得一行

            string[] nums = st.Split(new[] { ',' });
            if (nums.Length != 6)
            {
                Debug.Log("Misforned input on line " + i + 1);
            }

            for (int j = 0; j < Mathf.Min(nums.Length, 6); j++)
            {
                int val;
                if (int.TryParse(nums[j], out val))
                    spaces[i, j] = val;
                else
                    spaces[i, j] = -1;

            }
        }

        // Output the data to verify the read
        for (int i = 0; i < spaces.GetLength(0); i++)
        {
            Debug.Log(spaces[i, 0].ToString() + spaces[i, 1].ToString() + spaces[i, 2].ToString() + spaces[i, 3].ToString() + spaces[i, 4].ToString() + spaces[i, 5].ToString());
        }
    }
}