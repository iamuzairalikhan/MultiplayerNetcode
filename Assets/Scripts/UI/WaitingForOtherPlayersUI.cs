using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitingForOtherPlayersUI : MonoBehaviour
{

    private void Start()
    {
        KitchenGameManager.Instance.OnLocalPlayerReadyChanged += KitchenGameManger_OnLocalPlayerReadyChanged;
        KitchenGameManager.Instance.OnStateChanged += KitchenGameManger_OnStateChanged;
        Hide();
    }

    private void KitchenGameManger_OnLocalPlayerReadyChanged(object sender, System.EventArgs e)
    {
        if(KitchenGameManager.Instance.IsLocalPlayerReady())
        {
            Show();
        }
    }

    private void KitchenGameManger_OnStateChanged(object sender, System.EventArgs e)
    {
        if (KitchenGameManager.Instance.IsCountdownToStartActive())
        {
            Hide();
        }
    }

    private void Show()
    {
        gameObject.SetActive(true);
    }
    
    private void Hide()
    {
        gameObject.SetActive(false);
    }
}
