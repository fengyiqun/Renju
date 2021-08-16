using System;
using Unity.Entities;
using UnityEngine;

public class InputSystem:SystemBase
{
    private EntityCommandBufferSystem ecbSource;
    EntityManager manager;
    protected override void OnCreate()
    {
        ecbSource = World.GetExistingSystem<EndSimulationEntityCommandBufferSystem>();
        manager = World.DefaultGameObjectInjectionWorld.EntityManager;
        var archeType = manager.CreateArchetype( ComponentType.ReadWrite<InputCom>());
        var entity = manager.CreateEntity(archeType);
        manager.SetName(entity, "inputEntity");
        manager.SetComponentData<InputCom>(entity, new InputCom());
    }
    protected override void OnUpdate()
    {
        EntityCommandBuffer parallelECB = ecbSource.CreateCommandBuffer();
        if (Input.GetMouseButtonDown(0)){
            Entities.WithNone<DirtyDataCom>().ForEach((Entity entity,int entityInQueryIndex
                ,InputCom inputCom) =>
            {
                
                Vector2 worldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                Vector2 pos = worldPos /inputCom.Diff;

                pos += inputCom.ZeroPos;

              
                float posx = Mathf.RoundToInt(pos.x);
                float posy = Mathf.RoundToInt(pos.y);
                inputCom.CurrentPos = new Vector2(posx, posy);
                //manager.AddComponent<DirtyDataCom>(entity);
                parallelECB.AddComponent<DirtyDataCom>(entity);
                //inputCom.BoardPos = new Vector2(posx, posy);
                //inputCom.BoardPos = new Vector2(posx*)
            }).WithoutBurst().Run();
            ecbSource.AddJobHandleForProducer(this.Dependency);
        }
    }
}
