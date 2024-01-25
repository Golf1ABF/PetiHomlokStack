using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomlokSpawner : MonoBehaviour
{
    [SerializeField] private GameObject HomlokPrefab;
    private GameObject MainCamera;

    // Start is called before the first frame update
    void Start()
    {
        MainCamera = GameObject.FindWithTag("MainCamera");
        Instantiate(HomlokPrefab, transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Leesett()
    {
        transform.position += new Vector3(0, 1);
        Instantiate(HomlokPrefab, transform.position, Quaternion.identity);
        MainCamera.transform.position += new Vector3(0, 0.5f);
    }
}
