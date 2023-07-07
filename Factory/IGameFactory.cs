using System.Collections.Generic;
using CodeBase.Enemy;
using CodeBase.Infrastructure.Services;
using CodeBase.Infrastructure.Services.PersistentProgress;
using CodeBase.Logic;
using CodeBase.StaticData;
using UnityEngine;

namespace CodeBase.Infrastructure.Factory
{
    public interface IGameFactory : IService
    {
        GameObject CreateHero(GameObject at);

        GameObject CreateHud();
        List<ISavedProgressReader> ProgressReaders { get; }
        List<ISavedProgress> ProgressWriters { get; }
        void CleanUp();
        void CreateSpawner(string SpawnerId,Vector3 at, MonsterTypeId monsterTypeId);
        GameObject CreateMonster(MonsterTypeId monsterTypeId, Transform parent);
        LootPeace CreateLoot();
    }
}