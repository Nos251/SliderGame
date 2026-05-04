using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class InputReactor : MonoBehaviour
{
    #region Publics

    public InputActionReference m_inputActionReference;
    public UnityEvent OnButtonPressed;

    #endregion

    #region Unity UI

    private void OnEnable()
    {
        m_inputActionReference.action.Enable();
        m_inputActionReference.action.performed += ButtonReaction;
    }

    private void OnDisable()
    {
        m_inputActionReference.action.Disable();
        m_inputActionReference.action.performed += ButtonReaction;
    }

    #endregion

    #region Main UI

    private void ButtonReaction(InputAction.CallbackContext context)
    {
        OnButtonPressed.Invoke();
    }



    #endregion
}