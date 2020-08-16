using Godot;
using System;

public class Player : KinematicBody
{
	// Declare member variables here. Examples:
	// private int a = 2;
	// private string b = "text";
	const int SPEED=30;
	private Vector3 velocity;
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		velocity = new Vector3(0, 0, 0);
	}

	public override void _PhysicsProcess(float delta)
	{

		if (Input.IsActionJustPressed("ui_right") && (Input.IsActionJustPressed("ui_left")))
			velocity.x = 0;
		else if (Input.IsActionJustPressed("ui_right"))
			velocity.x = SPEED;
		else if (Input.IsActionJustPressed("ui_left"))
			velocity.x = -SPEED;
		else
			velocity.x = Godot.Mathf.Lerp(velocity.x, 0, 0.01f);

		if (Input.IsActionJustPressed("ui_up") && (Input.IsActionJustPressed("ui_down")))
			velocity.z = 0;
		else if (Input.IsActionJustPressed("ui_up"))
			velocity.z = -SPEED;
		else if (Input.IsActionJustPressed("ui_down"))
			velocity.z = SPEED;
		else
			velocity.z = Godot.Mathf.Lerp(velocity.z, 0, 0.01f);

		MoveAndSlide(velocity);
		base._PhysicsProcess(delta);
	}
	//  // Called every frame. 'delta' is the elapsed time since the previous frame.
	//  public override void _Process(float delta)
	//  {
	//      
	//  }
}
