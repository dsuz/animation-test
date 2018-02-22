using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class MotionController : MonoBehaviour {
    private Animator m_animator;
    private Vector3 m_initialPosition;
    private Quaternion m_initialRotation;

	void Start () {
        m_animator = GetComponent<Animator>();
        m_initialPosition = transform.position;
        m_initialRotation = transform.rotation;
	}

	void Update ()
    {
        int inputNum = -1;

        for (int i = 0; i < 10; i++)
        {
            if (Input.GetKeyDown(i.ToString()))
            {
                inputNum = i;
            }
        }

        if (inputNum > -1)
        {
            Debug.Log("Set State: " + inputNum);
            m_animator.SetInteger("State", inputNum);
            transform.position = m_initialPosition;
            transform.rotation = m_initialRotation;
        }
    }
}
