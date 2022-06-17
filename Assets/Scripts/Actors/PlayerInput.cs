using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Assets.Scripts.Actors
{
    public class PlayerInput : MonoBehaviour
    {
        // Movement vector received from input
        [SerializeField] Vector3 MoveVal;

        // Speed of movement
        [SerializeField] float moveSpeed = 1;

        private void FixedUpdate()
        {
            transform.position += moveSpeed * Time.deltaTime * MoveVal;
        }

        private void OnMove(InputValue value)
        {
            MoveVal = value.Get<Vector2>().normalized;
        }
    }
}
