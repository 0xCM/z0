//-----------------------------------------------------------------------------
// Taken from dnlib:https://github.com/0xd4d/dnlib
// License: See the accompanying license file
//-----------------------------------------------------------------------------
namespace Z0.CilSpecs
{        
	/// <summary>
	/// CIL opcode flow control
	/// </summary>
	public enum FlowControl {
		/// <summary/>
		Branch,
		/// <summary/>
		Break,
		/// <summary/>
		Call,
		/// <summary/>
		Cond_Branch,
		/// <summary/>
		Meta,
		/// <summary/>
		Next,
		/// <summary/>
		Phi,
		/// <summary/>
		Return,
		/// <summary/>
		Throw,
	}


}