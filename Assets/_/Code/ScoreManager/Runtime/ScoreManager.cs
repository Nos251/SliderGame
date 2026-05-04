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

        #endregion

        #region Unity API

        private void Score()
        {
            if (slider.value >= 0.6 && slider.value <= 0.8)
            {
                score += 1;
            }

            else if (slider.value == 1)
            {
                Time.timeScale = 0f;
            }

            // On va chercher le Text Input du GameObject TextMesh.Pro dans Unity
            txt_score.text = score.ToString();
        }

        private void Update()
        {
            Score();
        }

        #endregion
    }
}