using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUDController : MonoBehaviour
{
    #region Editor Variables
    [SerializeField]
    private RectTransform m_HealthBar;
    [SerializeField]
    private RectTransform m_PowerBar;

    #endregion

    #region Private Variables

    private float p_HealthBarOrigWidth;
    private float p_PowerBarOrigWidth;


    #endregion

    #region Initialization
    private void Awake()
    {
        p_HealthBarOrigWidth = m_HealthBar.sizeDelta.x;
        p_PowerBarOrigWidth = m_PowerBar.sizeDelta.x;
        UpdateHealth(1);
        UpdatePower(0);
    }
    #endregion

    #region Update Health Bar
    public void UpdateHealth(float percent)
    {
        m_HealthBar.sizeDelta = new Vector2(p_HealthBarOrigWidth * percent, m_HealthBar.sizeDelta.y);
    }

    public void UpdatePower(float percent)
    {
        m_PowerBar.sizeDelta = new Vector2(p_PowerBarOrigWidth * percent, m_PowerBar.sizeDelta.y);
    }
    #endregion

}
