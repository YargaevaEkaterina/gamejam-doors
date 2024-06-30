using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleClick : MonoBehaviour
{
    public ParticleSystem particles; // ѕеретащите вашу систему частиц в это поле через редактор Unity

    void Start()
    {
        particles.Stop(); // ”бедитесь, что частицы остановлены при запуске сцены
    }

    public void ActivateParticles()
    {
        particles.Play(); // «апускаем систему частиц
        // ƒополнительные действи€, если требуетс€
    }
}
