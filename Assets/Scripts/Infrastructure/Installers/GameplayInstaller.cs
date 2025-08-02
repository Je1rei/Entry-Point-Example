using UnityEngine;
using Zenject;

public class GameplayInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Debug.Log("All dependencies are now binded(GameplayInstaller)");
    }
}