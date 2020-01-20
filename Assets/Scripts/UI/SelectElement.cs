using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SelectElement : MonoBehaviour
{
    // Start is called before the first frame update
    public UpdateUI updater ;
    public Color color ;
    public SceneVariables sv;
    Image  image;
    void Awake()
    {
        Element element =ElementFactory.GetElementByName("H");
        updater.UpdateInfo(element);       
    }
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    int counter =0;
    Element element;
    public void changeSlectionForward()
    {
        counter++;
        if(counter < 118)
        {
           ShowElementInfo(counter);
        }
       if(counter == 119)
       {
           counter =0;
       }
        //string str = element.Symbol;
       // GameObject go = findImg(str);        

        //Highlight (go);
    }
    public void changeSlectionBackward()
    {
        counter--;
        
        if(counter == 0)
        {
           ShowElementInfo(118);
           return;
        }
        else
        {
            ShowElementInfo(counter);    
        }
       // string str = element.Symbol;
       // GameObject go = findImg(str);
      //  Highlight (go);
    }
   GameObject findImg(string stg)
   {
       //search the scene for the text 
       GameObject text = GameObject.Find(stg);
       GameObject go = text.transform.parent.gameObject;
       return go;
   }
   void ShowElementInfo(int i)
   {
        element = ElementFactory.GetElementByAtomic(i);
        updater.UpdateInfo(element);
        sv.SetSelectedElement(element);
   }
   void Highlight (GameObject go)
   {
       Image img = go.GetComponent<Image>();
       img.color = color;
   }
}
