using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
public class UIPopulater : MonoBehaviour
{
    // Start is called before the first frame update
     List<Button> elementBtn = new List<Button>();
     public UIEventsListener listener;
    void Start()
    {
        elementBtn = GetComponentsInChildren<Button>().ToList();;
      
        print (""+elementBtn.Count);
        Populate ();
        //null reference fix
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Populate ()
    {
       int  count = 1;
       List<Element> elements = new List<Element>();
        foreach( var btn in elementBtn)
        {
            //chenge text 
            Text text = btn.GetComponentInChildren<Text>();
            
            Element e = ElementFactory.GetElementByAtomic(count);
            text.text = e.Symbol;
            elements.Add(e);
            Debug.Log(text.text);
            count++;
        }
        //setDictionary in the listener 
        listener.initDictionary(elementBtn,elements);

    }
}
