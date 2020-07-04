using Godot;
using System;

//[Tool]
public class TEST_AnimationPlayer : Spatial
{
    [Export]
    public PackedScene packedScene;
    [Export]
    public NodePath nodePath;


    [Signal]
    public delegate void A_NEW_SIGNAL();

    
    public int currentAnim;

    public override void _Ready()
    {
        CallDeferred("TARGETCALL");
    //    OS.DelayMsec(3000);
    //    TARGETCALL();
        AddUserSignal("SIGNAL_MORE");
        Connect("SIGNAL_MORE", this, "NEWTARGET");
        EmitSignal("SIGNAL_MORE");
    }

    public void NEWTARGET(){
        GD.Print("NEW TARGET CALLED");
    }
    

    public void TARGETCALL()
    {
    var root = packedScene.Instance();
        var sceneTree = GetTree();
        // sceneTree.CurrentScene.Free();
        // sceneTree.CurrentScene = null;
        sceneTree.Root.AddChild(root);
     //   sceneTree.CurrentScene = root;
    //    Play(GetAnimationList()[0]);

    }
    public void _on_AnimationPlayer_animation_finished(string finishedClip)
    {
        // ++currentAnim;

        // if(currentAnim >= GetAnimationList().Length)
        //     currentAnim = 0;

        //  Play(GetAnimationList()[currentAnim]);
    }

    // public System.Collections.Generic.IEnumerator<AnimationPlayer> GoThroughAnimations()
    // {
    //     foreach(var anim in GetAnimationList())
    //     {
    //         Play(anim);
    //         while (IsPlaying())
    //         {
    //             yield return null;
    //            // await return null;
    //         }
    //       //  if(IsPlaying)
    //     }
    // }


//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//
//  }
}
