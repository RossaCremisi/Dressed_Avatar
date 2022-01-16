using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyPoseManager : MonoBehaviour
{
    public GameObject[] meshWeight;
    public Animator[] anims;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < meshWeight.Length; i++)
        {
            if (i==ChangeWeight.weight)
            {
                meshWeight[i].SetActive(true);
            }
            else
            {
                meshWeight[i].SetActive(false);
            }
        }
    }
    public void PlayPose(string AnimName)
    {
        anims[ChangeWeight.weight].SetBool(AnimName, true);
    }
}
