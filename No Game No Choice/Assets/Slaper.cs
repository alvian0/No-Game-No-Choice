using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slaper : MonoBehaviour
{
    public Text slapCount;
    public int SlapTimes;
    public Animator anim;

    void Update()
    {
        slapCount.text = "Slap Count\n" + SlapTimes.ToString();
    }

    public void Slap(string triger)
    {
        if (SlapTimes == 5)
        {
            SlapTimes++;
            anim.SetTrigger(triger);
            return;
        }

        SlapTimes++;
    }
}
