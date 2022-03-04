//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class UnusedCodeBlocks : MonoBehaviour
//{
//    [SerializeField] private float _jumpForce;
//    private Rigidbody _rigidbody;
//    private string[] _legPairs = new string[4] { "_1", "_2", "_3", "_4" };
//    private string _left = "Left";
//    private string _right = "Right";
//    private bool[] _legsUpped = new bool[8];

//    private void Climb()
//    {
//        float rayDistance = 2.5f;
//        RaycastHit hit;
//        Physics.Raycast(transform.position, transform.forward + transform.up / 2, out hit, rayDistance);
//        Debug.DrawRay(transform.position, (transform.forward + transform.up / 2) * 2.5f, Color.red);

//        if (hit.collider != null)
//        {
//            transform.position = Vector3.Lerp(transform.position, hit.point, Time.deltaTime);
//            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(transform.up), Time.deltaTime);
//        }
//    }

//    private void Jump()
//    {
//        if (_legsUpped[0] && _legsUpped[1] && _legsUpped[2] && _legsUpped[3] && _legsUpped[4] && _legsUpped[5] && _legsUpped[6] && _legsUpped[7])
//        {
//            _rigidbody.AddRelativeForce((Vector3.up * _jumpForce + Vector3.forward) * _jumpForce, ForceMode.Impulse);
//        }
//    }

//    private void CreateTimeWindowForButtonsPerfomedState(string leg)
//    {
//        for (int i = 0; i < _legPairs.Length; i++)
//        {
//            if (leg.Contains(_legPairs[i]))
//            {
//                if (leg.Contains(_right))
//                {
//                    StartCoroutine(SetPerfomedState(i + _legPairs.Length));
//                }
//                else
//                {
//                    StartCoroutine(SetPerfomedState(i));
//                }
//            }

//            IEnumerator SetPerfomedState(int index)
//            {
//                float delay = 0.03f;

//                _legsUpped[index] = true;
//                yield return new WaitForSeconds(delay);
//                _legsUpped[index] = false;
//            }
//        }
//    }
//}
