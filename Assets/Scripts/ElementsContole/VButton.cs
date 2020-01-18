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
    string vbname ;
  
   void Awake()
   {
       VirtualButtonBehaviour vbh = GetComponent<VirtualButtonBehaviour>();
       vbname= vbh.VirtualButtonName;
       
       vbh.RegisterEventHandler(this);
   }
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
      OnPressed.Invoke();
      Debug.Log(vbname+ " was pressed");
    }
    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        OnReleased.Invoke();
        Debug.Log(vbname+ " was released");
    }
    void Destroy()
    {
        // Register with the virtual buttons TrackableBehaviour
        VirtualButtonBehaviour vbh = GetComponent<VirtualButtonBehaviour>();
        vbh.UnregisterOnButtonPressed(OnButtonPressed);
        vbh.UnregisterOnButtonReleased(OnButtonReleased);
        
    }

}
