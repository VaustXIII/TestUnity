using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelTextController : MonoBehaviour {

	// Use this for initialization
	void Start () {
        var text = GetComponent<UnityEngine.UI.Text>();
        text.text = "Level " + LevelGenerator.CurrentLevel;
	}
}
