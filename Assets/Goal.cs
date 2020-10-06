using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{

    public GameObject WinUI;

    private void OnTriggerEnter(Collider other) {
        WinUI.SetActive(true);
    }
}
