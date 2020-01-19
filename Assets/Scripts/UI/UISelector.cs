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
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    int counter =0 ;
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
             sv.SlectedButton = listBtn[counter];
             debug.text = ""+sv.SlectedButton.GetComponentInChildren<Text>().text;

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
            return;
        }
        else 
        {
            sv.SlectedButton = listBtn[counter];
        }
       
           
    }
    void initList()
    {
       listBtn.Clear();
       listBtn.AddRange(sv.BtnList);
        debug.text = "  init list "+listBtn.Count;
    }
}
