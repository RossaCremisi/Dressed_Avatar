using UnityEngine;
public class AnimationWalk : MonoBehaviour
{
    public static void PlayW(Animator anim)
    { 
        anim.SetBool("Walking", true);
    }
}
