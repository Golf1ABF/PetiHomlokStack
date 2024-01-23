using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomlokSpawner : MonoBehaviour
{
    [SerializeField] private GameObject HomlokPrefab;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(HomlokPrefab, transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
