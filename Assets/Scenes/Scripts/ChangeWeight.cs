using UnityEngine;

public class ChangeWeight : MonoBehaviour

{
    public Mesh currentmesh;
    public int weight;
    public Mesh BodyS, BodyM, BodyL;
    public MeshFilter rend;

  



    public void Start()
    {
        currentmesh = BodyS;
        rend = GetComponent<MeshFilter>();
      
        rend.mesh = BodyS;
    }

   public void WeightPlus()
    {
        weight++;
        if (weight ==1)
        {
            rend.mesh = BodyM;
            Debug.Log("Entrato");
            currentmesh = BodyM;
        }

        else if (weight ==2)
        {

            rend.mesh = BodyL;
            Debug.Log("Entrato2");
            currentmesh = BodyL;
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
            rend.mesh = BodyS;
            Debug.Log("Entrato");
            currentmesh = BodyS;
        }

        else if (weight == 1)
        {

            rend.mesh = BodyM;
            Debug.Log("Entrato2");
            currentmesh = BodyM;
        }

        else if (weight <=-1)
        {
            weight = 0;
        }
    }

    
}


