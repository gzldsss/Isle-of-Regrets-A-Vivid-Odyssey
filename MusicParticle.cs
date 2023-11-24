using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(ParticleSystem))]
public class MusicDrivenParticles : MonoBehaviour
{
    public AudioSource audioSource;
    private ParticleSystem particles;
    private ParticleSystem.EmissionModule emissionModule;

    void Start()
    {
        particles = GetComponent<ParticleSystem>();
        emissionModule = particles.emission;
        if (audioSource == null)
        {
            audioSource = FindObjectOfType<AudioSource>();
        }
    }

    void Update()
    {
        
        float[] spectrum = new float[256];
        // 获取当前音频的频谱数据。
        // Get the spectrum data of the current audio.
        audioSource.GetSpectrumData(spectrum, 0, FFTWindow.Rectangular);

        float intensity = 0f;
        foreach (var value in spectrum)
        {
            intensity += value;
        }

        // 音频的强度乘以一个系数，得到粒子系统的发生率，应用到粒子系统的发射模块上，从而使粒子的发射率与音频的强度成正比。
        // The intensity of the audio is multiplied by a coefficient to obtain the occurrence rate of the particle system
        // which is applied to the emission module of the particle system
        // So that the emission rate of the particles is proportional to the intensity of the audio
        float emissionRate = intensity * 5000f;

        // 应用到粒子系统的发射率
        emissionModule.rateOverTime = emissionRate;
    }
}