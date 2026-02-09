using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class TapToSpawn : MonoBehaviour
{
    public GameObject spawnPrefab;
    public Vector3 fixedScale = new Vector3(0.1f, 0.1f, 0.1f);

    private ARRaycastManager raycastManager;
    private static List<ARRaycastHit> hits = new List<ARRaycastHit>();

    private GameObject _spawnedObject;

    void Start()
    {
        raycastManager = GetComponent<ARRaycastManager>();
    }

    void Update()
    {
        // Touch check
        if (Input.touchCount == 0)
            return;

        Touch touch = Input.GetTouch(0);

        if (touch.phase == TouchPhase.Began)
        {
            if (raycastManager.Raycast(touch.position, hits, TrackableType.PlaneWithinPolygon))
            {
                Pose hitPose = hits[0].pose;

                // Old object  destroy
                if (_spawnedObject != null)
                {
                    Destroy(_spawnedObject);
                }

                // New object spawn
                _spawnedObject = Instantiate(
                    spawnPrefab,
                    hitPose.position,
                    Quaternion.identity
                );

                // Fixed size
                _spawnedObject.transform.localScale = fixedScale;
            }
        }
    }

    
}
