using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 [System.Serializable]
 public class AbilityInfo
    {
        #region Editor Variable
    [SerializeField]
        private int m_Power;
        public int Power
        {
            get
            {
                return m_Power;
            }
        }

        [SerializeField]
        float m_Range;
        public float Range
        {
            get
            {
                return m_Range;
            }
        }

        #endregion
    }

