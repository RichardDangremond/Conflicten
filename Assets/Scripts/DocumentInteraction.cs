using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DocumentInteraction : MonoBehaviour
{

    public Decision decision;

    public string WarSceneName;
    public string HungerSceneName;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Brievenbus")
        {
            if(decision == Decision.Honger)
            {
                LevelManager.Instance.LoadLevel(HungerSceneName);
            }

            if (decision == Decision.Oorlog)
            {
                LevelManager.Instance.LoadLevel(WarSceneName);
            }
        }
    }

    public enum Decision
    {
        Oorlog,
        Honger
    }
}
