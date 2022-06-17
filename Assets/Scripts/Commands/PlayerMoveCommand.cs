using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveCommand : ICommand
{
    private GameObject _gameObject;
    private Color _color;
    private Color _previousColor;

    public PlayerMoveCommand(GameObject gameObject, Color color)
    {
        _gameObject = gameObject;
        _color = color;
    }

    public void Execute()
    {
        var meshRenderer = _gameObject.GetComponent<MeshRenderer>();
        _previousColor = meshRenderer.material.color;
        meshRenderer.material.color = _color;
    }

    public void Undo()
    {
        var meshRenderer = _gameObject.GetComponent<MeshRenderer>();
        meshRenderer.material.color = _previousColor;
    }
}

