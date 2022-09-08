using Sandbox;

namespace Lunar
{
	partial class LunarController : WalkController
	{
        
		public LunarController()
		{
            SprintSpeed = LunarConfig.LunarPlayerSprintSpeed;
            DefaultSpeed = LunarConfig.LunarPlayerMovementSpeed;
            WalkSpeed = LunarConfig.LunarPlayerWalkSpeed;
            Acceleration = LunarConfig.LunarPlayerAcceleration;
            AirAcceleration = LunarConfig.LunarPlayerAirAcceleration;
            GroundFriction = LunarConfig.LunarPlayerGroundFiction;
            StopSpeed = LunarConfig.LunarPlayerStopSpeed;
            Size = LunarConfig.LunarPlayerSize;
            MoveFriction = LunarConfig.LunarPlayerMoveFriction;
            StepSize = LunarConfig.LunarPlayerStepSize;
            MaxNonJumpVelocity = LunarConfig.LunarPlayerMaxNonJumpVelocity;
            Gravity = LunarConfig.LunarPlayerGravity;
            AutoJump = LunarConfig.LunarPlayerAutoJump;
		}
	}


}