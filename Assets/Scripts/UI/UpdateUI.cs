using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class UpdateUI : MonoBehaviour
{
    // Start is called before the first frame 
//public TextMeshProUGUI AtomicNumber;
public TextMeshProUGUI  ElementName;
public TextMeshProUGUI Symbol;
public TextMeshProUGUI NumberofNeutrons;
public TextMeshProUGUI  NumberofProtons;
public TextMeshProUGUI NumberofElectrons;
public TextMeshProUGUI Phase;
public TextMeshProUGUI Type;
public TextMeshProUGUI AtomicRadius;
public TextMeshProUGUI Discoverer;
public TextMeshProUGUI Year;

public SceneVariables sv;
    void Start()
    {
       //set hydro as default
        
    }

    // Update is called once per frame
    void Update()
    {
          
    }
    public void UpdateInfo(Element element)
    {
        if(element!=null)
        {
       // sv.SlectedElement =element;
        ElementName.text = element.ElementName;
        Symbol.text= element.Symbol; 
        NumberofNeutrons.text = "N: " +element.NumberofNeutrons;
        NumberofProtons.text = "P: "+ element.NumberofProtons;
        NumberofElectrons.text = "E: "+element.NumberofElectrons;
        Phase.text= "Phase: "+element.Phase;
        Type.text ="Type: "+ element.Type;
        AtomicRadius.text = "Atomic Radius: " + element.AtomicRadius;
        Discoverer.text = "Discoverer: " +element.Discoverer;
        Year.text = element.Year;

        }
        
      
    }
    
}
