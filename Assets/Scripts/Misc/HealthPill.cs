using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPill : MonoBehaviour
{
    #region Editor Variables

    [SerializeField]
    private int m_HealthGain;

    [SerializeField]
    private int m_PowerGain;
    public int HealthGain
    {
        get
        {
            return m_HealthGain;
        }
    }

    public int PowerGain
    {
        get
        {
            return m_PowerGain;
        }
    }

    #endregion
}
