using UnityEngine;

public class ChangeWeight : MonoBehaviour
{
    public static int weight;
    public GameObject BodyS, BodyM, BodyL;
    public GameObject[] meshWeight;
    public Animator[] anims;


    public void Start()
    {

      
        BodyM.SetActive(false);
        BodyL.SetActive(false);
        BodyS.SetActive(true);
    }

   public void WeightPlus()
    {
        weight++;
        if (weight ==1)
        {
            BodyM.SetActive(true);
            BodyL.SetActive(false);
            BodyS.SetActive(false);
        }

        else if (weight ==2)
        {
            BodyM.SetActive(false);
            BodyL.SetActive(true);
            BodyS.SetActive(false);
   
        }

        else if (weight >= 3)
        {
            weight = 2;
        }


       
    }

    public void WeightMinus()
    {
        weight--;
        if (weight == 0)
        {
            BodyM.SetActive(false);
            BodyL.SetActive(false);
            BodyS.SetActive(true);
        }

        else if (weight == 1)
        {
            BodyM.SetActive(true);
            BodyL.SetActive(false);
            BodyS.SetActive(false);
        }

        else if (weight <=-1)
        {
            weight = 0;
        }

       

    }

    public void PlayPose(string AnimName)
    {
       
        anims[ChangeWeight.weight].SetBool(AnimName, true);
    }
}


