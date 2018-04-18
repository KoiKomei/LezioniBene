﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReactiveTarget : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    public void ReactToHit() {
        WanderinAi behavior = GetComponent<WanderinAi>();
        if (behavior != null) {
            behavior.SetAlive(false);
        }
        StartCoroutine(Die());

    }

    private IEnumerator Die() {
        this.transform.Rotate(-75, 0, 0);

        yield return new WaitForSeconds(2.0f);

        Destroy(this.gameObject);
    }

	// Update is called once per frame
	void Update () {
		
	}
}
