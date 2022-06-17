using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Command to move specified object
public class ObjectMoveCommand : ICommand
{
    Vector3 _movementDirection;
    GameObject _gameObject;
    float _movementSpeed;

    public ObjectMoveCommand(float movementSpeed, Vector3 movementDirection, GameObject gameObject)
    {
        _movementDirection = movementDirection;
        _movementSpeed = movementSpeed;
        _gameObject = gameObject;
    }

    public void Execute()
    {
        _gameObject.transform.position += _movementSpeed * Time.deltaTime * _movementDirection;
    }

    public void Undo()
    {
        _gameObject.transform.position -= _movementSpeed * Time.deltaTime * _movementDirection;
    }
}

