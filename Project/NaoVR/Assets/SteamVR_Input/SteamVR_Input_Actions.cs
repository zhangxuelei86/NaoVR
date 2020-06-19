//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Valve.VR
{
    using System;
    using UnityEngine;
    
    
    public partial class SteamVR_Actions
    {
        
        private static SteamVR_Action_Pose p_default_Pose;
        
        private static SteamVR_Action_Skeleton p_default_SkeletonLeftHand;
        
        private static SteamVR_Action_Skeleton p_default_SkeletonRightHand;
        
        private static SteamVR_Action_Boolean p_default_CloseHand;
        
        private static SteamVR_Action_Boolean p_default_HeadsetOnHead;
        
        private static SteamVR_Action_Boolean p_default_Calibrate;
        
        private static SteamVR_Action_Boolean p_default_ArmDisarm;
        
        private static SteamVR_Action_Boolean p_default_WalkForward;
        
        private static SteamVR_Action_Boolean p_default_TurnLeft;
        
        private static SteamVR_Action_Boolean p_default_TurnRight;
        
        private static SteamVR_Action_Boolean p_default_Crouch;
        
        private static SteamVR_Action_Boolean p_default_Stand;
        
        private static SteamVR_Action_Boolean p_default_NewAction;
        
        private static SteamVR_Action_Vibration p_default_Haptic;
        
        private static SteamVR_Action_Vector2 p_platformer_Move;
        
        private static SteamVR_Action_Boolean p_platformer_Jump;
        
        private static SteamVR_Action_Vector2 p_buggy_Steering;
        
        private static SteamVR_Action_Single p_buggy_Throttle;
        
        private static SteamVR_Action_Boolean p_buggy_Brake;
        
        private static SteamVR_Action_Boolean p_buggy_Reset;
        
        private static SteamVR_Action_Pose p_mixedreality_ExternalCamera;
        
        private static SteamVR_Action_Boolean p_naoVR_Calibrate;
        
        private static SteamVR_Action_Boolean p_naoVR_CheckConstraints;
        
        public static SteamVR_Action_Pose default_Pose
        {
            get
            {
                return SteamVR_Actions.p_default_Pose.GetCopy<SteamVR_Action_Pose>();
            }
        }
        
        public static SteamVR_Action_Skeleton default_SkeletonLeftHand
        {
            get
            {
                return SteamVR_Actions.p_default_SkeletonLeftHand.GetCopy<SteamVR_Action_Skeleton>();
            }
        }
        
        public static SteamVR_Action_Skeleton default_SkeletonRightHand
        {
            get
            {
                return SteamVR_Actions.p_default_SkeletonRightHand.GetCopy<SteamVR_Action_Skeleton>();
            }
        }
        
        public static SteamVR_Action_Boolean default_CloseHand
        {
            get
            {
                return SteamVR_Actions.p_default_CloseHand.GetCopy<SteamVR_Action_Boolean>();
            }
        }
        
        public static SteamVR_Action_Boolean default_HeadsetOnHead
        {
            get
            {
                return SteamVR_Actions.p_default_HeadsetOnHead.GetCopy<SteamVR_Action_Boolean>();
            }
        }
        
        public static SteamVR_Action_Boolean default_Calibrate
        {
            get
            {
                return SteamVR_Actions.p_default_Calibrate.GetCopy<SteamVR_Action_Boolean>();
            }
        }
        
        public static SteamVR_Action_Boolean default_ArmDisarm
        {
            get
            {
                return SteamVR_Actions.p_default_ArmDisarm.GetCopy<SteamVR_Action_Boolean>();
            }
        }
        
        public static SteamVR_Action_Boolean default_WalkForward
        {
            get
            {
                return SteamVR_Actions.p_default_WalkForward.GetCopy<SteamVR_Action_Boolean>();
            }
        }
        
        public static SteamVR_Action_Boolean default_TurnLeft
        {
            get
            {
                return SteamVR_Actions.p_default_TurnLeft.GetCopy<SteamVR_Action_Boolean>();
            }
        }
        
        public static SteamVR_Action_Boolean default_TurnRight
        {
            get
            {
                return SteamVR_Actions.p_default_TurnRight.GetCopy<SteamVR_Action_Boolean>();
            }
        }
        
        public static SteamVR_Action_Boolean default_Crouch
        {
            get
            {
                return SteamVR_Actions.p_default_Crouch.GetCopy<SteamVR_Action_Boolean>();
            }
        }
        
        public static SteamVR_Action_Boolean default_Stand
        {
            get
            {
                return SteamVR_Actions.p_default_Stand.GetCopy<SteamVR_Action_Boolean>();
            }
        }
        
        public static SteamVR_Action_Boolean default_NewAction
        {
            get
            {
                return SteamVR_Actions.p_default_NewAction.GetCopy<SteamVR_Action_Boolean>();
            }
        }
        
        public static SteamVR_Action_Vibration default_Haptic
        {
            get
            {
                return SteamVR_Actions.p_default_Haptic.GetCopy<SteamVR_Action_Vibration>();
            }
        }
        
        public static SteamVR_Action_Vector2 platformer_Move
        {
            get
            {
                return SteamVR_Actions.p_platformer_Move.GetCopy<SteamVR_Action_Vector2>();
            }
        }
        
        public static SteamVR_Action_Boolean platformer_Jump
        {
            get
            {
                return SteamVR_Actions.p_platformer_Jump.GetCopy<SteamVR_Action_Boolean>();
            }
        }
        
        public static SteamVR_Action_Vector2 buggy_Steering
        {
            get
            {
                return SteamVR_Actions.p_buggy_Steering.GetCopy<SteamVR_Action_Vector2>();
            }
        }
        
        public static SteamVR_Action_Single buggy_Throttle
        {
            get
            {
                return SteamVR_Actions.p_buggy_Throttle.GetCopy<SteamVR_Action_Single>();
            }
        }
        
        public static SteamVR_Action_Boolean buggy_Brake
        {
            get
            {
                return SteamVR_Actions.p_buggy_Brake.GetCopy<SteamVR_Action_Boolean>();
            }
        }
        
        public static SteamVR_Action_Boolean buggy_Reset
        {
            get
            {
                return SteamVR_Actions.p_buggy_Reset.GetCopy<SteamVR_Action_Boolean>();
            }
        }
        
        public static SteamVR_Action_Pose mixedreality_ExternalCamera
        {
            get
            {
                return SteamVR_Actions.p_mixedreality_ExternalCamera.GetCopy<SteamVR_Action_Pose>();
            }
        }
        
        public static SteamVR_Action_Boolean naoVR_Calibrate
        {
            get
            {
                return SteamVR_Actions.p_naoVR_Calibrate.GetCopy<SteamVR_Action_Boolean>();
            }
        }
        
        public static SteamVR_Action_Boolean naoVR_CheckConstraints
        {
            get
            {
                return SteamVR_Actions.p_naoVR_CheckConstraints.GetCopy<SteamVR_Action_Boolean>();
            }
        }
        
        private static void InitializeActionArrays()
        {
            Valve.VR.SteamVR_Input.actions = new Valve.VR.SteamVR_Action[] {
                    SteamVR_Actions.default_Pose,
                    SteamVR_Actions.default_SkeletonLeftHand,
                    SteamVR_Actions.default_SkeletonRightHand,
                    SteamVR_Actions.default_CloseHand,
                    SteamVR_Actions.default_HeadsetOnHead,
                    SteamVR_Actions.default_Calibrate,
                    SteamVR_Actions.default_ArmDisarm,
                    SteamVR_Actions.default_WalkForward,
                    SteamVR_Actions.default_TurnLeft,
                    SteamVR_Actions.default_TurnRight,
                    SteamVR_Actions.default_Crouch,
                    SteamVR_Actions.default_Stand,
                    SteamVR_Actions.default_NewAction,
                    SteamVR_Actions.default_Haptic,
                    SteamVR_Actions.platformer_Move,
                    SteamVR_Actions.platformer_Jump,
                    SteamVR_Actions.buggy_Steering,
                    SteamVR_Actions.buggy_Throttle,
                    SteamVR_Actions.buggy_Brake,
                    SteamVR_Actions.buggy_Reset,
                    SteamVR_Actions.mixedreality_ExternalCamera,
                    SteamVR_Actions.naoVR_Calibrate,
                    SteamVR_Actions.naoVR_CheckConstraints};
            Valve.VR.SteamVR_Input.actionsIn = new Valve.VR.ISteamVR_Action_In[] {
                    SteamVR_Actions.default_Pose,
                    SteamVR_Actions.default_SkeletonLeftHand,
                    SteamVR_Actions.default_SkeletonRightHand,
                    SteamVR_Actions.default_CloseHand,
                    SteamVR_Actions.default_HeadsetOnHead,
                    SteamVR_Actions.default_Calibrate,
                    SteamVR_Actions.default_ArmDisarm,
                    SteamVR_Actions.default_WalkForward,
                    SteamVR_Actions.default_TurnLeft,
                    SteamVR_Actions.default_TurnRight,
                    SteamVR_Actions.default_Crouch,
                    SteamVR_Actions.default_Stand,
                    SteamVR_Actions.default_NewAction,
                    SteamVR_Actions.platformer_Move,
                    SteamVR_Actions.platformer_Jump,
                    SteamVR_Actions.buggy_Steering,
                    SteamVR_Actions.buggy_Throttle,
                    SteamVR_Actions.buggy_Brake,
                    SteamVR_Actions.buggy_Reset,
                    SteamVR_Actions.mixedreality_ExternalCamera,
                    SteamVR_Actions.naoVR_Calibrate,
                    SteamVR_Actions.naoVR_CheckConstraints};
            Valve.VR.SteamVR_Input.actionsOut = new Valve.VR.ISteamVR_Action_Out[] {
                    SteamVR_Actions.default_Haptic};
            Valve.VR.SteamVR_Input.actionsVibration = new Valve.VR.SteamVR_Action_Vibration[] {
                    SteamVR_Actions.default_Haptic};
            Valve.VR.SteamVR_Input.actionsPose = new Valve.VR.SteamVR_Action_Pose[] {
                    SteamVR_Actions.default_Pose,
                    SteamVR_Actions.mixedreality_ExternalCamera};
            Valve.VR.SteamVR_Input.actionsBoolean = new Valve.VR.SteamVR_Action_Boolean[] {
                    SteamVR_Actions.default_CloseHand,
                    SteamVR_Actions.default_HeadsetOnHead,
                    SteamVR_Actions.default_Calibrate,
                    SteamVR_Actions.default_ArmDisarm,
                    SteamVR_Actions.default_WalkForward,
                    SteamVR_Actions.default_TurnLeft,
                    SteamVR_Actions.default_TurnRight,
                    SteamVR_Actions.default_Crouch,
                    SteamVR_Actions.default_Stand,
                    SteamVR_Actions.default_NewAction,
                    SteamVR_Actions.platformer_Jump,
                    SteamVR_Actions.buggy_Brake,
                    SteamVR_Actions.buggy_Reset,
                    SteamVR_Actions.naoVR_Calibrate,
                    SteamVR_Actions.naoVR_CheckConstraints};
            Valve.VR.SteamVR_Input.actionsSingle = new Valve.VR.SteamVR_Action_Single[] {
                    SteamVR_Actions.buggy_Throttle};
            Valve.VR.SteamVR_Input.actionsVector2 = new Valve.VR.SteamVR_Action_Vector2[] {
                    SteamVR_Actions.platformer_Move,
                    SteamVR_Actions.buggy_Steering};
            Valve.VR.SteamVR_Input.actionsVector3 = new Valve.VR.SteamVR_Action_Vector3[0];
            Valve.VR.SteamVR_Input.actionsSkeleton = new Valve.VR.SteamVR_Action_Skeleton[] {
                    SteamVR_Actions.default_SkeletonLeftHand,
                    SteamVR_Actions.default_SkeletonRightHand};
            Valve.VR.SteamVR_Input.actionsNonPoseNonSkeletonIn = new Valve.VR.ISteamVR_Action_In[] {
                    SteamVR_Actions.default_CloseHand,
                    SteamVR_Actions.default_HeadsetOnHead,
                    SteamVR_Actions.default_Calibrate,
                    SteamVR_Actions.default_ArmDisarm,
                    SteamVR_Actions.default_WalkForward,
                    SteamVR_Actions.default_TurnLeft,
                    SteamVR_Actions.default_TurnRight,
                    SteamVR_Actions.default_Crouch,
                    SteamVR_Actions.default_Stand,
                    SteamVR_Actions.default_NewAction,
                    SteamVR_Actions.platformer_Move,
                    SteamVR_Actions.platformer_Jump,
                    SteamVR_Actions.buggy_Steering,
                    SteamVR_Actions.buggy_Throttle,
                    SteamVR_Actions.buggy_Brake,
                    SteamVR_Actions.buggy_Reset,
                    SteamVR_Actions.naoVR_Calibrate,
                    SteamVR_Actions.naoVR_CheckConstraints};
        }
        
        private static void PreInitActions()
        {
            SteamVR_Actions.p_default_Pose = ((SteamVR_Action_Pose)(SteamVR_Action.Create<SteamVR_Action_Pose>("/actions/default/in/Pose")));
            SteamVR_Actions.p_default_SkeletonLeftHand = ((SteamVR_Action_Skeleton)(SteamVR_Action.Create<SteamVR_Action_Skeleton>("/actions/default/in/SkeletonLeftHand")));
            SteamVR_Actions.p_default_SkeletonRightHand = ((SteamVR_Action_Skeleton)(SteamVR_Action.Create<SteamVR_Action_Skeleton>("/actions/default/in/SkeletonRightHand")));
            SteamVR_Actions.p_default_CloseHand = ((SteamVR_Action_Boolean)(SteamVR_Action.Create<SteamVR_Action_Boolean>("/actions/default/in/CloseHand")));
            SteamVR_Actions.p_default_HeadsetOnHead = ((SteamVR_Action_Boolean)(SteamVR_Action.Create<SteamVR_Action_Boolean>("/actions/default/in/HeadsetOnHead")));
            SteamVR_Actions.p_default_Calibrate = ((SteamVR_Action_Boolean)(SteamVR_Action.Create<SteamVR_Action_Boolean>("/actions/default/in/Calibrate")));
            SteamVR_Actions.p_default_ArmDisarm = ((SteamVR_Action_Boolean)(SteamVR_Action.Create<SteamVR_Action_Boolean>("/actions/default/in/ArmDisarm")));
            SteamVR_Actions.p_default_WalkForward = ((SteamVR_Action_Boolean)(SteamVR_Action.Create<SteamVR_Action_Boolean>("/actions/default/in/WalkForward")));
            SteamVR_Actions.p_default_TurnLeft = ((SteamVR_Action_Boolean)(SteamVR_Action.Create<SteamVR_Action_Boolean>("/actions/default/in/TurnLeft")));
            SteamVR_Actions.p_default_TurnRight = ((SteamVR_Action_Boolean)(SteamVR_Action.Create<SteamVR_Action_Boolean>("/actions/default/in/TurnRight")));
            SteamVR_Actions.p_default_Crouch = ((SteamVR_Action_Boolean)(SteamVR_Action.Create<SteamVR_Action_Boolean>("/actions/default/in/Crouch")));
            SteamVR_Actions.p_default_Stand = ((SteamVR_Action_Boolean)(SteamVR_Action.Create<SteamVR_Action_Boolean>("/actions/default/in/Stand")));
            SteamVR_Actions.p_default_NewAction = ((SteamVR_Action_Boolean)(SteamVR_Action.Create<SteamVR_Action_Boolean>("/actions/default/in/NewAction")));
            SteamVR_Actions.p_default_Haptic = ((SteamVR_Action_Vibration)(SteamVR_Action.Create<SteamVR_Action_Vibration>("/actions/default/out/Haptic")));
            SteamVR_Actions.p_platformer_Move = ((SteamVR_Action_Vector2)(SteamVR_Action.Create<SteamVR_Action_Vector2>("/actions/platformer/in/Move")));
            SteamVR_Actions.p_platformer_Jump = ((SteamVR_Action_Boolean)(SteamVR_Action.Create<SteamVR_Action_Boolean>("/actions/platformer/in/Jump")));
            SteamVR_Actions.p_buggy_Steering = ((SteamVR_Action_Vector2)(SteamVR_Action.Create<SteamVR_Action_Vector2>("/actions/buggy/in/Steering")));
            SteamVR_Actions.p_buggy_Throttle = ((SteamVR_Action_Single)(SteamVR_Action.Create<SteamVR_Action_Single>("/actions/buggy/in/Throttle")));
            SteamVR_Actions.p_buggy_Brake = ((SteamVR_Action_Boolean)(SteamVR_Action.Create<SteamVR_Action_Boolean>("/actions/buggy/in/Brake")));
            SteamVR_Actions.p_buggy_Reset = ((SteamVR_Action_Boolean)(SteamVR_Action.Create<SteamVR_Action_Boolean>("/actions/buggy/in/Reset")));
            SteamVR_Actions.p_mixedreality_ExternalCamera = ((SteamVR_Action_Pose)(SteamVR_Action.Create<SteamVR_Action_Pose>("/actions/mixedreality/in/ExternalCamera")));
            SteamVR_Actions.p_naoVR_Calibrate = ((SteamVR_Action_Boolean)(SteamVR_Action.Create<SteamVR_Action_Boolean>("/actions/NaoVR/in/Calibrate")));
            SteamVR_Actions.p_naoVR_CheckConstraints = ((SteamVR_Action_Boolean)(SteamVR_Action.Create<SteamVR_Action_Boolean>("/actions/NaoVR/in/CheckConstraints")));
        }
    }
}
