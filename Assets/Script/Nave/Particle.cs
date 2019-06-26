using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particle : MonoBehaviour
{
     ParticleSystem system
    {
        get
        {
            if (_CachedSystem == null)
                _CachedSystem = GetComponent<ParticleSystem>();
            return _CachedSystem;
        }
    }
    
    private ParticleSystem _CachedSystem;
    public bool includeChildren = true;
    public bool on=false;

    void Update()
    {
        if(on)
        {
            system.Play();

        }
        else
        {
           // system.Pause();
        }
        
    }
}
