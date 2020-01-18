using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LoadElement : MonoBehaviour
{
    List<Element> elements = new List<Element>();
   
    [SerializeField]
    TextAsset questdata;
	// Use this for initialization
	void Awake () 
    {
        

        string[] data = questdata.text.Split(new char[] { '\n' });

        for (int i = 1; i < data.Length - 1; i++)
        {
            string[] row = data[i].Split(new char[] { ',' });
            
            if (row[1] != "")
            {
                Element q = new Element();

                int.TryParse(row[0], out q.AtomicNumber);
                q.ElementName = row[1];
                q.Symbol = row[2];
                
                int.TryParse(row[4], out q.NumberofNeutrons);
                int.TryParse(row[5], out q.NumberofProtons);
                int.TryParse(row[6], out q.NumberofElectrons);
                
                q.Phase = row[8];
                q.Type = row[15];
                q.AtomicRadius= row[16];
                q.Discoverer= row[23];
                q.Year= row[24];
                int.TryParse(row[26], out q.NumberofShells);

                elements.Add(q);
            }
            
        }
        
       

        foreach (Element q in elements)
        {
           // Debug.Log(q.ElementName + "," + q.Symbol+ "," +q.NumberofNeutrons+ "," +q.NumberofProtons+","+q.NumberofShells);
        }
        ElementFactory.InitFactory(elements);
        //debug.text="elemnts loaded from Csv with"+elements.Count;
	}
     void Start()
        {
            
        }

    // Update is called once per frame
    void Update() 
    {
		
	}
}
