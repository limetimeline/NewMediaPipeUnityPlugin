using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mediapipe;
using Mediapipe.Unity;

public class GameManager : MonoBehaviour
{
  /*  List<ClassificationList> handednessOutput;
    List<NormalizedLandmarkList> handLandmarks;*/
  public Mediapipe.NormalizedLandmarkList handLandmarks;

  private void Update()
  {

  }
  public void OutputHandWorldLandmarks(OutputEventArgs<List<LandmarkList>> handWorldLandmarks)
  {
    if (handWorldLandmarks.value != null && handWorldLandmarks.value.Count > 0)
    {
      foreach (var handWorldLandmark in handWorldLandmarks.value)
      {
        Debug.Log(handWorldLandmark);
      }
    }
  }

  public void OutputPalmDetections(OutputEventArgs<List<Detection>> palmDetections)
  {
    if (palmDetections.value != null && palmDetections.value.Count > 0)
    {
      foreach (var palmDetection in palmDetections.value)
      {
        Debug.Log(palmDetection);
      }
    }
  }

  public void OutputHandRectsFromPalmDetections(OutputEventArgs<List<NormalizedRect>> HandRectsFromPalmDetections)
  {
    if (HandRectsFromPalmDetections.value != null && HandRectsFromPalmDetections.value.Count > 0)
    {
      foreach (var HandRectsFromPalmDetection in HandRectsFromPalmDetections.value)
      {
        Debug.Log(HandRectsFromPalmDetection);
      }
    }
  }

  public void OutputHandLandmarks(OutputEventArgs<List<NormalizedLandmarkList>> handLandmarks)
  {
    if (handLandmarks.value != null && handLandmarks.value.Count > 0)
    {
      foreach (var landmarks in handLandmarks.value)
      {
        Debug.Log(landmarks);
      }
    }
  }

  public void OutputHandRectsFromLandmarks(OutputEventArgs<List<NormalizedRect>> handRectsFromLandmarks)
  {
    if (handRectsFromLandmarks.value != null && handRectsFromLandmarks.value.Count > 0)
    {
      foreach (var handRectsFromLandmark in handRectsFromLandmarks.value)
      {
        Debug.Log(handRectsFromLandmark);
      }
    }
  }

  public void OutputHandedness(OutputEventArgs<List<ClassificationList>> handedness)
  {
    if (handedness.value != null && handedness.value.Count > 0)
    {
      foreach (var hand in handedness.value)
      {
        Debug.Log(hand);
      }
    }
  }

}
