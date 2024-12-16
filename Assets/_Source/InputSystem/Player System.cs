//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.11.2
//     from Assets/_Source/InputSystem/Player System.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @PlayerSystem: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerSystem()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Player System"",
    ""maps"": [
        {
            ""name"": ""Player Controller"",
            ""id"": ""09d953c5-5d46-4b8a-8f08-adfc83abad14"",
            ""actions"": [
                {
                    ""name"": ""Player"",
                    ""type"": ""Value"",
                    ""id"": ""06b6d997-20d2-41c3-8474-e8ae42b6cc2a"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Interaction"",
                    ""type"": ""Button"",
                    ""id"": ""4432ac0f-c507-4661-a049-a0de7138061f"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""adba7236-d066-4386-af96-2aa0fae37c79"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Flash"",
                    ""type"": ""Button"",
                    ""id"": ""c9992921-2d78-419c-9238-08b661c9d98e"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Move"",
                    ""id"": ""d1111eba-c21e-4a56-a96c-dbb9442d7d5c"",
                    ""path"": ""3DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Player"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""43e01a37-a5e7-44d1-ab35-8bc929a11371"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Player"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""634aedbd-b57c-471f-a8fe-ece0a62ac38f"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Player"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""f448c213-d2ba-4589-9937-3cebcfb16d26"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Player"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""e2df654c-2503-4cc6-a594-3b46a98be6a9"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Player"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""f8628e64-81ce-4cb7-bc18-cd6269be1bc0"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interaction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7b8dd6af-34dd-43a1-944c-ed6cdf940b30"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cd248f32-4832-4e6d-bdde-fe7cd01f1320"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Flash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player Controller
        m_PlayerController = asset.FindActionMap("Player Controller", throwIfNotFound: true);
        m_PlayerController_Player = m_PlayerController.FindAction("Player", throwIfNotFound: true);
        m_PlayerController_Interaction = m_PlayerController.FindAction("Interaction", throwIfNotFound: true);
        m_PlayerController_Attack = m_PlayerController.FindAction("Attack", throwIfNotFound: true);
        m_PlayerController_Flash = m_PlayerController.FindAction("Flash", throwIfNotFound: true);
    }

    ~@PlayerSystem()
    {
        UnityEngine.Debug.Assert(!m_PlayerController.enabled, "This will cause a leak and performance issues, PlayerSystem.PlayerController.Disable() has not been called.");
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Player Controller
    private readonly InputActionMap m_PlayerController;
    private List<IPlayerControllerActions> m_PlayerControllerActionsCallbackInterfaces = new List<IPlayerControllerActions>();
    private readonly InputAction m_PlayerController_Player;
    private readonly InputAction m_PlayerController_Interaction;
    private readonly InputAction m_PlayerController_Attack;
    private readonly InputAction m_PlayerController_Flash;
    public struct PlayerControllerActions
    {
        private @PlayerSystem m_Wrapper;
        public PlayerControllerActions(@PlayerSystem wrapper) { m_Wrapper = wrapper; }
        public InputAction @Player => m_Wrapper.m_PlayerController_Player;
        public InputAction @Interaction => m_Wrapper.m_PlayerController_Interaction;
        public InputAction @Attack => m_Wrapper.m_PlayerController_Attack;
        public InputAction @Flash => m_Wrapper.m_PlayerController_Flash;
        public InputActionMap Get() { return m_Wrapper.m_PlayerController; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerControllerActions set) { return set.Get(); }
        public void AddCallbacks(IPlayerControllerActions instance)
        {
            if (instance == null || m_Wrapper.m_PlayerControllerActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PlayerControllerActionsCallbackInterfaces.Add(instance);
            @Player.started += instance.OnPlayer;
            @Player.performed += instance.OnPlayer;
            @Player.canceled += instance.OnPlayer;
            @Interaction.started += instance.OnInteraction;
            @Interaction.performed += instance.OnInteraction;
            @Interaction.canceled += instance.OnInteraction;
            @Attack.started += instance.OnAttack;
            @Attack.performed += instance.OnAttack;
            @Attack.canceled += instance.OnAttack;
            @Flash.started += instance.OnFlash;
            @Flash.performed += instance.OnFlash;
            @Flash.canceled += instance.OnFlash;
        }

        private void UnregisterCallbacks(IPlayerControllerActions instance)
        {
            @Player.started -= instance.OnPlayer;
            @Player.performed -= instance.OnPlayer;
            @Player.canceled -= instance.OnPlayer;
            @Interaction.started -= instance.OnInteraction;
            @Interaction.performed -= instance.OnInteraction;
            @Interaction.canceled -= instance.OnInteraction;
            @Attack.started -= instance.OnAttack;
            @Attack.performed -= instance.OnAttack;
            @Attack.canceled -= instance.OnAttack;
            @Flash.started -= instance.OnFlash;
            @Flash.performed -= instance.OnFlash;
            @Flash.canceled -= instance.OnFlash;
        }

        public void RemoveCallbacks(IPlayerControllerActions instance)
        {
            if (m_Wrapper.m_PlayerControllerActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayerControllerActions instance)
        {
            foreach (var item in m_Wrapper.m_PlayerControllerActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PlayerControllerActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PlayerControllerActions @PlayerController => new PlayerControllerActions(this);
    public interface IPlayerControllerActions
    {
        void OnPlayer(InputAction.CallbackContext context);
        void OnInteraction(InputAction.CallbackContext context);
        void OnAttack(InputAction.CallbackContext context);
        void OnFlash(InputAction.CallbackContext context);
    }
}
