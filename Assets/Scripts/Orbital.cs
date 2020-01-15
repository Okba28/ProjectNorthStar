using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbital : MonoBehaviour
{
    // Start is called before the first frame update
    //public List<GameObject> list;
    public SceneVariables sv;
    public GameObject gameObject;
    
    
    public Transform trn ;
   
    

    void Start()
    {
        //find the root position (should be 0,0,0)
        //spawn the electrone +1 unity respectevly 
       // instantiateInCircle(gameObject, trn.position, elecN,3f);
        
 
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
   public void SpawnElectrones()
    {
        Element e = sv.SlectedElement;
        if(e!=null)
        {
                int shellNumber = e.NumberofShells;
                int elecN = e.NumberofElectrons;
                float radius = 0;
                int current = 0;  
    
    for (int i = 0; i < shellNumber; i++)
     {
    
   
     int n = i*2;
     radius++;
    //n not overbudget if i*2 greater than elecN-current , don't put n but put the ressult 
    if(n>elecN-current)
    {
        instantiateInCircle(gameObject, trn.position, elecN-current,radius);
        return;
    }
    else {
        
     instantiateInCircle(gameObject, trn.position, n,radius);
     //make sure i don't get over the budget ( how many electrons we have )
     current = current +n ;
   

    }
    if(i-shellNumber ==-1)
    {
        instantiateInCircle(gameObject, trn.position, elecN-current,radius);
        return;
    }
     
     
    }
        }
        
 } 
    public void instantiateInCircle(GameObject obj, Vector3 location, float howMany,float radius)
 {
     for (int i = 0; i < howMany; i++)
     {
         
         float angle = i * Mathf.PI * 2f / howMany;
         Vector3 newPos = transform.position + (new Vector3(Mathf.Cos(angle) * radius, 0, Mathf.Sin(angle) * radius));
         Instantiate(obj, newPos, Quaternion.Euler(0, 0, 0));
     }
 }
 }
