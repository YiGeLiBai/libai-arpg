using Godot;
using System;

public partial class GameManager : Node
{

	private int score = 0;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	public void AddPoint(int points)
	{
		score += points;
		GD.Print(score);
	}
}
