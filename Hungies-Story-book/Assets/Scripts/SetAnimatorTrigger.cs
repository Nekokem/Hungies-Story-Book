using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetAnimatorTrigger : MonoBehaviour
{
   public string paramiterName;

   public void Set()
   {
      GetComponent<Animator>().SetTrigger(paramiterName);
   }
}
