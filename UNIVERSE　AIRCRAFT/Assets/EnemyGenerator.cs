using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
	public GameObject rockPrefab;

	void Start()
	{
		InvokeRepeating("GenRock", 1, 0.8f);
	}

	void GenRock()
	{
		Instantiate(rockPrefab, new Vector3(-2.5f + 4 * Random.value, 4, 0), Quaternion.identity);
	}
}
