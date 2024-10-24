using Godot;
using System;
using System.Security.AccessControl;

public partial class Slime : Node2D
{

	private RayCast2D right;

	private RayCast2D left;

	private AnimatedSprite2D sprite2D;

	private int dir = 1;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		right = GetNode<RayCast2D>("RayCastRight");
		left = GetNode<RayCast2D>("RayCastLeft");
		sprite2D = GetNode<AnimatedSprite2D>("AnimatedSprite2D");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		if (right.IsColliding())
		{
			dir = -1;
			sprite2D.FlipH = true;
		}
		if (left.IsColliding())
		{
			dir = 1;
			sprite2D.FlipH = false;
		}
		double a =  Position.X + (dir * 60.0f * delta);
		Position = new Vector2((float) a, Position.Y);
	}
}
