using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testy : MonoBehaviour
{
    // Start is called before the first frame update
    private Transform target ;
     
    
    // Update is called once per frame
    void OnEnable()
    {
        target = GameObject.FindWithTag("root").transform;
        //send warning if it return null
    }
    void Update()
    {
        
       OrbitAroundTarget(target);
        
    }

    void OrbitAroundTarget(Transform _target)
    {
        transform.RotateAround(_target.position, Vector3.up, 80 * Time.deltaTime);
    }
    
}
