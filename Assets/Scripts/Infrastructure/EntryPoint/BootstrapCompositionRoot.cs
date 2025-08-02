using Infrastructure.Services;
using UnityEngine;
using Zenject;

namespace Infrastructure.EntryPoint
{
    public class BootstrapCompositionRoot : MonoBehaviour, ICompose
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
            // Compose dependencies

            ConstructComponents();
            LoadScene();
        }

        private void ConstructComponents()
        {
            Debug.Log("Components  on Bootstrap scene is constructed");
            
            // Construct components
        }
        
        private void LoadScene()
        {
            _sceneLoaderService.LoadMainMenuScene();
        }
    }
}