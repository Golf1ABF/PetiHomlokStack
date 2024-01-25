using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class HomlokSpawner : MonoBehaviour
{
    [SerializeField] private GameObject HomlokPrefab;
    private GameObject MainCamera;

    private bool isGameOver = false;

    // Start is called before the first frame update
    void Start()
    {
        MainCamera = GameObject.FindWithTag("MainCamera");
        Instantiate(HomlokPrefab, transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameOver)
        {
            var cur = GameObject.FindWithTag("Player");
            GameObject.Destroy(cur); 
            Scene scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(scene.name);
        }
    }

    void setGameOver(bool val) { isGameOver = val; }

    void Leesett()
    {
        if(!isGameOver)
        {
            transform.position += new Vector3(0, 0.8f);
            Instantiate(HomlokPrefab, transform.position, Quaternion.identity);
            MainCamera.transform.position += new Vector3(0, 0.6f);
        }
    }
}
