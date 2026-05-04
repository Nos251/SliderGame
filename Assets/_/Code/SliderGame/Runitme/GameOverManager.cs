using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace SliderGame.Runtime
{
    public class GameOverManager : MonoBehaviour
    {
        #region Publics

        [SerializeField] private GameObject gameOverPanel;
        [SerializeField] private TMP_Text finalScoreText;

        #endregion

        #region Privates

        private bool _isGameOver;

        #endregion

        #region Public API

        public bool IsGameOver => _isGameOver;

        public void ShowGameOver(ulong score)
        {
            if (_isGameOver)
            {
                return;
            }

            _isGameOver = true;
            Time.timeScale = 0f;

            if (finalScoreText != null)
            {
                finalScoreText.text = $"Score final : {score}";
            }

            if (gameOverPanel != null)
            {
                gameOverPanel.SetActive(true);
            }
        }

        public void RestartGame()
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        public void QuitGame()
        {
            Time.timeScale = 1f;
            Application.Quit();
        }

        #endregion

        #region Unity API

        private void Awake()
        {
            Time.timeScale = 1f;

            if (gameOverPanel != null)
            {
                gameOverPanel.SetActive(false);
            }
        }

        #endregion
    }
}
