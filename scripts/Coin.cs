using Godot;
using System;

public partial class Coin : Area2D
{

	private GameManager gameManager;

    public override void _Ready()
    {
        base._Ready();
		gameManager = GetNode<GameManager>("%GameManager");
		GD.Print(gameManager);
		// manager = gameManager.GetScript().As<GameManager>();
    }

    public void OnTouchCoin(Node2D body) 
	{
		GD.Print("+1 Coin!");
		gameManager.AddPoint(1);
		QueueFree();
	}
}
