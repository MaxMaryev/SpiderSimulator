// GENERATED AUTOMATICALLY FROM 'Assets/NewInputSystem/InputControl.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputControl : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputControl()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputControl"",
    ""maps"": [
        {
            ""name"": ""Spider"",
            ""id"": ""5a52b13b-04fa-4a49-9206-aad0b583eea7"",
            ""actions"": [
                {
                    ""name"": ""Left1"",
                    ""type"": ""Button"",
                    ""id"": ""8db25849-b53b-4ca9-a976-db05130d2634"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Left2"",
                    ""type"": ""Button"",
                    ""id"": ""513faf94-32e4-4f7d-a818-228e8f93e67e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Left3"",
                    ""type"": ""Button"",
                    ""id"": ""e39912b0-f9a5-45e5-8e63-7aadf992b073"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Left4"",
                    ""type"": ""Button"",
                    ""id"": ""940f48e0-33db-48ab-b781-b68ee9db6abd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Right1"",
                    ""type"": ""Button"",
                    ""id"": ""88f9737c-48aa-47aa-9930-1901501bf940"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Right2"",
                    ""type"": ""Button"",
                    ""id"": ""43b56ca2-0959-46b9-929a-eb28832f3c6b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Right3"",
                    ""type"": ""Button"",
                    ""id"": ""44f903ba-2dc5-4411-a520-be68edc77b79"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Right4"",
                    ""type"": ""Button"",
                    ""id"": ""71e05fd3-8b3d-4323-a0a3-1510441793be"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b6a2e640-b10b-4295-a9a2-f95c50518f12"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": ""Press(pressPoint=0.1,behavior=1)"",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Left1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7f0ec230-58aa-44fd-bae7-73e65695814f"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": ""Press(pressPoint=0.1,behavior=1)"",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Left2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3b1fb217-ccc9-425b-b09f-8f77d15e9b01"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": ""Press(pressPoint=0.1,behavior=1)"",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Left3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""910980f6-7935-4d0f-81ac-4352bbd5f1e1"",
                    ""path"": ""<Keyboard>/4"",
                    ""interactions"": ""Press(pressPoint=0.1,behavior=1)"",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Left4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1872f93e-ce5b-40f1-a263-890f75b950d6"",
                    ""path"": ""<Keyboard>/6"",
                    ""interactions"": ""Press(pressPoint=0.1,behavior=1)"",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Right1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4a9adfb8-b6fb-4b6c-90f7-604b95ba1159"",
                    ""path"": ""<Keyboard>/7"",
                    ""interactions"": ""Press(pressPoint=0.1,behavior=1)"",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Right2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4cefadc7-eeda-496a-8555-cc3a68d50b45"",
                    ""path"": ""<Keyboard>/8"",
                    ""interactions"": ""Press(pressPoint=0.1,behavior=1)"",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Right3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9ba3ec5a-d304-4086-b986-786b60dbda03"",
                    ""path"": ""<Keyboard>/9"",
                    ""interactions"": ""Press(pressPoint=0.1,behavior=1)"",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Right4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""UI"",
            ""id"": ""a8a53720-354c-4cb6-927e-55cf2958e151"",
            ""actions"": [
                {
                    ""name"": ""TrackedDeviceOrientation"",
                    ""type"": ""PassThrough"",
                    ""id"": ""05277566-6844-4447-971e-3f82ec02b095"",
                    ""expectedControlType"": ""Quaternion"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TrackedDevicePosition"",
                    ""type"": ""PassThrough"",
                    ""id"": ""d1e971f8-b933-46a4-9062-61c216e3fc56"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RightClick"",
                    ""type"": ""PassThrough"",
                    ""id"": ""81db1b65-fbba-4304-88b1-b957d4451fda"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MiddleClick"",
                    ""type"": ""PassThrough"",
                    ""id"": ""14d35623-794b-4987-9672-e214bad42e24"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ScrollWheel"",
                    ""type"": ""PassThrough"",
                    ""id"": ""75ad175a-0d7b-4352-be34-8546c69e833c"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Click"",
                    ""type"": ""PassThrough"",
                    ""id"": ""1d6e6ad6-f0d4-4d83-ab3e-6ab2acac6be5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Point"",
                    ""type"": ""PassThrough"",
                    ""id"": ""ddf4a5a3-3138-4aeb-9431-eab54e449087"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Cancel"",
                    ""type"": ""Button"",
                    ""id"": ""87e8e9e0-5ee0-4c6e-970f-c72c6a81191b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Submit"",
                    ""type"": ""Button"",
                    ""id"": ""89dc68f9-5f26-499f-942d-0e0866ada93f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Navigate"",
                    ""type"": ""Value"",
                    ""id"": ""5d888dd9-ca64-48ba-bace-fc1c6337d45a"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveLeg_Right1"",
                    ""type"": ""PassThrough"",
                    ""id"": ""32db3316-a20e-4257-a916-233c01913889"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveLeg_Right2"",
                    ""type"": ""PassThrough"",
                    ""id"": ""44b5b48c-2266-4720-bb80-9678bb9bcdf1"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveLeg_Right3"",
                    ""type"": ""PassThrough"",
                    ""id"": ""f76e4b3c-88f1-4adf-8de3-bfb98f73d538"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveLeg_Right4"",
                    ""type"": ""PassThrough"",
                    ""id"": ""144591e9-9e98-4959-8da7-3810ea534347"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveLeg_Left1"",
                    ""type"": ""PassThrough"",
                    ""id"": ""d898afbe-9029-4a8b-b877-5c1f6db20cd9"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveLeg_Left2"",
                    ""type"": ""PassThrough"",
                    ""id"": ""9de2ed8d-17c4-47ca-9e3e-9ff8cca19cd1"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveLeg_Left3"",
                    ""type"": ""PassThrough"",
                    ""id"": ""636f3f11-88f1-4880-b22d-098be19ed186"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveLeg_Left4"",
                    ""type"": ""PassThrough"",
                    ""id"": ""ab08a630-1fb8-42c9-b677-96833190dbfc"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""24e2c554-d949-4735-8fbb-c197461a9e83"",
                    ""path"": ""<Touchscreen>/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""TouchScreen"",
                    ""action"": ""MoveLeg_Left4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""06e32963-d568-4395-9ae0-bcfdc4f5b331"",
                    ""path"": ""<Touchscreen>/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""TouchScreen"",
                    ""action"": ""MoveLeg_Left3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""06ce24df-6796-47e5-a90f-2e5be2ddc70a"",
                    ""path"": ""<Touchscreen>/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""TouchScreen"",
                    ""action"": ""MoveLeg_Left2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6c9c5f30-697d-40f3-a07f-d5c8b7418ed0"",
                    ""path"": ""<Touchscreen>/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""TouchScreen"",
                    ""action"": ""MoveLeg_Left1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ae5740f9-b41f-43ca-9899-9a924972242e"",
                    ""path"": ""<Touchscreen>/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""TouchScreen"",
                    ""action"": ""MoveLeg_Right4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1788037f-c44d-402e-bd52-ccceb205952b"",
                    ""path"": ""<Touchscreen>/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""TouchScreen"",
                    ""action"": ""MoveLeg_Right3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5632d19f-d408-4402-802d-faab7ca5a5f6"",
                    ""path"": ""<Touchscreen>/touch1/press"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": ""TouchScreen"",
                    ""action"": ""MoveLeg_Right2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2ff89059-a809-426c-b2f3-55ef3f089706"",
                    ""path"": ""<Touchscreen>/touch0/press"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": ""TouchScreen"",
                    ""action"": ""MoveLeg_Right1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Gamepad"",
                    ""id"": ""d12faab7-f8f0-4153-841a-277efdd81abb"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""6351c8db-ac6b-4ab1-a7a5-d925517c228a"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""up"",
                    ""id"": ""883ce3e2-ad9d-477c-9e73-9d7204852e67"",
                    ""path"": ""<Gamepad>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""4fbf05ed-4567-49b1-a163-118fe3875e18"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""19f19b8b-e814-43ae-91e5-eb3c2a96db9f"",
                    ""path"": ""<Gamepad>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""a75cd2c9-0809-464c-b2dd-f432947b36e1"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""e955d0fa-abae-42bf-88d5-ac30be31f4c0"",
                    ""path"": ""<Gamepad>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""f7188f00-1354-477e-b8fd-3b7ebb71fe7f"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""25952943-52c1-40e0-9a28-9269f045f6bc"",
                    ""path"": ""<Gamepad>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""8151250d-3bea-4b20-88af-baeda82d3801"",
                    ""path"": ""<Gamepad>/dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Joystick"",
                    ""id"": ""2857751f-7440-4e0b-a041-443147351fc9"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""c39a5f9a-4e24-4347-ba27-d9e401c4c648"",
                    ""path"": ""<Joystick>/stick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""129a29bc-c2a5-4306-8797-f675a07a3792"",
                    ""path"": ""<Joystick>/stick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""69284624-924b-4771-ac2d-4b6c9eb6abe5"",
                    ""path"": ""<Joystick>/stick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""f14bbbc6-ac74-4826-9859-b1ca9e9a3303"",
                    ""path"": ""<Joystick>/stick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""6d761235-2ca2-4dcd-9b8b-271204e05e6d"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""c949e7bd-e480-4c9b-a6ec-dadbeb36b376"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""up"",
                    ""id"": ""ae1770eb-16a7-45e9-bc9a-f8fffc3d455f"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""fa27176a-8e91-494e-b567-dbd7cd3e6acb"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""9a5c7618-df70-49e4-8e09-94ba0f1c802b"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""eca7e68b-916e-4411-a2af-d7fd01c035ba"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""319f25bd-5966-415f-a57b-6cf43b7973d8"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""f48b575f-77c6-4ef7-bb60-17b8a4e41ae7"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""34389588-ff9c-4c48-823d-f122ab718031"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""13a815f7-2033-4221-8c28-938aef6cdf68"",
                    ""path"": ""*/{Submit}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Submit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e0abfd32-9418-494c-8b5f-d721b6475b16"",
                    ""path"": ""*/{Cancel}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8ad39f82-dc50-418b-9eda-5b8c7a106418"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""204865fe-d27e-4690-a342-71f16b05ada6"",
                    ""path"": ""<Pen>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""220b88ca-daa7-4fbc-ae2c-8027d104d5cb"",
                    ""path"": ""<Touchscreen>/touch*/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Touch"",
                    ""action"": ""Point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e4480b25-91e4-4358-9de2-a712bd474771"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5c0def7c-c6b1-4706-9934-672296cbfd28"",
                    ""path"": ""<Pen>/tip"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b4ed8dac-b050-4ecf-bf80-5a51dc72cd2e"",
                    ""path"": ""<Touchscreen>/touch*/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Touch"",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e0bb2b48-431d-4c54-a7fa-b89299ffda11"",
                    ""path"": ""<XRController>/trigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XR"",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""586d9d0a-66c6-4708-a5fd-a4c0cc20932b"",
                    ""path"": ""<Mouse>/scroll"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""ScrollWheel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a83f9169-7e51-4926-a406-839b9a4b5bf3"",
                    ""path"": ""<Mouse>/middleButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""MiddleClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9c851592-ff4f-4f85-98cd-ea8545483e82"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""RightClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d135859f-ef2e-4a16-8d39-9931147e453f"",
                    ""path"": ""<XRController>/devicePosition"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XR"",
                    ""action"": ""TrackedDevicePosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cdbace47-d906-44f3-bb8d-2c9e8010abd2"",
                    ""path"": ""<XRController>/deviceRotation"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XR"",
                    ""action"": ""TrackedDeviceOrientation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""TouchScreen"",
            ""bindingGroup"": ""TouchScreen"",
            ""devices"": [
                {
                    ""devicePath"": ""<Touchscreen>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Mouse"",
            ""bindingGroup"": ""Mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Spider
        m_Spider = asset.FindActionMap("Spider", throwIfNotFound: true);
        m_Spider_Left1 = m_Spider.FindAction("Left1", throwIfNotFound: true);
        m_Spider_Left2 = m_Spider.FindAction("Left2", throwIfNotFound: true);
        m_Spider_Left3 = m_Spider.FindAction("Left3", throwIfNotFound: true);
        m_Spider_Left4 = m_Spider.FindAction("Left4", throwIfNotFound: true);
        m_Spider_Right1 = m_Spider.FindAction("Right1", throwIfNotFound: true);
        m_Spider_Right2 = m_Spider.FindAction("Right2", throwIfNotFound: true);
        m_Spider_Right3 = m_Spider.FindAction("Right3", throwIfNotFound: true);
        m_Spider_Right4 = m_Spider.FindAction("Right4", throwIfNotFound: true);
        // UI
        m_UI = asset.FindActionMap("UI", throwIfNotFound: true);
        m_UI_TrackedDeviceOrientation = m_UI.FindAction("TrackedDeviceOrientation", throwIfNotFound: true);
        m_UI_TrackedDevicePosition = m_UI.FindAction("TrackedDevicePosition", throwIfNotFound: true);
        m_UI_RightClick = m_UI.FindAction("RightClick", throwIfNotFound: true);
        m_UI_MiddleClick = m_UI.FindAction("MiddleClick", throwIfNotFound: true);
        m_UI_ScrollWheel = m_UI.FindAction("ScrollWheel", throwIfNotFound: true);
        m_UI_Click = m_UI.FindAction("Click", throwIfNotFound: true);
        m_UI_Point = m_UI.FindAction("Point", throwIfNotFound: true);
        m_UI_Cancel = m_UI.FindAction("Cancel", throwIfNotFound: true);
        m_UI_Submit = m_UI.FindAction("Submit", throwIfNotFound: true);
        m_UI_Navigate = m_UI.FindAction("Navigate", throwIfNotFound: true);
        m_UI_MoveLeg_Right1 = m_UI.FindAction("MoveLeg_Right1", throwIfNotFound: true);
        m_UI_MoveLeg_Right2 = m_UI.FindAction("MoveLeg_Right2", throwIfNotFound: true);
        m_UI_MoveLeg_Right3 = m_UI.FindAction("MoveLeg_Right3", throwIfNotFound: true);
        m_UI_MoveLeg_Right4 = m_UI.FindAction("MoveLeg_Right4", throwIfNotFound: true);
        m_UI_MoveLeg_Left1 = m_UI.FindAction("MoveLeg_Left1", throwIfNotFound: true);
        m_UI_MoveLeg_Left2 = m_UI.FindAction("MoveLeg_Left2", throwIfNotFound: true);
        m_UI_MoveLeg_Left3 = m_UI.FindAction("MoveLeg_Left3", throwIfNotFound: true);
        m_UI_MoveLeg_Left4 = m_UI.FindAction("MoveLeg_Left4", throwIfNotFound: true);
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

    // Spider
    private readonly InputActionMap m_Spider;
    private ISpiderActions m_SpiderActionsCallbackInterface;
    private readonly InputAction m_Spider_Left1;
    private readonly InputAction m_Spider_Left2;
    private readonly InputAction m_Spider_Left3;
    private readonly InputAction m_Spider_Left4;
    private readonly InputAction m_Spider_Right1;
    private readonly InputAction m_Spider_Right2;
    private readonly InputAction m_Spider_Right3;
    private readonly InputAction m_Spider_Right4;
    public struct SpiderActions
    {
        private @InputControl m_Wrapper;
        public SpiderActions(@InputControl wrapper) { m_Wrapper = wrapper; }
        public InputAction @Left1 => m_Wrapper.m_Spider_Left1;
        public InputAction @Left2 => m_Wrapper.m_Spider_Left2;
        public InputAction @Left3 => m_Wrapper.m_Spider_Left3;
        public InputAction @Left4 => m_Wrapper.m_Spider_Left4;
        public InputAction @Right1 => m_Wrapper.m_Spider_Right1;
        public InputAction @Right2 => m_Wrapper.m_Spider_Right2;
        public InputAction @Right3 => m_Wrapper.m_Spider_Right3;
        public InputAction @Right4 => m_Wrapper.m_Spider_Right4;
        public InputActionMap Get() { return m_Wrapper.m_Spider; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(SpiderActions set) { return set.Get(); }
        public void SetCallbacks(ISpiderActions instance)
        {
            if (m_Wrapper.m_SpiderActionsCallbackInterface != null)
            {
                @Left1.started -= m_Wrapper.m_SpiderActionsCallbackInterface.OnLeft1;
                @Left1.performed -= m_Wrapper.m_SpiderActionsCallbackInterface.OnLeft1;
                @Left1.canceled -= m_Wrapper.m_SpiderActionsCallbackInterface.OnLeft1;
                @Left2.started -= m_Wrapper.m_SpiderActionsCallbackInterface.OnLeft2;
                @Left2.performed -= m_Wrapper.m_SpiderActionsCallbackInterface.OnLeft2;
                @Left2.canceled -= m_Wrapper.m_SpiderActionsCallbackInterface.OnLeft2;
                @Left3.started -= m_Wrapper.m_SpiderActionsCallbackInterface.OnLeft3;
                @Left3.performed -= m_Wrapper.m_SpiderActionsCallbackInterface.OnLeft3;
                @Left3.canceled -= m_Wrapper.m_SpiderActionsCallbackInterface.OnLeft3;
                @Left4.started -= m_Wrapper.m_SpiderActionsCallbackInterface.OnLeft4;
                @Left4.performed -= m_Wrapper.m_SpiderActionsCallbackInterface.OnLeft4;
                @Left4.canceled -= m_Wrapper.m_SpiderActionsCallbackInterface.OnLeft4;
                @Right1.started -= m_Wrapper.m_SpiderActionsCallbackInterface.OnRight1;
                @Right1.performed -= m_Wrapper.m_SpiderActionsCallbackInterface.OnRight1;
                @Right1.canceled -= m_Wrapper.m_SpiderActionsCallbackInterface.OnRight1;
                @Right2.started -= m_Wrapper.m_SpiderActionsCallbackInterface.OnRight2;
                @Right2.performed -= m_Wrapper.m_SpiderActionsCallbackInterface.OnRight2;
                @Right2.canceled -= m_Wrapper.m_SpiderActionsCallbackInterface.OnRight2;
                @Right3.started -= m_Wrapper.m_SpiderActionsCallbackInterface.OnRight3;
                @Right3.performed -= m_Wrapper.m_SpiderActionsCallbackInterface.OnRight3;
                @Right3.canceled -= m_Wrapper.m_SpiderActionsCallbackInterface.OnRight3;
                @Right4.started -= m_Wrapper.m_SpiderActionsCallbackInterface.OnRight4;
                @Right4.performed -= m_Wrapper.m_SpiderActionsCallbackInterface.OnRight4;
                @Right4.canceled -= m_Wrapper.m_SpiderActionsCallbackInterface.OnRight4;
            }
            m_Wrapper.m_SpiderActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Left1.started += instance.OnLeft1;
                @Left1.performed += instance.OnLeft1;
                @Left1.canceled += instance.OnLeft1;
                @Left2.started += instance.OnLeft2;
                @Left2.performed += instance.OnLeft2;
                @Left2.canceled += instance.OnLeft2;
                @Left3.started += instance.OnLeft3;
                @Left3.performed += instance.OnLeft3;
                @Left3.canceled += instance.OnLeft3;
                @Left4.started += instance.OnLeft4;
                @Left4.performed += instance.OnLeft4;
                @Left4.canceled += instance.OnLeft4;
                @Right1.started += instance.OnRight1;
                @Right1.performed += instance.OnRight1;
                @Right1.canceled += instance.OnRight1;
                @Right2.started += instance.OnRight2;
                @Right2.performed += instance.OnRight2;
                @Right2.canceled += instance.OnRight2;
                @Right3.started += instance.OnRight3;
                @Right3.performed += instance.OnRight3;
                @Right3.canceled += instance.OnRight3;
                @Right4.started += instance.OnRight4;
                @Right4.performed += instance.OnRight4;
                @Right4.canceled += instance.OnRight4;
            }
        }
    }
    public SpiderActions @Spider => new SpiderActions(this);

    // UI
    private readonly InputActionMap m_UI;
    private IUIActions m_UIActionsCallbackInterface;
    private readonly InputAction m_UI_TrackedDeviceOrientation;
    private readonly InputAction m_UI_TrackedDevicePosition;
    private readonly InputAction m_UI_RightClick;
    private readonly InputAction m_UI_MiddleClick;
    private readonly InputAction m_UI_ScrollWheel;
    private readonly InputAction m_UI_Click;
    private readonly InputAction m_UI_Point;
    private readonly InputAction m_UI_Cancel;
    private readonly InputAction m_UI_Submit;
    private readonly InputAction m_UI_Navigate;
    private readonly InputAction m_UI_MoveLeg_Right1;
    private readonly InputAction m_UI_MoveLeg_Right2;
    private readonly InputAction m_UI_MoveLeg_Right3;
    private readonly InputAction m_UI_MoveLeg_Right4;
    private readonly InputAction m_UI_MoveLeg_Left1;
    private readonly InputAction m_UI_MoveLeg_Left2;
    private readonly InputAction m_UI_MoveLeg_Left3;
    private readonly InputAction m_UI_MoveLeg_Left4;
    public struct UIActions
    {
        private @InputControl m_Wrapper;
        public UIActions(@InputControl wrapper) { m_Wrapper = wrapper; }
        public InputAction @TrackedDeviceOrientation => m_Wrapper.m_UI_TrackedDeviceOrientation;
        public InputAction @TrackedDevicePosition => m_Wrapper.m_UI_TrackedDevicePosition;
        public InputAction @RightClick => m_Wrapper.m_UI_RightClick;
        public InputAction @MiddleClick => m_Wrapper.m_UI_MiddleClick;
        public InputAction @ScrollWheel => m_Wrapper.m_UI_ScrollWheel;
        public InputAction @Click => m_Wrapper.m_UI_Click;
        public InputAction @Point => m_Wrapper.m_UI_Point;
        public InputAction @Cancel => m_Wrapper.m_UI_Cancel;
        public InputAction @Submit => m_Wrapper.m_UI_Submit;
        public InputAction @Navigate => m_Wrapper.m_UI_Navigate;
        public InputAction @MoveLeg_Right1 => m_Wrapper.m_UI_MoveLeg_Right1;
        public InputAction @MoveLeg_Right2 => m_Wrapper.m_UI_MoveLeg_Right2;
        public InputAction @MoveLeg_Right3 => m_Wrapper.m_UI_MoveLeg_Right3;
        public InputAction @MoveLeg_Right4 => m_Wrapper.m_UI_MoveLeg_Right4;
        public InputAction @MoveLeg_Left1 => m_Wrapper.m_UI_MoveLeg_Left1;
        public InputAction @MoveLeg_Left2 => m_Wrapper.m_UI_MoveLeg_Left2;
        public InputAction @MoveLeg_Left3 => m_Wrapper.m_UI_MoveLeg_Left3;
        public InputAction @MoveLeg_Left4 => m_Wrapper.m_UI_MoveLeg_Left4;
        public InputActionMap Get() { return m_Wrapper.m_UI; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UIActions set) { return set.Get(); }
        public void SetCallbacks(IUIActions instance)
        {
            if (m_Wrapper.m_UIActionsCallbackInterface != null)
            {
                @TrackedDeviceOrientation.started -= m_Wrapper.m_UIActionsCallbackInterface.OnTrackedDeviceOrientation;
                @TrackedDeviceOrientation.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnTrackedDeviceOrientation;
                @TrackedDeviceOrientation.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnTrackedDeviceOrientation;
                @TrackedDevicePosition.started -= m_Wrapper.m_UIActionsCallbackInterface.OnTrackedDevicePosition;
                @TrackedDevicePosition.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnTrackedDevicePosition;
                @TrackedDevicePosition.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnTrackedDevicePosition;
                @RightClick.started -= m_Wrapper.m_UIActionsCallbackInterface.OnRightClick;
                @RightClick.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnRightClick;
                @RightClick.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnRightClick;
                @MiddleClick.started -= m_Wrapper.m_UIActionsCallbackInterface.OnMiddleClick;
                @MiddleClick.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnMiddleClick;
                @MiddleClick.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnMiddleClick;
                @ScrollWheel.started -= m_Wrapper.m_UIActionsCallbackInterface.OnScrollWheel;
                @ScrollWheel.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnScrollWheel;
                @ScrollWheel.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnScrollWheel;
                @Click.started -= m_Wrapper.m_UIActionsCallbackInterface.OnClick;
                @Click.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnClick;
                @Click.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnClick;
                @Point.started -= m_Wrapper.m_UIActionsCallbackInterface.OnPoint;
                @Point.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnPoint;
                @Point.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnPoint;
                @Cancel.started -= m_Wrapper.m_UIActionsCallbackInterface.OnCancel;
                @Cancel.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnCancel;
                @Cancel.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnCancel;
                @Submit.started -= m_Wrapper.m_UIActionsCallbackInterface.OnSubmit;
                @Submit.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnSubmit;
                @Submit.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnSubmit;
                @Navigate.started -= m_Wrapper.m_UIActionsCallbackInterface.OnNavigate;
                @Navigate.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnNavigate;
                @Navigate.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnNavigate;
                @MoveLeg_Right1.started -= m_Wrapper.m_UIActionsCallbackInterface.OnMoveLeg_Right1;
                @MoveLeg_Right1.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnMoveLeg_Right1;
                @MoveLeg_Right1.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnMoveLeg_Right1;
                @MoveLeg_Right2.started -= m_Wrapper.m_UIActionsCallbackInterface.OnMoveLeg_Right2;
                @MoveLeg_Right2.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnMoveLeg_Right2;
                @MoveLeg_Right2.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnMoveLeg_Right2;
                @MoveLeg_Right3.started -= m_Wrapper.m_UIActionsCallbackInterface.OnMoveLeg_Right3;
                @MoveLeg_Right3.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnMoveLeg_Right3;
                @MoveLeg_Right3.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnMoveLeg_Right3;
                @MoveLeg_Right4.started -= m_Wrapper.m_UIActionsCallbackInterface.OnMoveLeg_Right4;
                @MoveLeg_Right4.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnMoveLeg_Right4;
                @MoveLeg_Right4.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnMoveLeg_Right4;
                @MoveLeg_Left1.started -= m_Wrapper.m_UIActionsCallbackInterface.OnMoveLeg_Left1;
                @MoveLeg_Left1.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnMoveLeg_Left1;
                @MoveLeg_Left1.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnMoveLeg_Left1;
                @MoveLeg_Left2.started -= m_Wrapper.m_UIActionsCallbackInterface.OnMoveLeg_Left2;
                @MoveLeg_Left2.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnMoveLeg_Left2;
                @MoveLeg_Left2.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnMoveLeg_Left2;
                @MoveLeg_Left3.started -= m_Wrapper.m_UIActionsCallbackInterface.OnMoveLeg_Left3;
                @MoveLeg_Left3.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnMoveLeg_Left3;
                @MoveLeg_Left3.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnMoveLeg_Left3;
                @MoveLeg_Left4.started -= m_Wrapper.m_UIActionsCallbackInterface.OnMoveLeg_Left4;
                @MoveLeg_Left4.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnMoveLeg_Left4;
                @MoveLeg_Left4.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnMoveLeg_Left4;
            }
            m_Wrapper.m_UIActionsCallbackInterface = instance;
            if (instance != null)
            {
                @TrackedDeviceOrientation.started += instance.OnTrackedDeviceOrientation;
                @TrackedDeviceOrientation.performed += instance.OnTrackedDeviceOrientation;
                @TrackedDeviceOrientation.canceled += instance.OnTrackedDeviceOrientation;
                @TrackedDevicePosition.started += instance.OnTrackedDevicePosition;
                @TrackedDevicePosition.performed += instance.OnTrackedDevicePosition;
                @TrackedDevicePosition.canceled += instance.OnTrackedDevicePosition;
                @RightClick.started += instance.OnRightClick;
                @RightClick.performed += instance.OnRightClick;
                @RightClick.canceled += instance.OnRightClick;
                @MiddleClick.started += instance.OnMiddleClick;
                @MiddleClick.performed += instance.OnMiddleClick;
                @MiddleClick.canceled += instance.OnMiddleClick;
                @ScrollWheel.started += instance.OnScrollWheel;
                @ScrollWheel.performed += instance.OnScrollWheel;
                @ScrollWheel.canceled += instance.OnScrollWheel;
                @Click.started += instance.OnClick;
                @Click.performed += instance.OnClick;
                @Click.canceled += instance.OnClick;
                @Point.started += instance.OnPoint;
                @Point.performed += instance.OnPoint;
                @Point.canceled += instance.OnPoint;
                @Cancel.started += instance.OnCancel;
                @Cancel.performed += instance.OnCancel;
                @Cancel.canceled += instance.OnCancel;
                @Submit.started += instance.OnSubmit;
                @Submit.performed += instance.OnSubmit;
                @Submit.canceled += instance.OnSubmit;
                @Navigate.started += instance.OnNavigate;
                @Navigate.performed += instance.OnNavigate;
                @Navigate.canceled += instance.OnNavigate;
                @MoveLeg_Right1.started += instance.OnMoveLeg_Right1;
                @MoveLeg_Right1.performed += instance.OnMoveLeg_Right1;
                @MoveLeg_Right1.canceled += instance.OnMoveLeg_Right1;
                @MoveLeg_Right2.started += instance.OnMoveLeg_Right2;
                @MoveLeg_Right2.performed += instance.OnMoveLeg_Right2;
                @MoveLeg_Right2.canceled += instance.OnMoveLeg_Right2;
                @MoveLeg_Right3.started += instance.OnMoveLeg_Right3;
                @MoveLeg_Right3.performed += instance.OnMoveLeg_Right3;
                @MoveLeg_Right3.canceled += instance.OnMoveLeg_Right3;
                @MoveLeg_Right4.started += instance.OnMoveLeg_Right4;
                @MoveLeg_Right4.performed += instance.OnMoveLeg_Right4;
                @MoveLeg_Right4.canceled += instance.OnMoveLeg_Right4;
                @MoveLeg_Left1.started += instance.OnMoveLeg_Left1;
                @MoveLeg_Left1.performed += instance.OnMoveLeg_Left1;
                @MoveLeg_Left1.canceled += instance.OnMoveLeg_Left1;
                @MoveLeg_Left2.started += instance.OnMoveLeg_Left2;
                @MoveLeg_Left2.performed += instance.OnMoveLeg_Left2;
                @MoveLeg_Left2.canceled += instance.OnMoveLeg_Left2;
                @MoveLeg_Left3.started += instance.OnMoveLeg_Left3;
                @MoveLeg_Left3.performed += instance.OnMoveLeg_Left3;
                @MoveLeg_Left3.canceled += instance.OnMoveLeg_Left3;
                @MoveLeg_Left4.started += instance.OnMoveLeg_Left4;
                @MoveLeg_Left4.performed += instance.OnMoveLeg_Left4;
                @MoveLeg_Left4.canceled += instance.OnMoveLeg_Left4;
            }
        }
    }
    public UIActions @UI => new UIActions(this);
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    private int m_TouchScreenSchemeIndex = -1;
    public InputControlScheme TouchScreenScheme
    {
        get
        {
            if (m_TouchScreenSchemeIndex == -1) m_TouchScreenSchemeIndex = asset.FindControlSchemeIndex("TouchScreen");
            return asset.controlSchemes[m_TouchScreenSchemeIndex];
        }
    }
    private int m_MouseSchemeIndex = -1;
    public InputControlScheme MouseScheme
    {
        get
        {
            if (m_MouseSchemeIndex == -1) m_MouseSchemeIndex = asset.FindControlSchemeIndex("Mouse");
            return asset.controlSchemes[m_MouseSchemeIndex];
        }
    }
    public interface ISpiderActions
    {
        void OnLeft1(InputAction.CallbackContext context);
        void OnLeft2(InputAction.CallbackContext context);
        void OnLeft3(InputAction.CallbackContext context);
        void OnLeft4(InputAction.CallbackContext context);
        void OnRight1(InputAction.CallbackContext context);
        void OnRight2(InputAction.CallbackContext context);
        void OnRight3(InputAction.CallbackContext context);
        void OnRight4(InputAction.CallbackContext context);
    }
    public interface IUIActions
    {
        void OnTrackedDeviceOrientation(InputAction.CallbackContext context);
        void OnTrackedDevicePosition(InputAction.CallbackContext context);
        void OnRightClick(InputAction.CallbackContext context);
        void OnMiddleClick(InputAction.CallbackContext context);
        void OnScrollWheel(InputAction.CallbackContext context);
        void OnClick(InputAction.CallbackContext context);
        void OnPoint(InputAction.CallbackContext context);
        void OnCancel(InputAction.CallbackContext context);
        void OnSubmit(InputAction.CallbackContext context);
        void OnNavigate(InputAction.CallbackContext context);
        void OnMoveLeg_Right1(InputAction.CallbackContext context);
        void OnMoveLeg_Right2(InputAction.CallbackContext context);
        void OnMoveLeg_Right3(InputAction.CallbackContext context);
        void OnMoveLeg_Right4(InputAction.CallbackContext context);
        void OnMoveLeg_Left1(InputAction.CallbackContext context);
        void OnMoveLeg_Left2(InputAction.CallbackContext context);
        void OnMoveLeg_Left3(InputAction.CallbackContext context);
        void OnMoveLeg_Left4(InputAction.CallbackContext context);
    }
}
