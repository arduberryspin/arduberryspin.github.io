using UnityEngine;
using System.Collections;

public class Rocket5 : MonoBehaviour {
	
    // Current Y direction force
	public float m_YForce = 0.0f;
	
    // Set Points
	public float m_A_TargetHeight = 30f;
	public float m_B_LandingHeight = 10f;
	public float m_C_LandingSpeed = 1.6f;
	
	public float m_AscendingTargetSpeed = 5f;
	public float m_DescendingTargetSpeed = -0.8f;
	
	public int m_Stage = 1;   // 0=Ground, 1=going up, 2=going down, 3=Landing mode

    // Proportional Values
    public float m_SpeedStep = 0.1f;
    public float m_Kp_AscForce = 10f;
    public float m_MaxForce = 10f;


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

        // Rising
		if (m_Stage == 1) {

            float pSpeedError = m_A_TargetHeight - transform.position.y;
            m_SpeedStep = pSpeedError * m_Kp_AscForce;

            m_YForce = Mathf.Clamp(m_SpeedStep, 0f, m_MaxForce);

            if (yPos > m_A_TargetHeight) {
				m_Stage = 2;
				m_YForce = 0;
                m_SpeedStep = 0.1f;
            }
		}
		
        
        // Falling
		if (m_Stage == 2) {
			if (ySpeed < m_DescendingTargetSpeed) {
				m_YForce += 0.1f;
			} else {
				if (m_YForce > 0.1f) {
					m_YForce -= 0.1f;
				}
			}
			
			if (yPos < m_B_LandingHeight) {
				m_Stage = 3;
				//m_YForce = 0;
			}
		}
		
        // Landing
		if (m_Stage == 3) {
			if (ySpeed < m_DescendingTargetSpeed) {
				m_YForce += m_SpeedStep;
			} else {
				if (m_YForce > 1f) {
					m_YForce -= 1f;
				}
			}
			
			if (yPos < m_C_LandingSpeed) {
				m_Stage = 0;
				m_YForce = 0;
			}
		}
		
		gameObject.GetComponent<Rigidbody> ().AddRelativeForce (0f, m_YForce, 0f); 
	}
}
