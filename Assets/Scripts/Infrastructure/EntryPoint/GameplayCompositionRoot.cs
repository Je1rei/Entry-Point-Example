using UnityEngine;
using Zenject;

namespace Infrastructure.EntryPoint
{
    public class GameplayCompositionRoot : MonoBehaviour, ICompose
    {
        [SerializeField] private SceneContext _sceneContext;
        
        private DiContainer _diContainer;
        
        [Inject]
        public void Compose(DiContainer container)
        {
            _diContainer = _sceneContext.Container;
            
            // Resolve if needed
            // Construct/Compose dependencies
            
            ConstructComponents();
        }
        
        private void ConstructComponents()
        {
            Debug.Log("Components on Gameplay scene is constructed");
            
            // Construct components
        }
    }
}