using fs;
using Godot;
using System;

public partial class w_HelloFS : Node2D {
	public override void _Ready()
	{
		HelloFS.ready();
	}
}
