using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zoom : MonoBehaviour
{
    public float floatHeight;    
    public float liftForce;       
    public float damping; 

    void Update()
    {    
        RaycastHit2D hit = Physics2D.Raycast(transform.position, -Vector2.up);
         Debug.DrawRay(hit.transform.position,Vector2.down,Color.yellow);
         if (hit.collider != null)
        {
            float distance = Mathf.Abs(hit.point.y - transform.position.y);
            float heightError = floatHeight - distance;

            Debug.DrawRay(hit.transform.position,Vector2.down,Color.red);
      
        }
       
        
    }
}
