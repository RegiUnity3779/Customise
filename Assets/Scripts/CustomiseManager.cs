using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CustomiseManager : MonoBehaviour
{
    public GameObject displayObject;
    public Slider heightSlider;
    public Slider widthSlider;
    public Texture2D fullColourImage;
    public Image curColourImage;
    private Vector3 colourSelected;
    public Color selectedColour;
    

    // Start is called before the first frame update
    void Start()
    {
        NewRandomColour();


    }

    // Update is called once per frame
    void Update()
    {

        //if (Input.GetMouseButtonDown(0))
        //{


        //    colourSelected = Input.mousePosition;
        //    selectedColour = fullColourImage.GetPixel(((int)colourSelected.x * fullColourImage.width), ((int)colourSelected.y * fullColourImage.height));
        //    Color color = new Vector4((selectedColour.r), (selectedColour.b), (selectedColour.g), (selectedColour.a));
        //    curColourImage.color = color;
        //    cubeMaterial.color = color;
        //    Debug.Log(curColourImage.color);



        //}
    }

    public void SizeChange()
    {
        displayObject.transform.localScale = new Vector3(widthSlider.value, heightSlider.value, widthSlider.value);
    }

    public void NewRandomColour()
    {
        selectedColour =new Color(RandomColourValue(), RandomColourValue(), RandomColourValue(), 255);
        displayObject.GetComponent<DisplayObject>().UpdateColour(selectedColour);
        curColourImage.color = selectedColour;
    }

    public void NewSelectedColour(Image image)
    {
        selectedColour = new Color(image.color.r, image.color.g, image.color.b, 255);
        displayObject.GetComponent<DisplayObject>().UpdateColour(selectedColour);
        curColourImage.color = selectedColour;

    }


    public float RandomColourValue()
    {
        return Random.Range(0f,1f);
    }

   
}
