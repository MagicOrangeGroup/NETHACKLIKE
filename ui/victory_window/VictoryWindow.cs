using Godot;
using System;

public partial class VictoryWindow : CanvasLayer, IUi
{
    public void Initialize()
    {
        var enemyContainer = this.GetUnique<Node>("%EnemyContainer");
        foreach (Enemy enemy in enemyContainer.GetChildren())
        {
            if(enemy.CharacterData.Name == "骷髅王")
            {
                enemy.SkeletonKingDied += () => Visible = true;
            }
        }

    }

    public void Update()
    {
    }
}
