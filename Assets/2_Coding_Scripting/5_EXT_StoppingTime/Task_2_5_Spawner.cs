using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task_2_5_Spawner : MonoBehaviour
{
    [SerializeField] GameObject spawnItem;
    // Start is called before the first frame update
    void Start()
     {
         StartCoroutine (SpawnGenerator());    
     }
     
     IEnumerator SpawnGenerator()
     {
        while(true) 
        { 
            GameObject go = Instantiate(spawnItem, transform.position, Quaternion.identity);
            Rigidbody rb;
            if(go.TryGetComponent<Rigidbody>(out rb)) {
                // Add force to the prefab to move it forward
                rb.AddForce(new Vector3(Random.Range(1,5),Random.Range(1,5),Random.Range(1,5)) * 5.0f);
                //rb.AddForce(transform.forward * 5.0f);
            }
            yield return new WaitForSeconds(1f);
        }
     }
}
