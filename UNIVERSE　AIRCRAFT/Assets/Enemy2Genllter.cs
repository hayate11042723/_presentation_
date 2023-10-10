using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2Genllter : MonoBehaviour
{
	public GameObject rockPrefab;

	void Start()
	{
		InvokeRepeating("GenRock", 180, 1.5f);
	}

	void GenRock()
	{
		Instantiate(rockPrefab, new Vector3(-2.5f + 5 * Random.value, 6, 0), Quaternion.identity);
	}
}
