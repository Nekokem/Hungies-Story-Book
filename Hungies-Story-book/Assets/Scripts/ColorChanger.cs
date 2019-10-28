using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorChanger : MonoBehaviour
{
    private Color[] colors = new Color[6];

    void Start()
    {
        colors[0] = Color.red;
        colors[1] = Color.green;
        colors[2] = Color.yellow;
        colors[3] = Color.blue;
        colors[4] = Color.magenta;
        colors[5] = new Color(1f, 0.51f, 0f);
    }

    public void ColorChange()
    {
        GetComponent<Image>().color = colors[Random.Range(0, colors.Length)];
    }

}
