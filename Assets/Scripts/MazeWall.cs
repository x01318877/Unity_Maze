using UnityEngine;

//only use these types and never creat an instance of the generic MazeCellEdge, mark as abstract
//1 of the 2 types of the cell edge

public class MazeWall : MazeCellEdge {

	public Transform wall;

	public override void Initialize (MazeCell cell, MazeCell otherCell, MazeDirection direction) {
		base.Initialize (cell, otherCell, direction);
		wall.GetComponent<Renderer>().material = cell.room.settings.wallMaterial;
	}
}