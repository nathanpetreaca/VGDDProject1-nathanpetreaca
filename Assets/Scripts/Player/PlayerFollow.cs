using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollow : MonoBehaviour
{
    #region Editor Variables
    [SerializeField]
    [Tooltip("The player to follow")]
    private Transform m_PlayerTransfrom;

    [SerializeField]
    [Tooltip("Player offset to camera")]
    private Vector3 m_Offset;

    [SerializeField]
    [Tooltip("How fast camera rotates")]
    private float m_RotationSpeed = 10;

    #endregion

    #region Main Updates
    private void LateUpdate()
    {
        Vector3 newPos = m_PlayerTransfrom.position + m_Offset;

        transform.position = Vector3.Slerp(transform.position, newPos, 1);

        float rotationAmount = m_RotationSpeed * Input.GetAxis("Mouse X");
        transform.RotateAround(m_PlayerTransfrom.position, Vector3.up, rotationAmount);
        m_Offset = transform.position - m_PlayerTransfrom.position;
    }
    #endregion
}
