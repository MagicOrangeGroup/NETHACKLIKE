using Godot;
using System;

public partial class DefeatWindow : CanvasLayer, IUi
{
    public void Initialize()
    {
        this.GetUnique<Player>().DiedForSure += () => Visible = true;
    }

    public void Update()
    {
    }
}
