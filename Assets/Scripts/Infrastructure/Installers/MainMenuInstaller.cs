using UnityEngine;
using Zenject;

public class MainMenuInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Debug.Log("All dependencies are now binded(MainMenuInstaller)");
    }
}