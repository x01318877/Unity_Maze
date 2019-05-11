﻿using UnityEngine;

public abstract class MazeCellEdge : MonoBehaviour {

    //connecting the cells
	public MazeCell cell, otherCell;

	public MazeDirection direction;

	public virtual void Initialize (MazeCell cell, MazeCell otherCell, MazeDirection direction) {
		this.cell = cell;
		this.otherCell = otherCell;
		this.direction = direction;
		cell.SetEdge(direction, this);
		transform.parent = cell.transform;
		transform.localPosition = Vector3.zero;
        //rotating the cell edge in right direction instead of only north side
		transform.localRotation = direction.ToRotation();
	}

	public virtual void OnPlayerEntered () {}

	public virtual void OnPlayerExited () {}
}