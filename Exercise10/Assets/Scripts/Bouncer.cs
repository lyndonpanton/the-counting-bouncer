using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouncer : MonoBehaviour
{
    // stores the rb2d unity component
    Rigidbody2D rb2d;

    // stores the audio source unity component
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 localScale  = transform.localScale;

        localScale.x *= 5;
        localScale.y *= 5;

        transform.localScale = localScale;

        audioSource = GetComponent<AudioSource>();

        rb2d = GetComponent<Rigidbody2D>();

        float horizontalForce = Random.Range(15.0f, 25.0f);
        float verticalForce = Random.Range(15.0f, 25.0f);

        int inverseHorizontalForce = Random.Range(0, 2);
        int inverseVerticalForce = Random.Range(0, 2);

        if (inverseHorizontalForce == 1)
        {
            horizontalForce *= -1;
        }

        if (inverseVerticalForce == 1)
        {
            verticalForce *= -1;
        }

        rb2d.AddForce(
            new Vector2(
                horizontalForce,
                verticalForce
            ),
            ForceMode2D.Impulse
        );
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        audioSource.Play();

        HUD hud = GameObject.FindGameObjectsWithTag("HUD")[0].GetComponent<HUD>();
        hud.AddBounce();
    }
}
