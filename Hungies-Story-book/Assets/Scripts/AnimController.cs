using UnityEngine;

[CreateAssetMenu]
public class AnimController : ScriptableObject
{

   private Animation anim;
  
   public void CallAnim(Animator animator)
   {
      animator.SetTrigger(name);
   }
}
