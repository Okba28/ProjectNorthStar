using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UISelector : MonoBehaviour
{
    // Start is called before the first frame update
    public SceneVariables sv ;
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
        }
        
    }
    public void SelectBackward()
    {
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
        else {
                    sv.SlectedButton = listBtn[counter];
        }
       
    }
    void initList()
    {
       listBtn.Clear();
       listBtn.AddRange(sv.BtnList);
    }
}
