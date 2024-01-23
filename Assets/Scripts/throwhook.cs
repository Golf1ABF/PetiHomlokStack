using UnityEngine;
using System.Collections;

public class throwhook : MonoBehaviour {


	public GameObject hook;


	public bool ropeActive;

	GameObject curHook;

	// Use this for initialization
	void Start () {
		ropeActive = true;
		Vector2 destiny = new Vector3(-0.5f, 3f, 0f);

        SpriteRenderer spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        Vector3 itemSize = spriteRenderer.bounds.size;

        curHook = (GameObject)Instantiate(hook, transform.position, Quaternion.identity);
		curHook.GetComponent<RopeScript> ().destiny = destiny;
    }

    // Update is called once per frame
    void Update () {

        if (Input.GetMouseButtonDown(0))
        {
            Destroy(curHook);
            ropeActive = false;
            gameObject.tag = "Untagged";
        }

        //if (Input.GetMouseButtonDown (0)) {


        //	if (ropeActive == false) {
        //		Vector2 destiny = Camera.main.ScreenToWorldPoint (Input.mousePosition);


        //		curHook = (GameObject)Instantiate (hook, transform.position, Quaternion.identity);

        //		curHook.GetComponent<RopeScript> ().destiny = destiny;


        //		ropeActive = true;
        //	} else {

        //		//delete rope

        //		Destroy (curHook);


        //		ropeActive = false;

        //	}
        //}


    }
}
