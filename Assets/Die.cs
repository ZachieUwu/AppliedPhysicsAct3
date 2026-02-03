using Unity.Burst.Intrinsics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Firing : MonoBehaviour
{
    public Animator animator;

    void OnMouseDown()
    {
         this.animator.enabled = false;
    }
}