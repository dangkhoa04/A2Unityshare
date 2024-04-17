using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
   void OnCollisionEnter(Collision col)
   {
    if (col.gameObject.CompareTag("Box"))
    {
        Destroy(col.gameObject);
        Destroy(this.gameObject);
    }
   }
<<<<<<< HEAD
}
=======
}
>>>>>>> 7fd1387d60546dddb90c9db557bfdcc12b0477e6
