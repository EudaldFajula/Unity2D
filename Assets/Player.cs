using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour, InputSystem_Actions.IPlayerActions
{
    //Para añadir script de movimiento
    [SerializeField] private MoveBehaviour _mb;
    //Para que funcione los  inputActions
    private InputSystem_Actions inputActions;
    public void OnAttack(InputAction.CallbackContext context)
    {
        throw new System.NotImplementedException();
    }

    public void OnCrouch(InputAction.CallbackContext context)
    {
        throw new System.NotImplementedException();
    }

    public void OnInteract(InputAction.CallbackContext context)
    {
        throw new System.NotImplementedException();
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        _mb.JumpCharacter();
    }

    public void OnLook(InputAction.CallbackContext context)
    {
        throw new System.NotImplementedException();
    }
    public void OnNext(InputAction.CallbackContext context)
        {
            throw new System.NotImplementedException();
        }

    public void OnPrevious(InputAction.CallbackContext context)
    {
        throw new System.NotImplementedException();
    }

    public void OnSprint(InputAction.CallbackContext context)
    {
        throw new System.NotImplementedException();
    }
    public void OnMove(InputAction.CallbackContext context)
    {
        //Le pasamos el Vector dos para que tenga la 'x' y la 'y' del context
        _mb.MoveCharacter(context.ReadValue<Vector2>());
    }
    private void Awake()
    {
        //Para crear los inputActions
        inputActions = new InputSystem_Actions();
        inputActions.Player.SetCallbacks(this);
        //Crear la variable _mb con el script de MoveBehaviour
        _mb = GetComponent<MoveBehaviour>();
    }
    //Para que funcione el inputActions
    private void OnEnable()
    {
        inputActions.Enable();
    }
    private void OnDisable()
    {
        inputActions.Disable();
    }
}
