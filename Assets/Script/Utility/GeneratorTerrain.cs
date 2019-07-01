using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorTerrain : MonoBehaviour
{
    public GameObject[] terrains;
    public int cantTerrains;
    void Start()
    {
        int rand = Random.Range(0,cantTerrains);
        Debug.Log(rand);
        GameObject terrain = Instantiate(terrains[rand],terrains[rand].transform.position,Quaternion.identity);
    }

    
    void Update()
    {
        
    }
}
