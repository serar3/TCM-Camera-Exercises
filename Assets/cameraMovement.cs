using UnityEngine;

public class cameraMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject[] waypoints;
    float interpolation = 0;
    int i = 0;
    public int interpolationFramesCount = 45; // Number of frames to completely interpolate between the 2 positions
    float elapsedFrames = 0;
    Vector3 interpolatedPosition;


    // Update is called once per frame

    void Update()
    {
        if (i < waypoints.Length - 1)
        {
            float interpolation = elapsedFrames / interpolationFramesCount;
            interpolatedPosition = Vector3.Lerp(waypoints[i].transform.position, waypoints[i + 1].transform.position, interpolation * Time.deltaTime);
            Camera.main.transform.position = interpolatedPosition;
            if (interpolatedPosition == waypoints[i].transform.position)
                i++;
        }
        
    }
}
