using UnityEngine;
public class AnimationWalk : MonoBehaviour
{

    public Animator[] currentAnims;

    public void PlayW()
    {
        currentAnims[ChangeWeight.weight].SetBool("Walking", true);
    }
}
