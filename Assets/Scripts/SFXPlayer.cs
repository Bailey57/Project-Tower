using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    [SerializeField] public AudioSource t72Firing;




    public void PlayT72Firing() 
    {
        if (t72Firing != null) 
        {
            t72Firing.Play();

        }
        
    
    }
}