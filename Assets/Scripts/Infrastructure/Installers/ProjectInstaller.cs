using System;
using Infrastructure.Services;
using Infrastructure.Services.Monobehaviour;
using UnityEngine;
using Zenject;

public class ProjectInstaller : MonoInstaller
{
    [SerializeField] private AudioViewManager _audioViewManager;

    private SceneLoaderService _sceneLoaderService;

    public override void InstallBindings()
    {
        BindingComponents();
        BindingMonoBehaviourComponents();
        BindingUI();
        
        Debug.Log("All dependencies are now binded(Project Context)");
    }
    
    private void BindingComponents()
    {
        Container.Bind<SceneLoaderService>().AsSingle().NonLazy();
        
        Debug.Log("Binding c# components is completed");
    }

    private void BindingMonoBehaviourComponents()
    {
        Container.Bind<AudioViewManager>().FromComponentInNewPrefab(_audioViewManager).AsSingle().NonLazy();
        
        Debug.Log("Binding MonoBehaviour is completed");
    }

    private void BindingUI()
    {
        Debug.Log("Binding UI is completed");
    }
}