using System;
using Unity.Entities;
using UnityEngine;
using Unity.Transforms;
using Unity.Rendering;
[UpdateAfter(typeof(InputSystem))]
public class CheckerBoardSystem:SystemBase
{
    private EntityCommandBufferSystem ecbSource;
    protected override void OnCreate()
    {
        ecbSource = World.GetExistingSystem<EndSimulationEntityCommandBufferSystem>();
        var sr = Resources.Load<GameObject>("BoardPreb");
        var settings = GameObjectConversionSettings.FromWorld(World.DefaultGameObjectInjectionWorld, null);
       
       
        EntityManager manager = World.DefaultGameObjectInjectionWorld.EntityManager;

        var entitiyPrefab = GameObjectConversionUtility.ConvertGameObjectHierarchy(sr, settings);

        var entity = manager.Instantiate(entitiyPrefab);
        manager.SetName(entity, "BoardEntity");
        //manager.AddComponent<ConvertToEntity>(entity);
        manager.AddComponent<CheckerBoard>(entity);
        manager.SetComponentData<CheckerBoard>(entity, new CheckerBoard
        {
            CurrentColor = 1
        });
       
    }

    protected override void OnUpdate()
    {
        EntityCommandBuffer parallelECB = ecbSource.CreateCommandBuffer();
        bool isFinish = false;
        int color = 1;
        Entities.ForEach((CheckerBoard checkerBoard) => {
            isFinish = checkerBoard.Finish;
            color = checkerBoard.CurrentColor;
        }).WithoutBurst().Run();
        Entities.ForEach((Entity entity, InputCom inputCom,ref DirtyDataCom dirtyData) =>
        {
            if (isFinish)
            {
                return;
            }
            dirtyData.state = 1;
            dirtyData.currColor = color;
            if (color == 1)
            {
                color = 2;
            }
            else
            {
                color = 1;
            }
        }).WithoutBurst().Run();
        ecbSource.AddJobHandleForProducer(this.Dependency);
        Entities.ForEach((Entity entity,ref CheckerBoard checkerBoard) => {
            checkerBoard.CurrentColor = color;
        }).WithoutBurst().Run();
    }
}
