using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class InteractionAndTextScript : MonoBehaviour
{
    public GameObject player; // 玩家对象
    public GameObject interactableObject; // 可交互物体
    public Text interactionText; // 显示交互提示的文本
    public GameObject textCanvas; // 引用新建的包含文本的Canvas
    public Text canvasText; // Canvas中的Text组件

    public float interactionDistance = 5f; // 交互距离
    public float letterPause = 0.1f; // 字母间隔时间
    public AudioClip typeSound; // 字母音效

    private InputAction interactAction;
    private AudioSource audioSource;

    private void Awake()
    {
        var gameplayController = new GameplayController();
        interactAction = gameplayController.GamePlay.Interact;
        interactAction.Enable();
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null) { audioSource = gameObject.AddComponent<AudioSource>(); }

    }

    private void Update()
    {
        float distance = Vector3.Distance(player.transform.position, interactableObject.transform.position);

        if (distance <= interactionDistance)
        {
            interactionText.enabled = true;

            if (interactAction.triggered)
            {
                interactionText.enabled = false;
                textCanvas.SetActive(true); // 显示Canvas
            }
        }
        else
        {
            interactionText.enabled = false;
            textCanvas.SetActive(false); // 距离过远时隐藏Canvas
        }
    }
}