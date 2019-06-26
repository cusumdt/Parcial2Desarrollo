using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionZoom : MonoBehaviour
{
    private CameraSize camera;
    public GameObject objeto;

    void Start()
    {
        camera = objeto.GetComponent<CameraSize>();
        camera.SetSize(10f);
    }
  
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag=="Montana")
        {
            camera.SetSize(4f);
        }
        else if (col.gameObject.tag!="Wall" && col.gameObject.tag!="Terreno")
        {
            camera.SetSize(10f);
        }
    }

}
