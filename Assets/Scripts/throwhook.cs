using UnityEngine;
using System.Collections;

public class throwhook : MonoBehaviour {


	public GameObject hook;
    private GameObject HomlokSpawner;


	public bool ropeActive;

	GameObject curHook;

	// Use this for initialization
	void Start () {
		ropeActive = true;
        HomlokSpawner = GameObject.Find("HomlokSpawner");
        Vector2 destiny = new Vector3(-0.5f, HomlokSpawner.transform.position.y + 2, 0f);

        SpriteRenderer spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        Vector3 itemSize = spriteRenderer.bounds.size;

        curHook = (GameObject)Instantiate(hook, transform.position, Quaternion.identity);
		curHook.GetComponent<RopeScript> ().destiny = destiny;

        
    }

    // Update is called once per frame
    void Update () {

        if (Input.GetMouseButtonDown(0) && ropeActive)
        {
            Destroy(curHook);
            ropeActive = false;
            gameObject.tag = "Untagged";
            HomlokSpawner.SendMessage("Leesett");
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("ok");
    }
}
