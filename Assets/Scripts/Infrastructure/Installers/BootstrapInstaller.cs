using UnityEngine;
using Zenject;

public class BootstrapInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Debug.Log("All dependencies are now binded(BootstrapInstaller)");
    }
}