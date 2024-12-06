using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Unity.Netcode;

public class TestingNetcodeUI : MonoBehaviour
{
    [SerializeField] private Button startHostButton;
    [SerializeField] private Button startClientButton;

    private void Awake()
    {
        startHostButton.onClick.AddListener(() =>
        {
            //NetworkManager.Singleton.StartHost();
            KitchenGameMultiplayer.Instance.StartHost();
            Debug.Log("Host started");
            Hide();
        });

        startClientButton.onClick.AddListener(() =>
        {
            //NetworkManager.Singleton.StartClient();
            KitchenGameMultiplayer.Instance.StartClient();
            Debug.Log("Host started");
            Hide();
        });
    }

    private void Hide()
    {
        gameObject.SetActive(false);
    }
}
