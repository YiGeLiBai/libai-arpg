using Godot;
using System;

public partial class KillZone : Area2D
{

	private Timer timer;

    public override void _Ready()
    {
        base._Ready();
		timer = GetNode<Timer>("Timer");
    }

    public void KillZoneTouched(Node2D body)
	{
		GD.Print("You Died!");
		Engine.TimeScale = 0.5f;
		timer.Start();
	}

	public void OnTimerOut() 
	{
		GD.Print("Over!");
		Engine.TimeScale = 1;
		GetTree().ReloadCurrentScene();
	}
}
