using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitGhost : MonoBehaviour
{
    public GameObject Bullet;
    public Transform FirePos;
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown (0))
        {
            Instantiate(Bullet, FirePos.transform.position, FirePos.transform.rotation);
        }
        
    }
}
