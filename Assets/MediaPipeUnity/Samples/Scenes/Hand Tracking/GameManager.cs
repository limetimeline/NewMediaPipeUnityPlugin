using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mediapipe;
using Mediapipe.Unity;

public class GameManager : MonoBehaviour
{
  /*  List<ClassificationList> handednessOutput;
    List<NormalizedLandmarkList> handLandmarks;*/
  public static Mediapipe.NormalizedLandmarkList handLandmarks;

// Mediapipe.NormalizedLandmarkList의 형식 : { "landmark": [ { "x": 0.125763208, "y": 0.937899232, "z": 7.921184E-07 }, { "x": 0.215069473, "y": 0.8849838, "z": -0.0183397252 }, { "x": 0.281146377, "y": 0.7867832, "z": -0.01669508 }, { "x": 0.332808375, "y": 0.716813445, "z": -0.01576735 }, { "x": 0.376224637, "y": 0.677740633, "z": -0.0134914843 }, { "x": 0.209386781, "y": 0.5795886, "z": 0.03426379 }, { "x": 0.231197268, "y": 0.453139544, "z": 0.0443702564 }, { "x": 0.23937121, "y": 0.3899349, "z": 0.0414586142 }, { "x": 0.241490915, "y": 0.3416087, "z": 0.0393064544 }, { "x": 0.151603386, "y": 0.5628677, "z": 0.03933436 }, { "x": 0.166470647, "y": 0.4186594, "z": 0.0623497479 }, { "x": 0.170503467, "y": 0.3403554, "z": 0.06452321 }, { "x": 0.170448333, "y": 0.288046658, "z": 0.0636859 }, { "x": 0.09732776, "y": 0.57615906, "z": 0.0386317633 }, { "x": 0.102107458, "y": 0.447109938, "z": 0.0587596074 }, { "x": 0.108614087, "y": 0.3839664, "z": 0.059363652 }, { "x": 0.11462184, "y": 0.337907255, "z": 0.0564999841 }, { "x": 0.04335682, "y": 0.6118878, "z": 0.0338430479 }, { "x": 0.03656724, "y": 0.520229638, "z": 0.0506029129 }, { "x": 0.03676085, "y": 0.47700727, "z": 0.060774304 }, { "x": 0.0419335365, "y": 0.446623743, "z": 0.06714895 } ] }
// Mediapipe.NormalizedLandmarkList의 랜드마크 추출 : Mediapipe.NormalizedLandmarkList.Landmark
// Mediapipe.NormalizedLandmarkList.Landmark의 요소 추출 : Mediapipe.NormalizedLandmarkList.Landmark.X, .Y, .Z
  private void Update()
  {
    Debug.Log("<Landmark>");
    if (handLandmarksInfo != null){
      foreach (var item in handLandmarksInfo.Landmark){
        // Debug.Log(handLandmarksInfo.Landmark[11]);
        Debug.Log(item.X);
      }
    }
  }
  
  public void OutputHandWorldLandmarks(OutputEventArgs<List<LandmarkList>> handWorldLandmarks)
  {
    if (handWorldLandmarks.value != null && handWorldLandmarks.value.Count > 0)
    {
      foreach (var handWorldLandmark in handWorldLandmarks.value)
      {
//         Debug.Log(handWorldLandmark);
      }
    }
  }

  public void OutputPalmDetections(OutputEventArgs<List<Detection>> palmDetections)
  {
    if (palmDetections.value != null && palmDetections.value.Count > 0)
    {
      foreach (var palmDetection in palmDetections.value)
      {
//         Debug.Log(palmDetection);
      }
    }
  }

  public void OutputHandRectsFromPalmDetections(OutputEventArgs<List<NormalizedRect>> HandRectsFromPalmDetections)
  {
    if (HandRectsFromPalmDetections.value != null && HandRectsFromPalmDetections.value.Count > 0)
    {
      foreach (var HandRectsFromPalmDetection in HandRectsFromPalmDetections.value)
      {
//         Debug.Log(HandRectsFromPalmDetection);
      }
    }
  }

  public void OutputHandLandmarks(OutputEventArgs<List<NormalizedLandmarkList>> handLandmarks)
  {
    if (handLandmarks.value != null && handLandmarks.value.Count > 0)
    {
      foreach (var landmarks in handLandmarks.value)
      {
//         Debug.Log(landmarks);
           handLandmarksInfo = landmarks;
      }
    }
  }

  public void OutputHandRectsFromLandmarks(OutputEventArgs<List<NormalizedRect>> handRectsFromLandmarks)
  {
    if (handRectsFromLandmarks.value != null && handRectsFromLandmarks.value.Count > 0)
    {
      foreach (var handRectsFromLandmark in handRectsFromLandmarks.value)
      {
//         Debug.Log(handRectsFromLandmark);
      }
    }
  }

  public void OutputHandedness(OutputEventArgs<List<ClassificationList>> handedness)
  {
    if (handedness.value != null && handedness.value.Count > 0)
    {
      foreach (var hand in handedness.value)
      {
//         Debug.Log(hand);
      }
    }
  }

}
