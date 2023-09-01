using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerStatusText : MonoBehaviour
{
    public TextMeshProUGUI _textMeshPro;

    // Start is called before the first frame update
    void Start()
    {
    }

    public void AddAnnouncement(string text)
    {
        Debug.Log("displaying text:" + text);
        _textMeshPro.text = _textMeshPro.text + "\n" + text;
    }
    
}