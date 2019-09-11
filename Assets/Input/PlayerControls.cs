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
                }
            ]
        },
        {
            ""name"": ""Driving"",
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
                    ""name"": ""Brake"",
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
                    ""name"": ""AD"",
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
                    ""name"": ""Arrows"",
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
                    ""id"": ""920bef31-1f8b-4015-915c-1ea9875ff074"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Gas"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c9502445-13eb-4d43-85fb-77c3169d53ed"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Gas"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""52525af6-632a-487c-8df9-3ab9cc8ce90e"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Gas"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""98b999d1-ecd0-4424-8b0b-accccc783a9f"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Brake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""afe3f5d2-8e82-4b10-9c30-24dcbe68c0b7"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Brake"",
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
                    ""action"": ""Brake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""30c1abcb-1e98-4885-96b1-282e3a0ad2b0"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Brake"",
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
                }
            ]
        },
        {
            ""name"": ""Helicopter"",
            ""id"": ""e7ca52f9-a6c3-4fe4-9c4d-d278dca9fa6b"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Button"",
                    ""id"": ""f51af259-db7a-478c-8133-06bfe5c4b1f9"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Up"",
                    ""type"": ""Button"",
                    ""id"": ""fb6d9dd0-0355-413e-a8fa-193f653330d0"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Down"",
                    ""type"": ""Button"",
                    ""id"": ""743a8ec4-62e5-4e17-acdd-b61715441fd6"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Rotate"",
                    ""type"": ""Button"",
                    ""id"": ""a268646b-430e-4d53-90d0-ac259b4faa85"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ExitVehicle"",
                    ""type"": ""Button"",
                    ""id"": ""31c80d44-ffee-498c-8343-78761b21e081"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""276e4481-44fc-4d2b-bf7a-54b3b05235b8"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b26ba605-02e8-497a-a680-feed222ae3e8"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8f142d7a-7011-4044-acb7-eee7ca505dc1"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""06b1b961-4606-453e-b545-7493f5a2d8e0"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f99f9d79-45a8-4c9e-bf1f-7ff8bfbf18d0"",
                    ""path"": """",
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
        // Driving
        m_Driving = asset.GetActionMap("Driving");
        m_Driving_Steering = m_Driving.GetAction("Steering");
        m_Driving_Gas = m_Driving.GetAction("Gas");
        m_Driving_Brake = m_Driving.GetAction("Brake");
        m_Driving_ExitVehicle = m_Driving.GetAction("ExitVehicle");
        // Helicopter
        m_Helicopter = asset.GetActionMap("Helicopter");
        m_Helicopter_Move = m_Helicopter.GetAction("Move");
        m_Helicopter_Up = m_Helicopter.GetAction("Up");
        m_Helicopter_Down = m_Helicopter.GetAction("Down");
        m_Helicopter_Rotate = m_Helicopter.GetAction("Rotate");
        m_Helicopter_ExitVehicle = m_Helicopter.GetAction("ExitVehicle");
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

    // Driving
    private readonly InputActionMap m_Driving;
    private IDrivingActions m_DrivingActionsCallbackInterface;
    private readonly InputAction m_Driving_Steering;
    private readonly InputAction m_Driving_Gas;
    private readonly InputAction m_Driving_Brake;
    private readonly InputAction m_Driving_ExitVehicle;
    public struct DrivingActions
    {
        private PlayerControls m_Wrapper;
        public DrivingActions(PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Steering => m_Wrapper.m_Driving_Steering;
        public InputAction @Gas => m_Wrapper.m_Driving_Gas;
        public InputAction @Brake => m_Wrapper.m_Driving_Brake;
        public InputAction @ExitVehicle => m_Wrapper.m_Driving_ExitVehicle;
        public InputActionMap Get() { return m_Wrapper.m_Driving; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DrivingActions set) { return set.Get(); }
        public void SetCallbacks(IDrivingActions instance)
        {
            if (m_Wrapper.m_DrivingActionsCallbackInterface != null)
            {
                Steering.started -= m_Wrapper.m_DrivingActionsCallbackInterface.OnSteering;
                Steering.performed -= m_Wrapper.m_DrivingActionsCallbackInterface.OnSteering;
                Steering.canceled -= m_Wrapper.m_DrivingActionsCallbackInterface.OnSteering;
                Gas.started -= m_Wrapper.m_DrivingActionsCallbackInterface.OnGas;
                Gas.performed -= m_Wrapper.m_DrivingActionsCallbackInterface.OnGas;
                Gas.canceled -= m_Wrapper.m_DrivingActionsCallbackInterface.OnGas;
                Brake.started -= m_Wrapper.m_DrivingActionsCallbackInterface.OnBrake;
                Brake.performed -= m_Wrapper.m_DrivingActionsCallbackInterface.OnBrake;
                Brake.canceled -= m_Wrapper.m_DrivingActionsCallbackInterface.OnBrake;
                ExitVehicle.started -= m_Wrapper.m_DrivingActionsCallbackInterface.OnExitVehicle;
                ExitVehicle.performed -= m_Wrapper.m_DrivingActionsCallbackInterface.OnExitVehicle;
                ExitVehicle.canceled -= m_Wrapper.m_DrivingActionsCallbackInterface.OnExitVehicle;
            }
            m_Wrapper.m_DrivingActionsCallbackInterface = instance;
            if (instance != null)
            {
                Steering.started += instance.OnSteering;
                Steering.performed += instance.OnSteering;
                Steering.canceled += instance.OnSteering;
                Gas.started += instance.OnGas;
                Gas.performed += instance.OnGas;
                Gas.canceled += instance.OnGas;
                Brake.started += instance.OnBrake;
                Brake.performed += instance.OnBrake;
                Brake.canceled += instance.OnBrake;
                ExitVehicle.started += instance.OnExitVehicle;
                ExitVehicle.performed += instance.OnExitVehicle;
                ExitVehicle.canceled += instance.OnExitVehicle;
            }
        }
    }
    public DrivingActions @Driving => new DrivingActions(this);

    // Helicopter
    private readonly InputActionMap m_Helicopter;
    private IHelicopterActions m_HelicopterActionsCallbackInterface;
    private readonly InputAction m_Helicopter_Move;
    private readonly InputAction m_Helicopter_Up;
    private readonly InputAction m_Helicopter_Down;
    private readonly InputAction m_Helicopter_Rotate;
    private readonly InputAction m_Helicopter_ExitVehicle;
    public struct HelicopterActions
    {
        private PlayerControls m_Wrapper;
        public HelicopterActions(PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Helicopter_Move;
        public InputAction @Up => m_Wrapper.m_Helicopter_Up;
        public InputAction @Down => m_Wrapper.m_Helicopter_Down;
        public InputAction @Rotate => m_Wrapper.m_Helicopter_Rotate;
        public InputAction @ExitVehicle => m_Wrapper.m_Helicopter_ExitVehicle;
        public InputActionMap Get() { return m_Wrapper.m_Helicopter; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(HelicopterActions set) { return set.Get(); }
        public void SetCallbacks(IHelicopterActions instance)
        {
            if (m_Wrapper.m_HelicopterActionsCallbackInterface != null)
            {
                Move.started -= m_Wrapper.m_HelicopterActionsCallbackInterface.OnMove;
                Move.performed -= m_Wrapper.m_HelicopterActionsCallbackInterface.OnMove;
                Move.canceled -= m_Wrapper.m_HelicopterActionsCallbackInterface.OnMove;
                Up.started -= m_Wrapper.m_HelicopterActionsCallbackInterface.OnUp;
                Up.performed -= m_Wrapper.m_HelicopterActionsCallbackInterface.OnUp;
                Up.canceled -= m_Wrapper.m_HelicopterActionsCallbackInterface.OnUp;
                Down.started -= m_Wrapper.m_HelicopterActionsCallbackInterface.OnDown;
                Down.performed -= m_Wrapper.m_HelicopterActionsCallbackInterface.OnDown;
                Down.canceled -= m_Wrapper.m_HelicopterActionsCallbackInterface.OnDown;
                Rotate.started -= m_Wrapper.m_HelicopterActionsCallbackInterface.OnRotate;
                Rotate.performed -= m_Wrapper.m_HelicopterActionsCallbackInterface.OnRotate;
                Rotate.canceled -= m_Wrapper.m_HelicopterActionsCallbackInterface.OnRotate;
                ExitVehicle.started -= m_Wrapper.m_HelicopterActionsCallbackInterface.OnExitVehicle;
                ExitVehicle.performed -= m_Wrapper.m_HelicopterActionsCallbackInterface.OnExitVehicle;
                ExitVehicle.canceled -= m_Wrapper.m_HelicopterActionsCallbackInterface.OnExitVehicle;
            }
            m_Wrapper.m_HelicopterActionsCallbackInterface = instance;
            if (instance != null)
            {
                Move.started += instance.OnMove;
                Move.performed += instance.OnMove;
                Move.canceled += instance.OnMove;
                Up.started += instance.OnUp;
                Up.performed += instance.OnUp;
                Up.canceled += instance.OnUp;
                Down.started += instance.OnDown;
                Down.performed += instance.OnDown;
                Down.canceled += instance.OnDown;
                Rotate.started += instance.OnRotate;
                Rotate.performed += instance.OnRotate;
                Rotate.canceled += instance.OnRotate;
                ExitVehicle.started += instance.OnExitVehicle;
                ExitVehicle.performed += instance.OnExitVehicle;
                ExitVehicle.canceled += instance.OnExitVehicle;
            }
        }
    }
    public HelicopterActions @Helicopter => new HelicopterActions(this);
    public interface IWalkingActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnEnterVehicle(InputAction.CallbackContext context);
    }
    public interface IDrivingActions
    {
        void OnSteering(InputAction.CallbackContext context);
        void OnGas(InputAction.CallbackContext context);
        void OnBrake(InputAction.CallbackContext context);
        void OnExitVehicle(InputAction.CallbackContext context);
    }
    public interface IHelicopterActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnUp(InputAction.CallbackContext context);
        void OnDown(InputAction.CallbackContext context);
        void OnRotate(InputAction.CallbackContext context);
        void OnExitVehicle(InputAction.CallbackContext context);
    }
}
