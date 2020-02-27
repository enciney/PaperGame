using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperGame
{
	// Each enumaration must have one Unknown or Undefined member because maybe it can be  usable without initialization at some code blocks
	// And then can add a check for value and we can easily understand that this object was not initialize
	public enum Corner
	{
		Unknown = -1,
		LeftUp = 0,
		LeftDown = 1,
		RightUp = 2,
		RightDown = 3
	}
}
