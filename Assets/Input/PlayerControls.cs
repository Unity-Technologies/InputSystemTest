// GENERATED AUTOMATICALLY FROM 'Assets/Input/PlayerControls.inputactions'

using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class PlayerControls : IInputActionCollection
{
    private InputActionAsset asset;
    public PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""Walking"",
            ""id"": ""7c607413-5237-4e3a-b256-1a54acc525b2"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Button"",
                    ""id"": ""d0bcf8ec-7237-45d6-ab15-75c5a4f174f1"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""ea03ddfd-0c6c-4776-bed1-052e17762957"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""EnterVehicle"",
                    ""type"": ""Button"",
                    ""id"": ""2424b96d-06a3-4ae9-b18c-4dc014c50e83"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WADS"",
                    ""id"": ""93702934-38c6-49fe-912f-1314b8cc1c05"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""c4669449-b987-41ae-83b4-3e480b9d1e32"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""d96f75a4-17cd-4f36-9332-f715850289d4"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""9ff7802c-206a-4ac0-9b31-394981dab039"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""0065634b-7c0e-4c88-bd04-b035897d0033"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrow Keys"",
                    ""id"": ""7dd46a62-9d5d-485b-8e40-770eb178cefd"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""41f10566-0e3a-4b2e-8c6d-c70d600ba5b5"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""170a7951-db90-481e-b3cb-cb2a4ef60573"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""659a8efa-53f1-492c-88d3-8ca37e16c024"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""b6a2850b-0cd7-41f5-ac70-f122390574bb"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""a2cee5e7-7c95-4391-bbc9-77d52d8c78b0"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7f07e1df-7baf-480a-b4c4-1657f1639a8e"",
                    ""path"": ""*/{Primary2DAxis}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4f6a359d-566b-47ad-b955-61c3744b69e1"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a33b808d-394d-44e2-8667-4ad5dba7e566"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""16afa32b-cbae-47f3-a11a-826dada558ad"",
                    ""path"": ""*/{TriggerButton}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""82dcbf27-ba6b-4984-a2bf-9dd36c6555e9"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""EnterVehicle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4128bb30-08bd-4b76-afa7-91477591bb3b"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""EnterVehicle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""072dd282-0dae-48e6-963f-a5403b0c3d68"",
                    ""path"": ""*/{Primary2DAxisClick}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""EnterVehicle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Tank"",
            ""id"": ""32bf7300-a961-49e4-b7c0-c3b4e595ec63"",
            ""actions"": [
                {
                    ""name"": ""Steering"",
                    ""type"": ""Button"",
                    ""id"": ""af0ef182-d976-4e7b-8396-4329129d9341"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Gas"",
                    ""type"": ""Button"",
                    ""id"": ""47531bc8-fc62-42da-a124-5650afcf65f1"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Fire"",
                    ""type"": ""Button"",
                    ""id"": ""cea85822-b0f3-4b82-933e-789eeefa2691"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ExitVehicle"",
                    ""type"": ""Button"",
                    ""id"": ""ffa37c50-7555-459c-a18a-1cdc92db8f6d"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""ce6d783b-7fd2-4305-905f-14ecdfb0501a"",
                    ""path"": ""<Gamepad>/leftStick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steering"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Keyboard AD"",
                    ""id"": ""6f1f9267-872e-4976-946d-70236aeccaf8"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steering"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""35fd346b-3976-4bca-968e-2564ad805c25"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steering"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""18e2ffb9-f618-4f89-a169-169170fa3b45"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steering"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Keyboard Arrows"",
                    ""id"": ""5038a150-2b9a-4763-829e-597e614ac8ec"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steering"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""ebdfb58d-3222-4918-acf5-72326ffe9040"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steering"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""c1ede467-87b5-4fb5-a368-2faaf4d9e047"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steering"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""0543904b-a304-478c-8e1f-649c6684283b"",
                    ""path"": ""*/{Primary2DAxis}/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steering"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""CombinedTrigger"",
                    ""id"": ""15211195-9d42-4a35-b025-45834c858cee"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Gas"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""57da9870-0cef-44ec-9310-2bdd4d48684b"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Gas"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""08ca9cc6-3dd2-4f5b-8c92-5aec52a6e6e4"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Gas"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Keyboard WS"",
                    ""id"": ""0119ffa3-a4c3-4350-a252-92041d88a864"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Gas"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""b2d2cdfa-890c-46c7-b647-b99a536296c7"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Gas"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""8af256ab-211c-40e5-b23e-8031479e39ed"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Gas"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Keyboard Arrows"",
                    ""id"": ""61346221-1c07-4108-9605-117cb4d3da6c"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Gas"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""dcc8a214-0517-4188-9853-d7afab4d72bd"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Gas"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""827347ed-8385-41db-9ad0-b422e760da45"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Gas"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""XR CombinedTrigger"",
                    ""id"": ""9c1ea9d9-61d4-4190-8ac9-315d14b93d1c"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Gas"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""c540dc95-fd10-4522-9d88-e77f363df03e"",
                    ""path"": ""*/{Grip}"",
                    ""interactions"": """",
                    ""processors"": ""AxisDeadzone(min=0.1,max=1)"",
                    ""groups"": """",
                    ""action"": ""Gas"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""cede6af8-fd91-4667-94c1-70a859f45d4e"",
                    ""path"": ""*/{Trigger}"",
                    ""interactions"": """",
                    ""processors"": ""AxisDeadzone(min=0.1,max=1)"",
                    ""groups"": """",
                    ""action"": ""Gas"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""98b999d1-ecd0-4424-8b0b-accccc783a9f"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9a66406f-7b45-485b-9024-1bc6c78f8254"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""72a2dfec-e891-4077-969d-f42a7c5d7818"",
                    ""path"": ""*/{PrimaryButton}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0a3f333c-c23f-4ee1-b79f-5dcd6438711f"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ExitVehicle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cae85c41-32e8-4c1f-8018-a874c59ba1b3"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ExitVehicle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c1ae91d6-bc2e-4b33-8f62-75aaa732d23b"",
                    ""path"": ""*/{Primary2DAxisClick}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ExitVehicle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Walking
        m_Walking = asset.GetActionMap("Walking");
        m_Walking_Movement = m_Walking.GetAction("Movement");
        m_Walking_Jump = m_Walking.GetAction("Jump");
        m_Walking_EnterVehicle = m_Walking.GetAction("EnterVehicle");
        // Tank
        m_Tank = asset.GetActionMap("Tank");
        m_Tank_Steering = m_Tank.GetAction("Steering");
        m_Tank_Gas = m_Tank.GetAction("Gas");
        m_Tank_Fire = m_Tank.GetAction("Fire");
        m_Tank_ExitVehicle = m_Tank.GetAction("ExitVehicle");
    }

    ~PlayerControls()
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

    // Walking
    private readonly InputActionMap m_Walking;
    private IWalkingActions m_WalkingActionsCallbackInterface;
    private readonly InputAction m_Walking_Movement;
    private readonly InputAction m_Walking_Jump;
    private readonly InputAction m_Walking_EnterVehicle;
    public struct WalkingActions
    {
        private PlayerControls m_Wrapper;
        public WalkingActions(PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Walking_Movement;
        public InputAction @Jump => m_Wrapper.m_Walking_Jump;
        public InputAction @EnterVehicle => m_Wrapper.m_Walking_EnterVehicle;
        public InputActionMap Get() { return m_Wrapper.m_Walking; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(WalkingActions set) { return set.Get(); }
        public void SetCallbacks(IWalkingActions instance)
        {
            if (m_Wrapper.m_WalkingActionsCallbackInterface != null)
            {
                Movement.started -= m_Wrapper.m_WalkingActionsCallbackInterface.OnMovement;
                Movement.performed -= m_Wrapper.m_WalkingActionsCallbackInterface.OnMovement;
                Movement.canceled -= m_Wrapper.m_WalkingActionsCallbackInterface.OnMovement;
                Jump.started -= m_Wrapper.m_WalkingActionsCallbackInterface.OnJump;
                Jump.performed -= m_Wrapper.m_WalkingActionsCallbackInterface.OnJump;
                Jump.canceled -= m_Wrapper.m_WalkingActionsCallbackInterface.OnJump;
                EnterVehicle.started -= m_Wrapper.m_WalkingActionsCallbackInterface.OnEnterVehicle;
                EnterVehicle.performed -= m_Wrapper.m_WalkingActionsCallbackInterface.OnEnterVehicle;
                EnterVehicle.canceled -= m_Wrapper.m_WalkingActionsCallbackInterface.OnEnterVehicle;
            }
            m_Wrapper.m_WalkingActionsCallbackInterface = instance;
            if (instance != null)
            {
                Movement.started += instance.OnMovement;
                Movement.performed += instance.OnMovement;
                Movement.canceled += instance.OnMovement;
                Jump.started += instance.OnJump;
                Jump.performed += instance.OnJump;
                Jump.canceled += instance.OnJump;
                EnterVehicle.started += instance.OnEnterVehicle;
                EnterVehicle.performed += instance.OnEnterVehicle;
                EnterVehicle.canceled += instance.OnEnterVehicle;
            }
        }
    }
    public WalkingActions @Walking => new WalkingActions(this);

    // Tank
    private readonly InputActionMap m_Tank;
    private ITankActions m_TankActionsCallbackInterface;
    private readonly InputAction m_Tank_Steering;
    private readonly InputAction m_Tank_Gas;
    private readonly InputAction m_Tank_Fire;
    private readonly InputAction m_Tank_ExitVehicle;
    public struct TankActions
    {
        private PlayerControls m_Wrapper;
        public TankActions(PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Steering => m_Wrapper.m_Tank_Steering;
        public InputAction @Gas => m_Wrapper.m_Tank_Gas;
        public InputAction @Fire => m_Wrapper.m_Tank_Fire;
        public InputAction @ExitVehicle => m_Wrapper.m_Tank_ExitVehicle;
        public InputActionMap Get() { return m_Wrapper.m_Tank; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TankActions set) { return set.Get(); }
        public void SetCallbacks(ITankActions instance)
        {
            if (m_Wrapper.m_TankActionsCallbackInterface != null)
            {
                Steering.started -= m_Wrapper.m_TankActionsCallbackInterface.OnSteering;
                Steering.performed -= m_Wrapper.m_TankActionsCallbackInterface.OnSteering;
                Steering.canceled -= m_Wrapper.m_TankActionsCallbackInterface.OnSteering;
                Gas.started -= m_Wrapper.m_TankActionsCallbackInterface.OnGas;
                Gas.performed -= m_Wrapper.m_TankActionsCallbackInterface.OnGas;
                Gas.canceled -= m_Wrapper.m_TankActionsCallbackInterface.OnGas;
                Fire.started -= m_Wrapper.m_TankActionsCallbackInterface.OnFire;
                Fire.performed -= m_Wrapper.m_TankActionsCallbackInterface.OnFire;
                Fire.canceled -= m_Wrapper.m_TankActionsCallbackInterface.OnFire;
                ExitVehicle.started -= m_Wrapper.m_TankActionsCallbackInterface.OnExitVehicle;
                ExitVehicle.performed -= m_Wrapper.m_TankActionsCallbackInterface.OnExitVehicle;
                ExitVehicle.canceled -= m_Wrapper.m_TankActionsCallbackInterface.OnExitVehicle;
            }
            m_Wrapper.m_TankActionsCallbackInterface = instance;
            if (instance != null)
            {
                Steering.started += instance.OnSteering;
                Steering.performed += instance.OnSteering;
                Steering.canceled += instance.OnSteering;
                Gas.started += instance.OnGas;
                Gas.performed += instance.OnGas;
                Gas.canceled += instance.OnGas;
                Fire.started += instance.OnFire;
                Fire.performed += instance.OnFire;
                Fire.canceled += instance.OnFire;
                ExitVehicle.started += instance.OnExitVehicle;
                ExitVehicle.performed += instance.OnExitVehicle;
                ExitVehicle.canceled += instance.OnExitVehicle;
            }
        }
    }
    public TankActions @Tank => new TankActions(this);
    public interface IWalkingActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnEnterVehicle(InputAction.CallbackContext context);
    }
    public interface ITankActions
    {
        void OnSteering(InputAction.CallbackContext context);
        void OnGas(InputAction.CallbackContext context);
        void OnFire(InputAction.CallbackContext context);
        void OnExitVehicle(InputAction.CallbackContext context);
    }
}
