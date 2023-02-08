using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HUD : MonoBehaviour
{
    // the field which displays the bounce count
    [SerializeField]
    TextMeshProUGUI bounceText;
    // the amount of time the game object has made contact with a collider
    int bounceCount;

    const string bounceTextPrefix = "Bounce count: ";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
