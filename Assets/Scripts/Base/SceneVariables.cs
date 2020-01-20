using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


 [CreateAssetMenu(fileName = "sceneVariable", menuName = "SceneData/Variables", order = 1)]
public class SceneVariables : ScriptableObject
{
    // Data Holder
   
    private Element slectedElement = null;
    private Button slectedButton = null;

    public Element SlectedElement { get => slectedElement; set => slectedElement = value; }
    public Button SlectedButton { get => slectedButton; set => slectedButton = value; }
    public List<Button> BtnList  { get; set; }

    void ResetData()
  {
    slectedElement = null;
    Button slectedButton = null;
    BtnList.Clear();
  }
  
  void Start()
  {
      BtnList = new List<Button>();
  }
  void OnApplicationQuit()
  {
     ResetData(); 
  }
  public void SetSelectedElement(Element element)
  {
    slectedElement = element;
  }
}
