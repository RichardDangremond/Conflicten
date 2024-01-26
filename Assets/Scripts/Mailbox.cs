using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager;
using UnityEngine;

public class Mailbox : MonoBehaviour
{
  
       private GoToScene _goToScene;
  

    private void OnTriggerEnter(Collider other)
    {
        TryGetComponent<GoToScene>(out _goToScene);
        if (_goToScene != null)  _goToScene.LoadLevel();

        if (other.gameObject.CompareTag("Brievenbus")) _goToScene.LoadLevel();
    }
} 