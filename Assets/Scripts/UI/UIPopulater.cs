using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using TMPro;
public class UIPopulater : MonoBehaviour
{
    // Start is called before the first frame update
     List<Button> elementBtn = new List<Button>();
     [SerializeField]
     private GameObject panel ;
     [SerializeField]
     private SceneVariables sv;
    public TextMeshProUGUI  debug;
 
  
  
    void Start()  
    {
        
     
        PopulateUI();
        debug.text="start populating ";
    }
  
      
 
   private void PopulateUI ()
    {
        elementBtn = panel.GetComponentsInChildren<Button>().ToList();
        if(sv.BtnList.Count!=0)
        {
        sv.BtnList.Clear();
        sv.BtnList.AddRange(elementBtn);
      
        debug.text= sv.BtnList.Count.ToString();
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
                debug.text ="nulrefrenceexeption e";
            }
            text.text = e.Symbol;
            elements.Add(e);
            
            count++;
        }
        //setDictionary in the listener 
        debug.text="done populating ";
        }
        else{
             debug.text="sv.BtnList 00";
        }
        
       
    }
}
