using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;
using TMPro;

public class EntityCountSystem : ComponentSystem
{
    struct Group
    {
        public readonly int Length;
        public ComponentDataArray<CountData> countData;
    }

    [Inject]
    Group group;

    protected override void OnUpdate()
    {
        for(var idx = 0; idx < group.Length; ++idx)
        {
            var countData = group.countData[idx];
            countData.Count++;
            group.countData[idx] = countData;
        }
    }
}
