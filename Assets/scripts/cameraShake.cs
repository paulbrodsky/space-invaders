using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraShake : MonoBehaviour
{
    Transform _target;
    Vector3 _initialPos;

    void Start()
    {
        _target = GetComponent<Transform>();
        _initialPos = _target.localPosition;
    }

    float _pendingShakeDuration = 0f;

    public void Shake(float duration)
    {
        if (duration > 0)
        {
            _pendingShakeDuration += duration;
        }
    }

    bool _isShaking = false;

    void Update()
    {
        if (_pendingShakeDuration > 0 && !_isShaking)
        {
            StartCoroutine(DoShake());
        }
    }

    IEnumerator DoShake()
    {
        _isShaking = true;

        var startTIme = Time.realtimeSinceStartup;
        while (Time.realtimeSinceStartup < startTIme + _pendingShakeDuration)
        {
            var randomPoint = new Vector3(Random.Range(-0.3f, 0.3f), Random.Range(-0.3f, 0.3f), _initialPos.z);
            _target.localPosition = randomPoint;
            yield return null;
        }

        _pendingShakeDuration = 0f;
        _target.localPosition = _initialPos;
        _isShaking = false;
    }
}
