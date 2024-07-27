using Godot;
using System;

public partial class scrit2 : Sprite2D
{
	public float RotationSpeed { get; protected set; } = 0.04f;
	private Random random;

	public scrit2()
	{
		random = new Random();
		GD.Print("111");
	}

	public override void _Process(double delta)
	{
		Scale = new Vector2(1, 1);
		Rotation += RotationSpeed;
	}
}
