using UnityEngine;
using UnityEngine.UI;


namespace SliderGame.Runtime
{
    public class SliderGame : MonoBehaviour
    {
        #region Publics

        // Référence au composant Slider de l'UI (à glisser-déposer dans l'inspecteur Unity)
        public Slider slider;

        // Vitesse de progression du curseur (0.5 unité par seconde par défaut)
        public float speed = 0.5f;

        #endregion

        #region Unity API

        private void Update()
        {
            if (slider != null)
            {
                // Augmente la valeur actuelle du slider : (Vitesse) multipliée par (Temps écoulé depuis la dernière image)
                // Time.deltaTime permet de rendre le mouvement fluide et indépendant du nombre de FPS
                // 
                slider.value += speed * Time.deltaTime;
            }
        }

        #endregion
    }
}
