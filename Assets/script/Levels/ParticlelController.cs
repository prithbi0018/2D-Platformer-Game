using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticlelController : MonoBehaviour
{
    public ParticleSystem playerWinParticleSystem;  

    public void PlayPlayerWinEffect()
    {
        playerWinParticleSystem.Play();  
    }
}
