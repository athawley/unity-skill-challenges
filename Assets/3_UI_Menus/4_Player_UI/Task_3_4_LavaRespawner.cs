using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task_3_4_LavaRespawner : MonoBehaviour
{
    [SerializeField] Transform spawnLocation;
    void OnTriggerEnter(Collider col) {
        if(col.CompareTag("Player")) {
            Debug.Log("You Died");
            col.gameObject.SetActive(false);
            col.gameObject.transform.position = spawnLocation.position;
            col.gameObject.SetActive(true);
        }
    }
}
