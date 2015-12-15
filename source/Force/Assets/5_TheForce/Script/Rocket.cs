using UnityEngine;
using System.Collections;

public class Rocket : MonoBehaviour {

	public float m_YForce = 0.0f;
    

	// Use this for initialization
	void Start () {
	
	}
	
	void FixedUpdate () 
	{
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            m_YForce += 1f;
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            if (m_YForce > 0)
                m_YForce -= 1f;
        }

        float ySpeed = GetComponent<Rigidbody> ().velocity.y;
		float yPos = transform.position.y;
		
		gameObject.GetComponent<Rigidbody> ().AddRelativeForce (0f, m_YForce, 0f); 
	}
}
