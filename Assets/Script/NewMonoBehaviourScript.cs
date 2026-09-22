using UnityEngine;
public class StateFXPractice : MonoBehaviour
{
    [SerializeField] ParticleSystem practiceFX;
    bool effectActive = false;
    void Update()
    {
        RespondToDebugKeys();
    }
    void RespondToDebugKeys()
    {
        if (Input.GetKeyDown(KeyCode.P) && !effectActive)
        {
            ActivateEffect();
            effectActive = true;
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            ResetEffect();
            effectActive = false;
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            ChangeEffectColor();
        }
    }
    void ActivateEffect()
    {
        effectActive = true;
        practiceFX.Play();
        Debug.Log("Effect activated");
    }
    void ResetEffect()
    {
        effectActive = false;
        practiceFX.Stop();
        Debug.Log("Effect reset.");
    }
    void ChangeEffectColor()
    {
        var main = practiceFX.main;
        main.startColor = Random.ColorHSV();
        Debug.Log("Particle color changed.");
    }
}