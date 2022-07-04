using System;

namespace Sandbox;

public partial class TestEntity : ModelEntity
{
	public bool SetPos { get; set; } = false;

	public override void Spawn()
	{
		SetModel( "models/test.vmdl" );
	}

	[Event.Tick]
	void tick()
	{
		SetBoneTransform( "Bone", new Transform( Vector3.Up * 50f * MathF.Abs( MathF.Sin( Time.Now * 10f ) ) ), false );

		if ( SetPos )
		{
			var pos = Position;
			Position = 0;
			Position = pos;
		}
	}
}
