using Sandbox;

namespace Lunar
{

	partial class LunarPlayer : SandboxPlayer
	{
		public LunarPlayer()
		{
		}

		public override void Respawn()
		{
			base.Respawn();

			Controller = new LunarController();
		}

	}
}