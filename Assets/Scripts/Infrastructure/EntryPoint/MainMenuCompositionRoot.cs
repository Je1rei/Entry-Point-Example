using Infrastructure.Services;
using UnityEngine;
using Zenject;

namespace Infrastructure.EntryPoint
{
    public class MainMenuCompositionRoot : MonoBehaviour, ICompose
    {
        [SerializeField] private SceneContext _sceneContext;
        
        private DiContainer _diContainer;
        
        private SceneLoaderService _sceneLoaderService;
        
        [Inject]
        public void Compose(DiContainer container)
        {
            _diContainer = _sceneContext.Container;
            
            _sceneLoaderService = _diContainer.Resolve<SceneLoaderService>();
            
            // Resolve if needed
            // Construct/Compose dependencies
            
            ConstructComponents();
        }
        
        private void ConstructComponents()
        {
            Debug.Log("Components on Main Menu is constructed");
            
            // Construct components
        }
    }
}