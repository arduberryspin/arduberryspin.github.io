using UnityEngine;
using System.Collections;

public class Rocket : MonoBehaviour {

	public float m_YForce = 0.0f;

	public float m_A = 30f;
	public float m_B = 10f;
	public float m_C = 1.6f;

	public float m_TV = 5f;
	public float m_SV = -0.8f;

	public int m_Stage = 1;   // 0=Ground, 1=going up, 2=going down, 3=Landing mode


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {



		if (Input.GetKeyDown (KeyCode.LeftShift)) 
		{
			m_YForce += 1f;
		}
		
		if (Input.GetKeyDown (KeyCode.Z)) 
		{
			m_YForce -= 1f;
		}

	}

	void FixedUpdate () 
	{
		
		float ySpeed = GetComponent<Rigidbody> ().velocity.y;
		float yPos = transform.position.y;
		
		if (m_Stage == 1) {
			if (ySpeed < m_TV) {
				m_YForce += 0.1f;
			}
			else
			{
				if(m_YForce > 0.1f)
				{
					m_YForce -= 0.1f;
				}
			}
			
			if(yPos > m_A)
			{
				m_Stage = 2;
				m_YForce = 0;
			}
		}
		
		if (m_Stage == 2 ) {
			if (ySpeed < m_SV) {
				m_YForce += 0.1f;
			}
			else
			{
				if(m_YForce > 0.1f)
				{
					m_YForce -= 0.1f;
				}
			}
			
			if(yPos < m_B)
			{
				m_Stage = 3;
				//m_YForce = 0;
			}
		}

		if (m_Stage == 3 ) {
			if (ySpeed < m_SV) {
				m_YForce += 0.5f;
			}
			else
			{
				if(m_YForce > 1f)
				{
					m_YForce -= 1f;
				}
			}
			
			if(yPos < m_C)
			{
				m_Stage = 0;
				m_YForce = 0;
			}
		}

		gameObject.GetComponent<Rigidbody> ().AddRelativeForce (0f, m_YForce, 0f); 
	}
}
