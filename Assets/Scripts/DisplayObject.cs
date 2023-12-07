using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayObject : MonoBehaviour
{
   // private Renderer renderer;
    //public Material material;
    // Start is called before the first frame update
    void Start()
    {
        //renderer = this.GetComponent<Renderer>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateColour(Color color)
    {
        
       this.GetComponent<MeshRenderer>().material.color = color;
    }

    public void OnMouseEnter()
    {
        UpdateColour(new Vector4(Random.Range(0f, 1), Random.Range(0f, 1f), Random.Range(0f, 1f), 1f));
    }
}
