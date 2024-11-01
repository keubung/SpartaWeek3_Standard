using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.XR;

public class UISetting : MonoBehaviour
{
    public GameObject settingWindow;

    private PlayerController controller;

    void Start()
    {
        controller = CharacterManager.Instance.Player.controller;

        controller.setting += Toggle;
        settingWindow.SetActive(false);
    }

    public void Toggle()
    {
        if (IsOpen())
        {
            settingWindow.SetActive(false);
        }
        else if (!IsOpen())
        {
            settingWindow.SetActive(true);
        }
    }

    public bool IsOpen()
    {
        return settingWindow.activeInHierarchy;
    }
}
