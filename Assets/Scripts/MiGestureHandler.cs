using Microsoft.MixedReality.Toolkit;
using Microsoft.MixedReality.Toolkit.Input;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiGestureHandler : MonoBehaviour, IMixedRealityGestureHandler<Vector3>
{

    private void OnEnable()
    {
        // Con esto indicamos que queremos recibir todos los eventos de tipo IMixedRealityGestureHandler
        CoreServices.InputSystem?.RegisterHandler<IMixedRealityGestureHandler<Vector3>>(this);
    }

    public void OnGestureCompleted(InputEventData<Vector3> eventData)
    {

        // eventData.InputData
        // eventData.MixedRealityInputAction

    }

    public void OnGestureUpdated(InputEventData<Vector3> eventData)
    {
        throw new System.NotImplementedException();
    }

    public void OnGestureStarted(InputEventData eventData)
    {
        throw new System.NotImplementedException();
    }

    public void OnGestureUpdated(InputEventData eventData)
    {
        throw new System.NotImplementedException();
    }

    public void OnGestureCompleted(InputEventData eventData)
    {
        throw new System.NotImplementedException();
    }

    public void OnGestureCanceled(InputEventData eventData)
    {
        throw new System.NotImplementedException();
    }
}
