﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace TetrisLibrary
{
	/// <summary>
	/// Represents S Tetris shape.
	/// </summary>
	public class ShapeS : Shape
	{
		/// <summary>
		/// Instantiates ShapeS.
		/// </summary>
		/// <param name="board">The board where the ShapeS should be created.</param>
		public ShapeS(IBoard board) : base(board, setBlocks(board), setOffsets())
		{ }

		//Creates the blocks for ShapeS with green colour and pivot block starting at (6,0)
		private static Block[] setBlocks(IBoard board)
		{
			Block[] blocks = new Block[4];
			blocks[0] = new Block(board, Color.Chartreuse, new Point(6, 0));
			blocks[1] = new Block(board, Color.Chartreuse, new Point(7, 0));
			blocks[2] = new Block(board, Color.Chartreuse, new Point(5, 1));
			blocks[3] = new Block(board, Color.Chartreuse, new Point(6, 1));
			return blocks;
		}

		//Creates offsets for each block used for rotation.
		//Since ShapeS has 2 rotating positions, offset values are the opposites of each other for every rotation.
		private static Point[][] setOffsets()
		{
			Point[][] offsets = new Point[2][];
			offsets[0] = new Point[4] {new Point(0,0), new Point(-1,-1), new Point(2,0), new Point(1,-1)};
			offsets[1] = new Point[4];
			for (int i = 0; i < 4; i++)
				offsets[1][i] = new Point(-offsets[0][i].X, -offsets[0][i].Y);
			return offsets;
		}
	}
}
