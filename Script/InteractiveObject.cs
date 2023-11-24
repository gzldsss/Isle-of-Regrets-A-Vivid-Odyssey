using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterialOnCollision : MonoBehaviour
{
    public Material newMaterial; // 新材质

    private Renderer objRenderer;
    private Material originalMaterial; // 保存原始材质

    void Start()
    {
        objRenderer = GetComponent<Renderer>();
        originalMaterial = objRenderer.material; // 保存原始材质
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("检测到碰撞: " + collision.gameObject.name); // 输出碰撞的物体名称

        if (collision.gameObject.CompareTag("Player")) // 检查碰撞的是否为玩家
        {
            objRenderer.material = newMaterial; // 更换为新材质
        }
    }
}