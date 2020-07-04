using Godot;
using System;

public class MoveMesh : Spatial
{
    // Declare member variables here. Examples:
    [Export]private float speed = 2;
    [Export]public NodePath targetPath;
   // private Node target;

    private Spatial target;
    // private string b = "text";

     public override void _Ready()=>
         target = GetNode(targetPath) as Spatial;
     
   
    

    public override void _Process(float delta)
    {
     //   target = GetNode(targetPath);
        //Transform transform = 
      //  Transform.SetLookAt(Transform.basis.z, (target as Spatial).Transform.origin, Vector3.Up);
     // Transform transform = Transform.LookingAt((target as Spatial).Transform.origin, Vector3.Up);
      Transform = Transform.LookingAt(target.Transform.origin, Vector3.Up);
   //   RotationDegrees = ;
     //   Transform.LookingAt((target as Spatial).Transform.origin, Vector3.Up)
      //  TranslateObjectLocal(Transform.basis.z * speed * delta);
     //   RotateY(Mathf.Deg2Rad(45 * delta));

    }

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}
