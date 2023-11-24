using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveObject : MonoBehaviour
{
    public GameObject player; // 玩家对象引用 Player object
    public Material activeMaterial; // 玩家靠近时的材质 The texture when the player is close
    public AudioClip musicClip; // 音乐剪辑 Sounds
    public float activationDistance = 2.0f; // 激活距离 activation distance

    private Renderer objRenderer;
    private AudioSource audioSource;
    private Material originalMaterial; // 存储原始材质 Store original material

    void Start()
    {
        objRenderer = GetComponent<Renderer>();
        audioSource = GetComponent<AudioSource>();
        originalMaterial = objRenderer.material; // 存储初始材质 Save original material
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }
    }

    void Update()
    {
        float distance = Vector3.Distance(player.transform.position, transform.position);

        if (distance <= activationDistance)
        {
            objRenderer.material = activeMaterial; // 应用新材质 Apply new material
            if (!audioSource.isPlaying)
            {
                audioSource.clip = musicClip; // 设置音乐剪辑
                audioSource.Play(); // 播放声音 Play sound
            }
        }
        else
        {
            objRenderer.material = originalMaterial; // 恢复原始材质 Restore original material
            audioSource.Stop(); // 停止播放声音 Stop sound
        }
    }
}