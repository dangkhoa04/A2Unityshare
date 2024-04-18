using System.Collections;
using System.Collections.Generic;
using UnityEngine;

<<<<<<< HEAD
public class Bullet : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * 1f);
    }
}
=======
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
>>>>>>> cab55ea4775fbab023ac099b2a2a42be30fc77dd
