using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraController : MonoBehaviour
{
    [SerializeField] CinemachineVirtualCamera[] m_blendCameras;

    #region Private Variables
    CinemachineVirtualCamera m_currentCamera;
    int m_currentPriorityCam = 0;
    private Vector2 m_startTouchPos;
    private Vector2 m_endTouchPos;
    #endregion

    #region Unity Callbacks
    private void Start()
    {
        InitializeCameras();
    }


    private void Update()
    {
        //check for swipe to the right
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                m_startTouchPos = touch.position;

            }
            if (touch.phase == TouchPhase.Ended)
            {
                m_endTouchPos = touch.position;

                if (m_endTouchPos.x - m_startTouchPos.x > 0)
                {
                    CylcleCameras(0);
                }
                else if(m_endTouchPos.x - m_startTouchPos.x < 0)
                {
                    CylcleCameras(1);

                }
            }
        }

    }
    #endregion

    #region Utility Methods
    private void InitializeCameras()
    {
        //set the current camera to the first camera in the list
        m_currentCamera = m_blendCameras[m_currentPriorityCam];
        //set the priority of that camera to a number above all cameras in the list
        m_currentCamera.Priority = m_blendCameras.Length + 1;
        //set the other cameras priority to 0
        foreach (var cam in m_blendCameras)
        {
            if (cam != m_currentCamera)
            {
                cam.Priority = 0;
            }
        }
    }

    private void CylcleCameras(int nextOrBack)
    {
        switch (nextOrBack)
        {
            case 0:
                m_currentPriorityCam++;
                if (m_currentPriorityCam >= m_blendCameras.Length)
                {
                    m_currentPriorityCam = 0;
                }
                break;
            case 1:
                m_currentPriorityCam--;
                if (m_currentPriorityCam <= 0)
                {
                    m_currentPriorityCam = m_blendCameras.Length -1;
                }
                break;
        }


        m_currentCamera = m_blendCameras[m_currentPriorityCam];

        foreach (var cam in m_blendCameras)
        {
            if (cam != m_currentCamera)
            {
                cam.Priority = 0;
            }
        }
        m_currentCamera.Priority = m_blendCameras.Length + 1;
    }
    #endregion
}
