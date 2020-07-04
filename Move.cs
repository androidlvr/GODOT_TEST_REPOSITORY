using Godot;
using System;

public class Move : Spatial
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";

    // Called when the node enters the scene tree for the first time.
    // public override void _Ready()
    // {
        
    // }

 // Called every frame. 'delta' is the elapsed time since the previous frame.
 public override void _Process(float delta)
 {
     var horizontal = Input.GetActionStrength("left") - Input.GetActionStrength("right");
     var vertical = Input.GetActionStrength("up") - Input.GetActionStrength("down");
     Translate(new Vector3(horizontal, 0, vertical));
 }
}
