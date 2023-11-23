using Godot;
using System;

public partial class CardManagement : Node
{
	private bool isFlipped = false; // Declare bool to check if the card is flipped
	private Control backChild;
	
	// on ready, set the action of pressing to a custom function?
	public override void _Ready()
	{
		backChild = GetNode<Control>("Back");
	}

	private void _on_button_pressed()
	{
		HideBackChild();
			// check if isflipped not true
					// flipp the card
					// check if it is match
	}
	
	private void HideBackChild()
	{
		if (backChild != null)
		{
			backChild.Hide();
		}
		else
		{
			GD.PrintErr("Back Child not found");
		}
	}
	

}
