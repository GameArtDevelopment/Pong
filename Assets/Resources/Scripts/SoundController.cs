using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    public AudioSource WallSound;
    public AudioSource PaddleSound;
    public ParticleSystem HitFx;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Paddle1" || collision.gameObject.name == "Paddle2")
        {
            PaddleSound.Play();
            HitFx.Play();
            HitFX();
        }
        else
        {
            WallSound.Play();
            HitFx.Play();
            HitFX();
        }
    }

    private void HitFX()
    {
        HitFx.Play();
    }
}
