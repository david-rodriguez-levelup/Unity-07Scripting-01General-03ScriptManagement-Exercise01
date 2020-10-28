using System;
using UnityEngine;

public class RegionOrder : MonoBehaviour
{

    #region Public fields and properties

    public Action EventSample;

    public int PublicPropertySample { get; set; }

    public string publicVariableSample;

    #endregion

    #region Private fields and properties

    private string _privateVariableSample;

    #endregion

    #region Unity lifecycle

    private void Awake()
    {

    }

    public void Start()
    {

    }

    #endregion

    #region Private methods

    private void PrivateSampleMethod()
    {

    }

    #endregion

    #region Public methods

    public void PublicSampleMethod()
    {

    }

    #endregion

    #region Events

    private void OnEventSample()
    {
        if (EventSample != null)
        {
            EventSample.Invoke();
        }
    }

    #endregion

}
