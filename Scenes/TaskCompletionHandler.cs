using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskCompletionHandler : MonoBehaviour
{
    public GameObject messagePanel;
    public float delay = 3.0f;

    public void OnTaskCompleted()
    {
        StartCoroutine(ShowMessagePanelAfterDelay());
    }

    private IEnumerator ShowMessagePanelAfterDelay()
    {
        yield return new WaitForSeconds(delay);
        messagePanel.SetActive(true);
    }

   
}
