using UnityEngine;
using System.Collections;

public class LoseColider : MonoBehaviour {
	public LevelManager levelManager;
	void OnTriggerEnter2D(Collider2D trigger)
	{
		print ("trigger");
		levelManager.LoadLevel("Win Screen");
	}
	void OnCollisionEnter2D(Collision2D collision)
	{
		print ("collision");
	}
}
