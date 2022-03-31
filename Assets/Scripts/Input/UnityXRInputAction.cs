//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/Scripts/Input/UnityXRInput.inputactions
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

namespace TiltBrush
{
    public partial class @UnityXRInputAction : IInputActionCollection2, IDisposable
    {
        public InputActionAsset asset { get; }
        public @UnityXRInputAction()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""UnityXRInput"",
    ""maps"": [
        {
            ""name"": ""Brush"",
            ""id"": ""0be8ce9b-abc7-4f34-9bb4-a4aa0c9582e3"",
            ""actions"": [
                {
                    ""name"": ""TriggerAxis"",
                    ""type"": ""Value"",
                    ""id"": ""f8e2a4d8-2611-42f7-b863-6102c7f22312"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""TriggerButton"",
                    ""type"": ""Button"",
                    ""id"": ""6ed563ff-a250-4d2f-8b14-d1fe360a2470"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""TriggerTouch"",
                    ""type"": ""Button"",
                    ""id"": ""3544fe23-65ae-415c-ab58-721dfc92223b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""PadAxis"",
                    ""type"": ""Value"",
                    ""id"": ""3b226d8b-8fc0-4879-84d7-1c25db6e34b5"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""PadButton"",
                    ""type"": ""Button"",
                    ""id"": ""f65d1a3b-57ec-4f58-b5e9-476f9ddbcaa7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""PadTouch"",
                    ""type"": ""Button"",
                    ""id"": ""680cd601-aae8-4fb8-8d1d-51eb23c17941"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""GripAxis"",
                    ""type"": ""Value"",
                    ""id"": ""f040e383-e8c2-4f56-86f6-1ca48eb552e2"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""GripButton"",
                    ""type"": ""Button"",
                    ""id"": ""c27a451f-8196-4911-b54c-4ad40c55efe8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""PrimaryTouch"",
                    ""type"": ""Button"",
                    ""id"": ""9c7136cb-868c-49dc-ac53-cebeefd3de69"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""PrimaryButton"",
                    ""type"": ""Button"",
                    ""id"": ""7e497fba-b632-4c20-b4a7-e1aa457cd785"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""SecondaryTouch"",
                    ""type"": ""Button"",
                    ""id"": ""b63ff496-95b8-4da7-b3fe-3dc8a3151097"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""SecondaryButton"",
                    ""type"": ""Button"",
                    ""id"": ""0d49ad6c-bc4d-4488-9416-eca803bf1ced"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""7cb5d70d-9271-49e9-b13e-63071ecb271f"",
                    ""path"": ""<XRController>{RightHand}/trigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TriggerAxis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c70e565b-1c0f-4d60-b284-ccdec2fd856d"",
                    ""path"": ""<XRController>{RightHand}/triggerPressed"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TriggerButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fbd220cf-4b28-42eb-8112-d150759e76e3"",
                    ""path"": ""<XRController>{RightHand}/joystick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PadAxis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5ec0d137-cf65-41f1-8e28-1f86408ec2be"",
                    ""path"": ""<XRController>{RightHand}/touchpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PadAxis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7dbe38a7-20a5-4b2f-8ebb-4e444d0bf8a3"",
                    ""path"": ""<XRController>{RightHand}/trackpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PadAxis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""eb790e8d-afc9-4f2d-bdcf-51951724286f"",
                    ""path"": ""<XRController>{RightHand}/thumbstick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PadAxis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d172b06b-b295-4491-aabb-d67cdb987182"",
                    ""path"": ""<XRController>{RightHand}/grip"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""GripAxis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""34e41acb-65d2-4ab3-b058-f2c13687d92d"",
                    ""path"": ""<XRController>{RightHand}/gripPressed"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""GripButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c75c3e6d-ed3e-449d-8d19-f59102626f6a"",
                    ""path"": ""<XRController>{RightHand}/primaryTouched"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PrimaryTouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6bd04bcc-1fec-4fa2-9e42-aa42f0219a65"",
                    ""path"": ""<XRController>{RightHand}/secondaryTouched"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SecondaryTouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0acf7b79-2507-4ee7-95a4-7476c9d380d2"",
                    ""path"": ""<XRController>{RightHand}/triggerTouched"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TriggerTouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""59a64469-581c-4de0-8720-ce44496452c6"",
                    ""path"": ""<XRController>{RightHand}/secondaryButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SecondaryButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""898675f7-d41c-4a73-9b8e-0b847656c2f3"",
                    ""path"": ""<XRController>{RightHand}/primaryButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PrimaryButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d38db390-e23f-499c-b7e2-5424fae71eb5"",
                    ""path"": ""<XRController>{RightHand}/touchpadTouch"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PadTouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b2c72d2f-d8e2-4f8f-976b-76d343580c0d"",
                    ""path"": ""<XRController>{RightHand}/trackpadTouched"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PadTouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ac7c1ff5-f16e-4d6d-a7ca-b3fb7297e6c5"",
                    ""path"": ""<XRController>{RightHand}/thumbstickTouched"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PadTouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""25445e46-6ad3-4aef-b447-f33be3ea01ee"",
                    ""path"": ""<XRController>{RightHand}/thumbstickClicked"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PadButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bdc39c64-9dac-47a6-8a92-9ce8d493e197"",
                    ""path"": ""<XRController>{RightHand}/touchpadClick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PadButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""946e923e-f3b0-4b4c-86aa-b93d7e2f05ca"",
                    ""path"": ""<XRController>{RightHand}/joystickClicked"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PadButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e2134103-3299-4a1e-9bb8-d23c02b7a2a1"",
                    ""path"": ""<XRController>{RightHand}/trackpadClicked"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PadButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
            // Brush
            m_Brush = asset.FindActionMap("Brush", throwIfNotFound: true);
            m_Brush_TriggerAxis = m_Brush.FindAction("TriggerAxis", throwIfNotFound: true);
            m_Brush_TriggerButton = m_Brush.FindAction("TriggerButton", throwIfNotFound: true);
            m_Brush_TriggerTouch = m_Brush.FindAction("TriggerTouch", throwIfNotFound: true);
            m_Brush_PadAxis = m_Brush.FindAction("PadAxis", throwIfNotFound: true);
            m_Brush_PadButton = m_Brush.FindAction("PadButton", throwIfNotFound: true);
            m_Brush_PadTouch = m_Brush.FindAction("PadTouch", throwIfNotFound: true);
            m_Brush_GripAxis = m_Brush.FindAction("GripAxis", throwIfNotFound: true);
            m_Brush_GripButton = m_Brush.FindAction("GripButton", throwIfNotFound: true);
            m_Brush_PrimaryTouch = m_Brush.FindAction("PrimaryTouch", throwIfNotFound: true);
            m_Brush_PrimaryButton = m_Brush.FindAction("PrimaryButton", throwIfNotFound: true);
            m_Brush_SecondaryTouch = m_Brush.FindAction("SecondaryTouch", throwIfNotFound: true);
            m_Brush_SecondaryButton = m_Brush.FindAction("SecondaryButton", throwIfNotFound: true);
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

        // Brush
        private readonly InputActionMap m_Brush;
        private IBrushActions m_BrushActionsCallbackInterface;
        private readonly InputAction m_Brush_TriggerAxis;
        private readonly InputAction m_Brush_TriggerButton;
        private readonly InputAction m_Brush_TriggerTouch;
        private readonly InputAction m_Brush_PadAxis;
        private readonly InputAction m_Brush_PadButton;
        private readonly InputAction m_Brush_PadTouch;
        private readonly InputAction m_Brush_GripAxis;
        private readonly InputAction m_Brush_GripButton;
        private readonly InputAction m_Brush_PrimaryTouch;
        private readonly InputAction m_Brush_PrimaryButton;
        private readonly InputAction m_Brush_SecondaryTouch;
        private readonly InputAction m_Brush_SecondaryButton;
        public struct BrushActions
        {
            private @UnityXRInputAction m_Wrapper;
            public BrushActions(@UnityXRInputAction wrapper) { m_Wrapper = wrapper; }
            public InputAction @TriggerAxis => m_Wrapper.m_Brush_TriggerAxis;
            public InputAction @TriggerButton => m_Wrapper.m_Brush_TriggerButton;
            public InputAction @TriggerTouch => m_Wrapper.m_Brush_TriggerTouch;
            public InputAction @PadAxis => m_Wrapper.m_Brush_PadAxis;
            public InputAction @PadButton => m_Wrapper.m_Brush_PadButton;
            public InputAction @PadTouch => m_Wrapper.m_Brush_PadTouch;
            public InputAction @GripAxis => m_Wrapper.m_Brush_GripAxis;
            public InputAction @GripButton => m_Wrapper.m_Brush_GripButton;
            public InputAction @PrimaryTouch => m_Wrapper.m_Brush_PrimaryTouch;
            public InputAction @PrimaryButton => m_Wrapper.m_Brush_PrimaryButton;
            public InputAction @SecondaryTouch => m_Wrapper.m_Brush_SecondaryTouch;
            public InputAction @SecondaryButton => m_Wrapper.m_Brush_SecondaryButton;
            public InputActionMap Get() { return m_Wrapper.m_Brush; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(BrushActions set) { return set.Get(); }
            public void SetCallbacks(IBrushActions instance)
            {
                if (m_Wrapper.m_BrushActionsCallbackInterface != null)
                {
                    @TriggerAxis.started -= m_Wrapper.m_BrushActionsCallbackInterface.OnTriggerAxis;
                    @TriggerAxis.performed -= m_Wrapper.m_BrushActionsCallbackInterface.OnTriggerAxis;
                    @TriggerAxis.canceled -= m_Wrapper.m_BrushActionsCallbackInterface.OnTriggerAxis;
                    @TriggerButton.started -= m_Wrapper.m_BrushActionsCallbackInterface.OnTriggerButton;
                    @TriggerButton.performed -= m_Wrapper.m_BrushActionsCallbackInterface.OnTriggerButton;
                    @TriggerButton.canceled -= m_Wrapper.m_BrushActionsCallbackInterface.OnTriggerButton;
                    @TriggerTouch.started -= m_Wrapper.m_BrushActionsCallbackInterface.OnTriggerTouch;
                    @TriggerTouch.performed -= m_Wrapper.m_BrushActionsCallbackInterface.OnTriggerTouch;
                    @TriggerTouch.canceled -= m_Wrapper.m_BrushActionsCallbackInterface.OnTriggerTouch;
                    @PadAxis.started -= m_Wrapper.m_BrushActionsCallbackInterface.OnPadAxis;
                    @PadAxis.performed -= m_Wrapper.m_BrushActionsCallbackInterface.OnPadAxis;
                    @PadAxis.canceled -= m_Wrapper.m_BrushActionsCallbackInterface.OnPadAxis;
                    @PadButton.started -= m_Wrapper.m_BrushActionsCallbackInterface.OnPadButton;
                    @PadButton.performed -= m_Wrapper.m_BrushActionsCallbackInterface.OnPadButton;
                    @PadButton.canceled -= m_Wrapper.m_BrushActionsCallbackInterface.OnPadButton;
                    @PadTouch.started -= m_Wrapper.m_BrushActionsCallbackInterface.OnPadTouch;
                    @PadTouch.performed -= m_Wrapper.m_BrushActionsCallbackInterface.OnPadTouch;
                    @PadTouch.canceled -= m_Wrapper.m_BrushActionsCallbackInterface.OnPadTouch;
                    @GripAxis.started -= m_Wrapper.m_BrushActionsCallbackInterface.OnGripAxis;
                    @GripAxis.performed -= m_Wrapper.m_BrushActionsCallbackInterface.OnGripAxis;
                    @GripAxis.canceled -= m_Wrapper.m_BrushActionsCallbackInterface.OnGripAxis;
                    @GripButton.started -= m_Wrapper.m_BrushActionsCallbackInterface.OnGripButton;
                    @GripButton.performed -= m_Wrapper.m_BrushActionsCallbackInterface.OnGripButton;
                    @GripButton.canceled -= m_Wrapper.m_BrushActionsCallbackInterface.OnGripButton;
                    @PrimaryTouch.started -= m_Wrapper.m_BrushActionsCallbackInterface.OnPrimaryTouch;
                    @PrimaryTouch.performed -= m_Wrapper.m_BrushActionsCallbackInterface.OnPrimaryTouch;
                    @PrimaryTouch.canceled -= m_Wrapper.m_BrushActionsCallbackInterface.OnPrimaryTouch;
                    @PrimaryButton.started -= m_Wrapper.m_BrushActionsCallbackInterface.OnPrimaryButton;
                    @PrimaryButton.performed -= m_Wrapper.m_BrushActionsCallbackInterface.OnPrimaryButton;
                    @PrimaryButton.canceled -= m_Wrapper.m_BrushActionsCallbackInterface.OnPrimaryButton;
                    @SecondaryTouch.started -= m_Wrapper.m_BrushActionsCallbackInterface.OnSecondaryTouch;
                    @SecondaryTouch.performed -= m_Wrapper.m_BrushActionsCallbackInterface.OnSecondaryTouch;
                    @SecondaryTouch.canceled -= m_Wrapper.m_BrushActionsCallbackInterface.OnSecondaryTouch;
                    @SecondaryButton.started -= m_Wrapper.m_BrushActionsCallbackInterface.OnSecondaryButton;
                    @SecondaryButton.performed -= m_Wrapper.m_BrushActionsCallbackInterface.OnSecondaryButton;
                    @SecondaryButton.canceled -= m_Wrapper.m_BrushActionsCallbackInterface.OnSecondaryButton;
                }
                m_Wrapper.m_BrushActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @TriggerAxis.started += instance.OnTriggerAxis;
                    @TriggerAxis.performed += instance.OnTriggerAxis;
                    @TriggerAxis.canceled += instance.OnTriggerAxis;
                    @TriggerButton.started += instance.OnTriggerButton;
                    @TriggerButton.performed += instance.OnTriggerButton;
                    @TriggerButton.canceled += instance.OnTriggerButton;
                    @TriggerTouch.started += instance.OnTriggerTouch;
                    @TriggerTouch.performed += instance.OnTriggerTouch;
                    @TriggerTouch.canceled += instance.OnTriggerTouch;
                    @PadAxis.started += instance.OnPadAxis;
                    @PadAxis.performed += instance.OnPadAxis;
                    @PadAxis.canceled += instance.OnPadAxis;
                    @PadButton.started += instance.OnPadButton;
                    @PadButton.performed += instance.OnPadButton;
                    @PadButton.canceled += instance.OnPadButton;
                    @PadTouch.started += instance.OnPadTouch;
                    @PadTouch.performed += instance.OnPadTouch;
                    @PadTouch.canceled += instance.OnPadTouch;
                    @GripAxis.started += instance.OnGripAxis;
                    @GripAxis.performed += instance.OnGripAxis;
                    @GripAxis.canceled += instance.OnGripAxis;
                    @GripButton.started += instance.OnGripButton;
                    @GripButton.performed += instance.OnGripButton;
                    @GripButton.canceled += instance.OnGripButton;
                    @PrimaryTouch.started += instance.OnPrimaryTouch;
                    @PrimaryTouch.performed += instance.OnPrimaryTouch;
                    @PrimaryTouch.canceled += instance.OnPrimaryTouch;
                    @PrimaryButton.started += instance.OnPrimaryButton;
                    @PrimaryButton.performed += instance.OnPrimaryButton;
                    @PrimaryButton.canceled += instance.OnPrimaryButton;
                    @SecondaryTouch.started += instance.OnSecondaryTouch;
                    @SecondaryTouch.performed += instance.OnSecondaryTouch;
                    @SecondaryTouch.canceled += instance.OnSecondaryTouch;
                    @SecondaryButton.started += instance.OnSecondaryButton;
                    @SecondaryButton.performed += instance.OnSecondaryButton;
                    @SecondaryButton.canceled += instance.OnSecondaryButton;
                }
            }
        }
        public BrushActions @Brush => new BrushActions(this);
        public interface IBrushActions
        {
            void OnTriggerAxis(InputAction.CallbackContext context);
            void OnTriggerButton(InputAction.CallbackContext context);
            void OnTriggerTouch(InputAction.CallbackContext context);
            void OnPadAxis(InputAction.CallbackContext context);
            void OnPadButton(InputAction.CallbackContext context);
            void OnPadTouch(InputAction.CallbackContext context);
            void OnGripAxis(InputAction.CallbackContext context);
            void OnGripButton(InputAction.CallbackContext context);
            void OnPrimaryTouch(InputAction.CallbackContext context);
            void OnPrimaryButton(InputAction.CallbackContext context);
            void OnSecondaryTouch(InputAction.CallbackContext context);
            void OnSecondaryButton(InputAction.CallbackContext context);
        }
    }
}