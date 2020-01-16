using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
public class UIPopulater : MonoBehaviour
{
    // Start is called before the first frame update
     List<Button> elementBtn = new List<Button>();
     [SerializeField]
     private GameObject panel ;
     [SerializeField]
     private SceneVariables sv;
 
    void Start()
    {
        elementBtn = panel.GetComponentsInChildren<Button>().ToList();
        sv.BtnList.Clear();
        sv.BtnList.AddRange(elementBtn);
      
        print ("populate with "+sv.BtnList.Count);
        Populate ();
      
         //print ("populate with "+sv.BtnList.Count);
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
            print(count);
            Element e = ElementFactory.GetElementByAtomic(count);
            if(e== null)
            {
                print("nulrefrenceexeption e");
            }
            text.text = e.Symbol;
            elements.Add(e);
            
            count++;
        }
        //setDictionary in the listener 
       
    }
}
