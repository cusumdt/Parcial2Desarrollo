using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody2D nave;
    public float force;
    public float velocity;
    public float rotSpeed;
    private Quaternion rot;
    private float z ;
    private Vector3 movimiento;
    public float gravity;

    void Update()
    {
        GameObject naveActual = this.gameObject;
        Nave naveComponent = naveActual.GetComponent<Nave>();
        if(!naveComponent.GetCollision() && !naveComponent.GetCollisionMontana())
        { 
            rot = transform.rotation;
            z = rot.eulerAngles.z;
            z -= Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime;
            rot = Quaternion.Euler(transform.rotation.x,transform.rotation.y,z);
            transform.rotation = rot;
            if(Input.GetKey("up"))
            {   
                naveComponent.SustDarkMater(1f * Time.deltaTime);
                force += velocity*Time.deltaTime;
                if(force >= 0.05f)
                {
                    force = 0.05f;
                }
                Vector2 estado = new Vector2(0.0f,force);
                Vector3 estadoVec= estado;
                movimiento += rot * estadoVec;
                nave.AddForce(movimiento,ForceMode2D.Force);
                limitVelocityForce();
              
            }
            else
            {
                movimiento=Vector3.zero;
                nave.AddForce(Vector3.zero);
                force=0;
            }
              nave.gravityScale = gravity;
             if(nave.velocity !=Vector2.zero)
             {
                naveComponent.SetActualVelocity(nave.velocity);
              }
       }    
    }
    void limitVelocityForce()
    {
    
        if(nave.velocity.y >=2)
        {
            nave.velocity=new Vector2(nave.velocity.x, 2.0f);
        }
        else if(nave.velocity.y <= -3)
        {
            nave.velocity=new Vector2(nave.velocity.x, -3.0f);
        }
        if(nave.velocity.x >=3)
        {
            nave.velocity=new Vector2(3.0f, nave.velocity.y);
        }
        else if(nave.velocity.x <= -3)
        {
            nave.velocity=new Vector2(-3.0f, nave.velocity.y);
        }
    }
}
