using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIEventsListener : MonoBehaviour
{
    // Start is called before the first frame update
    UpdateUI updater ;
    List<Button> list = new List<Button>();
    Dictionary <Element,Button> ButtonsDictionary = new Dictionary<Element, Button>();
    //We listen to events that happen to the button , we udpate the UI info based on that
    void Awake()
    {
        updater = FindObjectOfType<UpdateUI>();
        
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Listner()
    {
       
    }
   public void initDictionary (List<Button> elementBtn,List<Element> elements)
    {
        list.AddRange(elementBtn);
       foreach(var btn in elementBtn)
       {
           //a lot of looping ...
           foreach( Element e in elements)
           {
               if(!ButtonsDictionary.ContainsKey(e))
                    ButtonsDictionary.Add(e,btn);
           }
       }
    }
    void SendUpdate(Element e)
    {
        //UIupdater need to be notified of the chenge .
    }
}
