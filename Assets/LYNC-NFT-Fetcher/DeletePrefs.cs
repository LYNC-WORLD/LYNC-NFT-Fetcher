using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeletePrefs : MonoBehaviour
{
    private void Awake()
    {
        #if UNITY_EDITOR
            if (PlayerPrefs.HasKey("WalletAddress"))
            {
                PlayerPrefs.DeleteKey("WalletAddress");
            }
        #endif
    }
}
