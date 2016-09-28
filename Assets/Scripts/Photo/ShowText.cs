using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ShowText : MonoBehaviour
{
    private Text text;

    void Start()
    {
        text = GetComponent<Text>();
    }
    // Use this for initialization
    public void Show(string t)
    {
        text.text = t;
    }
}
