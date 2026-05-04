using SliderGame.Runtime;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScoreManager_Runtime
{
    public class ScoreManager : MonoBehaviour
    {
        #region Publics

        public Slider slider;
        public ulong score;
        public TMP_Text txt_score;
        public GameOverManager gameOverManager;

        #endregion

        #region Privates

        private bool _gameOverTriggered;

        #endregion

        #region Unity API

        private void Update()
        {
            Score();
        }

        #endregion

        #region Methods

        private void Score()
        {
            if (_gameOverTriggered || slider == null)
            {
                return;
            }

            if (slider.value >= 0.6f && slider.value <= 0.8f)
            {
                score += 1;
            }
            else if (slider.value >= 1f)
            {
                _gameOverTriggered = true;

                if (gameOverManager != null)
                {
                    gameOverManager.ShowGameOver(score);
                }
                else
                {
                    Time.timeScale = 0f;
                }
            }

            if (txt_score != null)
            {
                txt_score.text = score.ToString();
            }
        }

        #endregion
    }
}
