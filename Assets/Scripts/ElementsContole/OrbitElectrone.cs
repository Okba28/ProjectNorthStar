using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitElectrone : MonoBehaviour
{
    private Transform target ;
     
    
    // Update is called once per frame
    void OnEnable()
    {
        
        //send warning if it return null
         target = GameObject.FindWithTag("root").transform;
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
