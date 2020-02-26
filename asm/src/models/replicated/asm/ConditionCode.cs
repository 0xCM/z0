//-----------------------------------------------------------------------------
// Taken from Iced:https://github.com/0xd4d/iced
// License: See the accompanying license file
//-----------------------------------------------------------------------------
namespace Z0.Asm 
{
	/// <summary>
	/// Instruction condition code (used by jcc, setcc, cmovcc)
	/// </summary>
	public enum ConditionCode 
    {
		/// <summary>
		/// The instruction doesn't have a condition code
		/// </summary>
		None,

		/// <summary>
		/// Overflow (OF=1)
		/// </summary>
		o,

		/// <summary>
		/// Not overflow (OF=0)
		/// </summary>
		no,

		/// <summary>
		/// Below (unsigned) (CF=1)
		/// </summary>
		b,

		/// <summary>
		/// Above or equal (unsigned) (CF=0)
		/// </summary>
		ae,

		/// <summary>
		/// Equal / zero (ZF=1)
		/// </summary>
		e,

		/// <summary>
		/// Not equal / zero (ZF=0)
		/// </summary>
		ne,

		/// <summary>
		/// Below or equal (unsigned) (CF=1 or ZF=1)
		/// </summary>
		be,

		/// <summary>
		/// Above (unsigned) (CF=0 and ZF=0)
		/// </summary>
		a,

		/// <summary>
		/// Signed (SF=1)
		/// </summary>
		s,

		/// <summary>
		/// Not signed (SF=0)
		/// </summary>
		ns,

		/// <summary>
		/// Parity (PF=1)
		/// </summary>
		p,

		/// <summary>
		/// Not parity (PF=0)
		/// </summary>
		np,

		/// <summary>
		/// Less (signed) (SF!=OF)
		/// </summary>
		l,

		/// <summary>
		/// Greater than or equal (signed) (SF=OF)
		/// </summary>
		ge,

		/// <summary>
		/// Less than or equal (signed) (ZF=1 or SF!=OF)
		/// </summary>
		le,

		/// <summary>
		/// Greater (signed) (ZF=0 and SF=OF)
		/// </summary>
		g,
	}
}

