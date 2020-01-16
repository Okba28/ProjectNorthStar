using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElementFactory 
{
    // Start is called before the first frame update
   static Dictionary<string , Element> elementsDictionaryBySymbole = new Dictionary<string, Element>();
   static Dictionary<int , Element> elementsDictionaryByAtomic = new Dictionary<int, Element>();
    
    public static void InitFactory(List<Element> elements)
    {
       initDicByName( elements);
       initDicByAtomic(elements);
    }
  static   void initDicByName(List<Element> elements)
    {
         foreach (Element e in elements)
        {
             if(elementsDictionaryBySymbole.ContainsKey(e.Symbol))
             {
                return;
             }
             else {
                        elementsDictionaryBySymbole.Add(e.Symbol,e);
             }
          
        }
        Debug.Log ("Factory int "+ elementsDictionaryBySymbole.Count);
    }
 static   void initDicByAtomic(List<Element> elements)
    {
         foreach (Element e in elements)
        {
             if(elementsDictionaryByAtomic.ContainsKey(e.AtomicNumber))
             {
                return;
             }
             else {
                        elementsDictionaryByAtomic.Add(e.AtomicNumber,e);
             }
          
        }
        Debug.Log ("Factory init "+ elementsDictionaryByAtomic.Count);
    }
    public static Element GetElementByName (string elementsName)
    {
        if(elementsDictionaryBySymbole.ContainsKey(elementsName))
        {
            Element e = elementsDictionaryBySymbole[elementsName];
            return e;
        }
        
        else 
        {
            return null;
        }
    }
    public static Element GetElementByAtomic (int elementsAtomic)
    {
        if(elementsDictionaryByAtomic.ContainsKey(elementsAtomic))
        {
            Element e = elementsDictionaryByAtomic[elementsAtomic];
            return e;
        }
        
        else 
        {
            return null;
        }
    }
}
