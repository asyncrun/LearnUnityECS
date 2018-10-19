using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;

public class InputSystem : ComponentSystem
{
    private struct Data
    {
        public readonly int Length;
        public ComponentArray<InputComponent> InpuComponents;
    }

    [Inject] private Data _data;

    protected override void OnUpdate()
    {
        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");
        for (int i = 0; i < _data.Length; i++)
        {
            _data.InpuComponents[i].Horizontal = horizontal;
            _data.InpuComponents[i].Vertical = vertical;
        }
    }
}
