using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorChanger : MonoBehaviour
{
    
    public void ColorChange()
    {
        GetComponent<Image>().color = Color.green;
    }

}
