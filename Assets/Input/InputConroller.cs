// GENERATED AUTOMATICALLY FROM 'Assets/Input/InputConroller.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputConroller : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputConroller()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputConroller"",
    ""maps"": [
        {
            ""name"": ""Main"",
            ""id"": ""f97f009a-29f6-444e-9702-bf5f5b47318b"",
            ""actions"": [
                {
                    ""name"": ""ClickOverBuildMenu"",
                    ""type"": ""Button"",
                    ""id"": ""59a36127-3520-45f6-97c4-7ac4ddb2b57d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""8a8b1f3d-e3e5-4fe8-bb0b-bf20bcac05ca"",
                    ""path"": ""<Mouse>/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ClickOverBuildMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Main
        m_Main = asset.FindActionMap("Main", throwIfNotFound: true);
        m_Main_ClickOverBuildMenu = m_Main.FindAction("ClickOverBuildMenu", throwIfNotFound: true);
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

    // Main
    private readonly InputActionMap m_Main;
    private IMainActions m_MainActionsCallbackInterface;
    private readonly InputAction m_Main_ClickOverBuildMenu;
    public struct MainActions
    {
        private @InputConroller m_Wrapper;
        public MainActions(@InputConroller wrapper) { m_Wrapper = wrapper; }
        public InputAction @ClickOverBuildMenu => m_Wrapper.m_Main_ClickOverBuildMenu;
        public InputActionMap Get() { return m_Wrapper.m_Main; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MainActions set) { return set.Get(); }
        public void SetCallbacks(IMainActions instance)
        {
            if (m_Wrapper.m_MainActionsCallbackInterface != null)
            {
                @ClickOverBuildMenu.started -= m_Wrapper.m_MainActionsCallbackInterface.OnClickOverBuildMenu;
                @ClickOverBuildMenu.performed -= m_Wrapper.m_MainActionsCallbackInterface.OnClickOverBuildMenu;
                @ClickOverBuildMenu.canceled -= m_Wrapper.m_MainActionsCallbackInterface.OnClickOverBuildMenu;
            }
            m_Wrapper.m_MainActionsCallbackInterface = instance;
            if (instance != null)
            {
                @ClickOverBuildMenu.started += instance.OnClickOverBuildMenu;
                @ClickOverBuildMenu.performed += instance.OnClickOverBuildMenu;
                @ClickOverBuildMenu.canceled += instance.OnClickOverBuildMenu;
            }
        }
    }
    public MainActions @Main => new MainActions(this);
    public interface IMainActions
    {
        void OnClickOverBuildMenu(InputAction.CallbackContext context);
    }
}
