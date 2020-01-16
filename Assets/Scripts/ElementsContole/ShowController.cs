using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] 
     SceneVariables sv;
    [SerializeField]    
      Color highlightColor;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HighlightSelectedButton();
        SetSelectedElement();
    }
    void HighlightSelectedButton()
    {

        Button button =  sv.SlectedButton;
          if(button!=null)
         //Changes the button's Highlighted color 
         {
           ColorBlock cb = button.colors;
              cb.normalColor =highlightColor;
                    button.colors = cb;
         }
        
    }
    void SetSelectedElement()
    {
        Button button =  sv.SlectedButton;
        if(button!=null)
        {
        Text text = button.GetComponentInChildren<Text>();
        string symbole = text.text;
        sv.SlectedElement = ElementFactory.GetElementByName(symbole);
//        Debug.Log(""+sv.SlectedElement.Symbol+","+sv.SlectedElement.NumberofShells);
        }
        
    }

}
