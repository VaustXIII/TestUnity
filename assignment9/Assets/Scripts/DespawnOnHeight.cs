using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DespawnOnHeight : MonoBehaviour {

    public float LowerThan = -1;
    public GameObject[] ToDestroy;

    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y < LowerThan)
        {
            SceneManager.LoadScene("GameOver");
            foreach(var go in ToDestroy)
            {
                Destroy(go);
            }
        }
	}
}
