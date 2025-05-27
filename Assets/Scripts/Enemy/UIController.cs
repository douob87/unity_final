using UnityEngine;

public class UIController : MonoBehaviour
{
    public GameObject dialoguePanel;

    public void OnConfirmButtonClick()
    {
        dialoguePanel.SetActive(false);
    }
}
