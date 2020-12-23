using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public bool IsCatch = false;
    public Animator anim, Cameras;
    public bool StartPlaying = false;

    public int getCatch = 0;

    bool GetCatchDone = false;
    void Update()
    {
        if (Input.anyKeyDown)
        {
            if (!StartPlaying)
            {
                anim.SetTrigger("play");
                StartPlaying = true;
                return;
            }

            if (!GetCatchDone && getCatch >= 5)
            {
                PlayCatch(false);
                GetCatchDone = true;
                IsCatch = false;
                Triggered("next6");
                return;
            }
        }
    }

    public void PlayCatch(bool play = true)
    {
        if (play)
        {
            Cameras.SetBool("play", true);
            IsCatch = true;
        }

        else
        {
            Cameras.SetBool("play", false);
        }
    }

    public void Triggered(string triger)
    {
        anim.SetTrigger(triger);
    }
}
