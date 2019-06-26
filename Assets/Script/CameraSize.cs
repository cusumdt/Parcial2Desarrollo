using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSize : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform nave;
    private float size;


    // Update is called once per frame
    void Update()
    {
        Vector3 position = new Vector3(nave.position.x,nave.position.y+2,nave.position.z-100);
        Camera.main.orthographicSize = size;
        this.transform.position = position;
    
    }
    public void SetSize(float _size)
    {
        size = _size;
    }
    public float GetSize()
    {
        return size;
    }
}
