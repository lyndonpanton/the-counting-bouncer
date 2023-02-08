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
    int bounceCount = 0;

    const string bounceTextPrefix = "Bounce count: ";

    // Start is called before the first frame update
    void Start()
    {
        bounceText.text = bounceTextPrefix + bounceCount.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
