using UnityEngine;
using System.Collections;

public class Ground : MonoBehaviour {

	
	public GameObject m_Explosion;
	public float m_ExplosionSpeed = 2f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision collision) 
	{
		foreach (ContactPoint contact in collision.contacts) {
			Debug.DrawRay(contact.point, contact.normal, Color.red, 10f);
			Debug.DrawRay(contact.point, contact.otherCollider.GetComponent<Rigidbody>().velocity, Color.blue, 10f);
		}

		if (collision.relativeVelocity.magnitude > m_ExplosionSpeed) {
			print ("Boom!!!");
			print (collision.relativeVelocity.magnitude);
			print (collision.relativeVelocity);
			Instantiate(m_Explosion, collision.transform.position, collision.transform.rotation);
			Destroy(collision.gameObject, 5f);
		} else 
		{
			print ("  Success!!!  ");
			print (collision.relativeVelocity.magnitude);
			print (collision.relativeVelocity);
		}
	}
}
