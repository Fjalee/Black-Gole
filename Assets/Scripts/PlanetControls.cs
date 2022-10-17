//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.3
//     from Assets/Scripts/PlanetControls.inputactions
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

public partial class @PlanetControls : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlanetControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlanetControls"",
    ""maps"": [
        {
            ""name"": ""Basic"",
            ""id"": ""037dead8-0031-4d35-8e74-e8f39a1a79ec"",
            ""actions"": [
                {
                    ""name"": ""TouchX"",
                    ""type"": ""PassThrough"",
                    ""id"": ""684016e1-5607-4659-9cbe-baa64a1d04b6"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""TouchY"",
                    ""type"": ""PassThrough"",
                    ""id"": ""d4b08f47-43a6-4af0-a363-783c5bf916b3"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""39764c40-062c-4594-bf0c-aea4c878961f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""fe1560d4-2f3a-4fb7-876f-889629046e05"",
                    ""path"": ""<Touchscreen>/delta/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TouchX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""02a6aa89-b28e-49be-a656-db01a1deeda7"",
                    ""path"": ""<Mouse>/delta/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TouchX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""febd1ed1-2b17-46b9-9353-c0675e342d75"",
                    ""path"": ""<Touchscreen>/delta/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TouchY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""939e892c-b55d-4c81-b0a2-e00be60a3f09"",
                    ""path"": ""<Mouse>/delta/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TouchY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b41a04f6-1e2a-4356-bbdf-ada8289c9ce8"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""82740aa7-5351-4620-85fe-bf3db5009970"",
                    ""path"": ""<Touchscreen>/primaryTouch/tap"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Basic
        m_Basic = asset.FindActionMap("Basic", throwIfNotFound: true);
        m_Basic_TouchX = m_Basic.FindAction("TouchX", throwIfNotFound: true);
        m_Basic_TouchY = m_Basic.FindAction("TouchY", throwIfNotFound: true);
        m_Basic_Shoot = m_Basic.FindAction("Shoot", throwIfNotFound: true);
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

    // Basic
    private readonly InputActionMap m_Basic;
    private IBasicActions m_BasicActionsCallbackInterface;
    private readonly InputAction m_Basic_TouchX;
    private readonly InputAction m_Basic_TouchY;
    private readonly InputAction m_Basic_Shoot;
    public struct BasicActions
    {
        private @PlanetControls m_Wrapper;
        public BasicActions(@PlanetControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @TouchX => m_Wrapper.m_Basic_TouchX;
        public InputAction @TouchY => m_Wrapper.m_Basic_TouchY;
        public InputAction @Shoot => m_Wrapper.m_Basic_Shoot;
        public InputActionMap Get() { return m_Wrapper.m_Basic; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(BasicActions set) { return set.Get(); }
        public void SetCallbacks(IBasicActions instance)
        {
            if (m_Wrapper.m_BasicActionsCallbackInterface != null)
            {
                @TouchX.started -= m_Wrapper.m_BasicActionsCallbackInterface.OnTouchX;
                @TouchX.performed -= m_Wrapper.m_BasicActionsCallbackInterface.OnTouchX;
                @TouchX.canceled -= m_Wrapper.m_BasicActionsCallbackInterface.OnTouchX;
                @TouchY.started -= m_Wrapper.m_BasicActionsCallbackInterface.OnTouchY;
                @TouchY.performed -= m_Wrapper.m_BasicActionsCallbackInterface.OnTouchY;
                @TouchY.canceled -= m_Wrapper.m_BasicActionsCallbackInterface.OnTouchY;
                @Shoot.started -= m_Wrapper.m_BasicActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_BasicActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_BasicActionsCallbackInterface.OnShoot;
            }
            m_Wrapper.m_BasicActionsCallbackInterface = instance;
            if (instance != null)
            {
                @TouchX.started += instance.OnTouchX;
                @TouchX.performed += instance.OnTouchX;
                @TouchX.canceled += instance.OnTouchX;
                @TouchY.started += instance.OnTouchY;
                @TouchY.performed += instance.OnTouchY;
                @TouchY.canceled += instance.OnTouchY;
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
            }
        }
    }
    public BasicActions @Basic => new BasicActions(this);
    public interface IBasicActions
    {
        void OnTouchX(InputAction.CallbackContext context);
        void OnTouchY(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
    }
}
