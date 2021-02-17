using UnityEngine.SceneManagement;
using UnityEngine;


namespace RollBall
{
    public sealed class Restart
    {
        public void RestartGame()
        {
            SceneManager.LoadScene(sceneBuildIndex: 0);
            Time.timeScale = 1.0f;
        }
        
    }

}
