//use to show up the custom size in inspector
[System.Serializable]
//use to add coordinates to MazeCell
public struct IntVector2 {
    
    //use int instead of float,create new structure
	public int x, z;

    //x,z two bundles together as a single value
	public IntVector2 (int x, int z) {
		this.x = x;
		this.z = z;
	}

    //a is changed in the operations
	public static IntVector2 operator + (IntVector2 a, IntVector2 b) {
		a.x += b.x;
		a.z += b.z;
		return a;
	}
}