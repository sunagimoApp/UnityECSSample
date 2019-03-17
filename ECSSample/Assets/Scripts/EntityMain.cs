using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;
using TMPro;

public class EntityMain : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI textLbl;

    EntityManager manager;
    Entity entity;

    void Start()
    {
        manager = World.Active.GetOrCreateManager<EntityManager>();
        var archeType = manager.CreateArchetype(typeof(CountData));
        entity = manager.CreateEntity(archeType);
    }
    
    void Update()
    {
        textLbl.text = manager.GetComponentData<CountData>(entity).Count.ToString();
    }
}
