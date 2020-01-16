using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Vuforia;

public class VButton : MonoBehaviour,IVirtualButtonEventHandler

{
    // Start is called before the first frame update
    //Simple Script to make Virtual Button looks like A unity Button
    public UnityEvent OnPressed; 
    public UnityEvent OnReleased; 
  
   void Start()
   {
       GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
   }
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
      OnPressed.Invoke();
    }
    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        OnReleased.Invoke();
    }
}
