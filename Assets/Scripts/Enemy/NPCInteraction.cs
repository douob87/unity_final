using UnityEngine;

public class NPCInteraction : MonoBehaviour
{
    public GameObject dialoguePanel; // 設定為 Canvas 裡的 DialoguePanel
    private bool hasTriggered = false;
    private void OnTriggerEnter(Collider other)
    {
        if (!hasTriggered && other.CompareTag("Player"))
        {
            dialoguePanel.SetActive(true);
            hasTriggered = true;
        }

    }
}
