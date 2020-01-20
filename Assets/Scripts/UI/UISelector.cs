using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UISelector : MonoBehaviour
{
    // Start is called before the first frame update
    public SceneVariables sv ;
    public TextMeshProUGUI  debug;
    private List<Button> listBtn = new List<Button>();
    public UpdateUI updater ;
    void Awake()
    {
        Element element =ElementFactory.GetElementByName("H");
        updater.UpdateInfo(element);
        sv.SetSelectedElement(element);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    int counter = 0 ;
   
    public void SelectForward()
    {
        debug.text = "  SelectForward ";
        //TODO dont repeat yourself
        if(listBtn.Count==0 )
        {
            initList();
            
        }
        counter++;
        if(counter<=0 || counter > listBtn.Count-1)
        {
            counter =0;
            return;
        }
        else {
           Element e = GetElement (listBtn[counter]);
           if(e==null)
           {
                  print("e is null");
           }
           else {
                updater.UpdateInfo(e);
                

               sv.SetSelectedElement(e);

           }
          

        }
        
    }
    public void SelectBackward()
    {
        debug.text = "  SelectBackward ";
        if(listBtn.Count==0 )
        {
            initList();
        
        }
        counter--;
        if(counter<=0 || counter > listBtn.Count-1)
        {
            counter =0;
           
        }
        else 
        {
            Element e = GetElement (listBtn[counter]);
            updater.UpdateInfo(e);
            //sv.SetSelectedElement(e);
        }
       
           
    }
    void initList()
    {
       listBtn.Clear();
       listBtn.AddRange(sv.BtnList);
        debug.text = "  init list "+listBtn.Count;
    }
    Element GetElement (Button btn)
    {
        String name = btn.GetComponentInChildren<Text>().text;
        Element e = ElementFactory.GetElementByName(name);
        return e;
    }
    void MoveSelectio(int counter)
    {
      
    }
}
