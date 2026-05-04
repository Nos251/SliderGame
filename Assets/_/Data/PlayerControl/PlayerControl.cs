using UnityEngine;
using UnityEngine.UI;

public class PlayerControl : MonoBehaviour
{
    #region Publics

    public void JumpBack()
    {
        GetComponent<Slider>().value -= 0.08f;
    }

    #endregion
}