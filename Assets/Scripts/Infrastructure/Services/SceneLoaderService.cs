using UnityEngine.SceneManagement;

namespace Infrastructure.Services
{
    public class SceneLoaderService : IService
    {
        private const string MAIN_MENU_SCENE_NAME = "MainMenuScene"; // Здесь лучше прокидывать по индексу или с помощью плагинов каких
        private const string GAMEPLAYE_SCENE_NAME = "GameplayScene"; // Здесь лучше прокидывать по индексу или с помощью плагинов каких

        public void LoadMainMenuScene()
        {
            SceneManager.LoadScene(MAIN_MENU_SCENE_NAME);
        }        
        
        public void LoadGameplayScene()
        {
            SceneManager.LoadScene(GAMEPLAYE_SCENE_NAME);
        }
    }
}