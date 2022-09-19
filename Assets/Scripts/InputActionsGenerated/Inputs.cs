//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/Inputs.inputactions
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

public partial class @Inputs : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Inputs()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Inputs"",
    ""maps"": [
        {
            ""name"": ""Ball"",
            ""id"": ""338d999a-ac9b-4ce9-9829-1a110a3c0b8c"",
            ""actions"": [
                {
                    ""name"": ""TouchPosition"",
                    ""type"": ""Value"",
                    ""id"": ""d7fa047d-f3a1-4881-89da-f6ac8a444af8"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""TouchRelease"",
                    ""type"": ""Button"",
                    ""id"": ""29721789-5a36-4ee2-b35c-cf66cb1d6ea6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=1)"",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""19d488c1-f95b-4793-a2dc-74c928e639ce"",
                    ""path"": ""<Touchscreen>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TouchPosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""39bfa00b-31de-4f39-8166-9dd5845bc14f"",
                    ""path"": ""<Touchscreen>/primaryTouch/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TouchRelease"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Ball
        m_Ball = asset.FindActionMap("Ball", throwIfNotFound: true);
        m_Ball_TouchPosition = m_Ball.FindAction("TouchPosition", throwIfNotFound: true);
        m_Ball_TouchRelease = m_Ball.FindAction("TouchRelease", throwIfNotFound: true);
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

    // Ball
    private readonly InputActionMap m_Ball;
    private IBallActions m_BallActionsCallbackInterface;
    private readonly InputAction m_Ball_TouchPosition;
    private readonly InputAction m_Ball_TouchRelease;
    public struct BallActions
    {
        private @Inputs m_Wrapper;
        public BallActions(@Inputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @TouchPosition => m_Wrapper.m_Ball_TouchPosition;
        public InputAction @TouchRelease => m_Wrapper.m_Ball_TouchRelease;
        public InputActionMap Get() { return m_Wrapper.m_Ball; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(BallActions set) { return set.Get(); }
        public void SetCallbacks(IBallActions instance)
        {
            if (m_Wrapper.m_BallActionsCallbackInterface != null)
            {
                @TouchPosition.started -= m_Wrapper.m_BallActionsCallbackInterface.OnTouchPosition;
                @TouchPosition.performed -= m_Wrapper.m_BallActionsCallbackInterface.OnTouchPosition;
                @TouchPosition.canceled -= m_Wrapper.m_BallActionsCallbackInterface.OnTouchPosition;
                @TouchRelease.started -= m_Wrapper.m_BallActionsCallbackInterface.OnTouchRelease;
                @TouchRelease.performed -= m_Wrapper.m_BallActionsCallbackInterface.OnTouchRelease;
                @TouchRelease.canceled -= m_Wrapper.m_BallActionsCallbackInterface.OnTouchRelease;
            }
            m_Wrapper.m_BallActionsCallbackInterface = instance;
            if (instance != null)
            {
                @TouchPosition.started += instance.OnTouchPosition;
                @TouchPosition.performed += instance.OnTouchPosition;
                @TouchPosition.canceled += instance.OnTouchPosition;
                @TouchRelease.started += instance.OnTouchRelease;
                @TouchRelease.performed += instance.OnTouchRelease;
                @TouchRelease.canceled += instance.OnTouchRelease;
            }
        }
    }
    public BallActions @Ball => new BallActions(this);
    public interface IBallActions
    {
        void OnTouchPosition(InputAction.CallbackContext context);
        void OnTouchRelease(InputAction.CallbackContext context);
    }
}
