using UnityEngine;
using UnityEngine.InputSystem;

namespace Assets.Scripts.Actors
{
    // Receives inputs from Unity Input system
    public class PlayerInputListener : MonoBehaviour
    {
        // Movement command assigned when input is detected
        private ObjectMoveCommand command;

        // Speed of movement
        [SerializeField] float moveSpeed = 1;

        // Execute command if it's assigned
        private void FixedUpdate()
        {
            if( command != null)
            {
                Debug.Log($"Command - Execute");
                command.Execute();
            }
        }


        // Triggered whenever input is received
        private void OnMove(InputValue value)
        {
            var moveVal = value.Get<Vector2>().normalized;

            if( moveVal != Vector2.zero)
            {
                // Create command to perform movement, but only if there is a movement direction
                command = new ObjectMoveCommand(moveSpeed, moveVal, this.gameObject);
            }
            else
            {
                // Otherwise if no movement detection, clear command
                command = null;
            }
        }
    }
}
