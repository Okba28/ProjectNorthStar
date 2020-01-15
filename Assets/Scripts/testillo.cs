using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testillo : MonoBehaviour
{
    // Start is called before the first frame update
    List<GameObject> listOfSpawnedElectrons = new List<GameObject>();
    public GameObject gameObject;
    public int shellNumber; 
    
    public Transform trn ;
    public int elecN = 2;
    Element element ; 
    public SceneVariables sv;

    void Start()
    {
        //find the root position (should be 0,0,0)
        //spawn the electrone +1 unity respectevly 
       // instantiateInCircle(gameObject, trn.position, elecN,3f);
      
        
    }

    // Update is called once per frame
    void Update()
    {
        element = sv.SlectedElement;
        
    }
   public void SpawnElectrones()
    {
        if(listOfSpawnedElectrons.Count!=0)
        {
            //very bad way to dspose spawned items 
            foreach(GameObject g in listOfSpawnedElectrons)
            {
                Destroy(g);
            }
            listOfSpawnedElectrons.Clear();
        }
    
    
   
    
    elecN = element.NumberofElectrons;
    
    float radius = 0;
    int current = 0;  
    
    for (int i = 0; i < shellNumber; i++)
     {
     radius++;
     Debug.Log(radius);
     int n = i*2;
     
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
    public void instantiateInCircle(GameObject obj, Vector3 location, float howMany,float radius)
 {
     for (int i = 0; i < howMany; i++)
     {
         
         float angle = i * Mathf.PI * 2f / howMany;
         Vector3 newPos = transform.position + (new Vector3(Mathf.Cos(angle) * radius, 0, Mathf.Sin(angle) * radius));
         GameObject go = Instantiate(obj, newPos, Quaternion.Euler(0, 0, 0));
         listOfSpawnedElectrons.Add(go);
     }
 }
 
}
