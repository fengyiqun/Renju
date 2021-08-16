using System;
using Unity.Entities;
using UnityEngine;
using Unity.Scenes;
using Unity.Transforms;
using Unity.Mathematics;

[UpdateAfter(typeof(CheckerBoardSystem))]
public class PiececsSystem : SystemBase
{

   
    private EntityCommandBufferSystem ecbSource;
    EntityManager manager;
    Entity whitePre;
    Entity blackPre;
    protected override void OnCreate()
    {
        var w = Resources.Load<GameObject>("WhitePreb");
        var b = Resources.Load<GameObject>("BlackPreb");
        var settings = GameObjectConversionSettings.FromWorld(World.DefaultGameObjectInjectionWorld, null);
        ecbSource = World.GetExistingSystem<EndSimulationEntityCommandBufferSystem>();
        manager = World.DefaultGameObjectInjectionWorld.EntityManager;
        whitePre = GameObjectConversionUtility.ConvertGameObjectHierarchy(w, settings);
        blackPre = GameObjectConversionUtility.ConvertGameObjectHierarchy(b, settings);

        
    }

    protected override void OnUpdate()
    {
        EntityCommandBuffer parallelECB = ecbSource.CreateCommandBuffer();
        Entities.ForEach((Entity entity,InputCom inputCom, DirtyDataCom dirtyDataCom) => {
            Entity pieceEntity;
            if(dirtyDataCom.currColor == 1)
            {
                
                pieceEntity = parallelECB.Instantiate(whitePre);
            }
            else
            {
                pieceEntity = parallelECB.Instantiate(blackPre);
            }
            Vector2 currpos = inputCom.CurrentPos;
            currpos -= inputCom.ZeroPos;
            currpos *= inputCom.Diff;
            float3 pos = new float3(currpos.x, currpos.y,-1);
            parallelECB.AddComponent<Piece>(pieceEntity);
            parallelECB.SetComponent<Piece>(pieceEntity, new Piece { Index = 2 }) ;
            parallelECB.SetComponent<Translation>(pieceEntity, new Translation {Value = pos });

            parallelECB.RemoveComponent<DirtyDataCom>(entity);
            
        }).WithoutBurst().Run();
        ecbSource.AddJobHandleForProducer(this.Dependency);
    }
}
