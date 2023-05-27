using UnityEngine;
using Cinemachine;

/// <summary>
/// An add-on module for Cinemachine Virtual Camera that locks the camera's X and Y coordinates
/// </summary>
[ExecuteInEditMode]
[SaveDuringPlay]
[AddComponentMenu("")] // Hide in menu
public class LockCameraPosition : CinemachineExtension
{
    [Tooltip("Lock the camera's X and Y positions to these values")]
    public float m_XPosition = 0;
    public float m_YPosition = 2;

    protected override void PostPipelineStageCallback(
        CinemachineVirtualCameraBase vcam,
        CinemachineCore.Stage stage, ref CameraState state, float deltaTime)
    {
        if (stage == CinemachineCore.Stage.Body)
        {
            var pos = state.RawPosition;
            pos.x = m_XPosition;
            pos.y = m_YPosition;
            state.RawPosition = pos;
        }
    }
}