//-----------------------------------------------------------------------------
// Taken from Iced:https://github.com/0xd4d/iced
// License: See the accompanying license file
//-----------------------------------------------------------------------------
namespace Z0.AsmSpecs 
{
	/// <summary>
	/// Memory operand
	/// </summary>
	public readonly struct MemoryOperand 
    {
		/// <summary>
		/// Segment override or <see cref="Register.None"/>
		/// </summary>
		public readonly Register SegmentPrefix;

		/// <summary>
		/// Base register or <see cref="Register.None"/>
		/// </summary>
		public readonly Register Base;

		/// <summary>
		/// Index register or <see cref="Register.None"/>
		/// </summary>
		public readonly Register Index;

		/// <summary>
		/// Index register scale (1, 2, 4, or 8)
		/// </summary>
		public readonly int Scale;

		/// <summary>
		/// Memory displacement
		/// </summary>
		public readonly int Displacement;

		/// <summary>
		/// 0 (no displ), 1 (16/32/64-bit, but use 2/4/8 if it doesn't fit in a <see cref="sbyte"/>), 2 (16-bit), 4 (32-bit) or 8 (64-bit)
		/// </summary>
		public readonly int DisplSize;

		/// <summary>
		/// true if it's broadcasted memory (EVEX instructions)
		/// </summary>
		public readonly bool IsBroadcast;

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="base">Base register or <see cref="Register.None"/></param>
		/// <param name="index">Index register or <see cref="Register.None"/></param>
		/// <param name="scale">Index register scale (1, 2, 4, or 8)</param>
		/// <param name="displacement">Memory displacement</param>
		/// <param name="displSize">0 (no displ), 1 (16/32/64-bit, but use 2/4/8 if it doesn't fit in a <see cref="sbyte"/>), 2 (16-bit), 4 (32-bit) or 8 (64-bit)</param>
		/// <param name="isBroadcast">true if it's broadcasted memory (EVEX instructions)</param>
		/// <param name="prefixSegment">Segment override or <see cref="Register.None"/></param>
		public MemoryOperand(Register @base, Register index, int scale, int displacement, int displSize, bool isBroadcast, Register prefixSegment) {
			SegmentPrefix = prefixSegment;
			Base = @base;
			Index = index;
			Scale = scale;
			Displacement = displacement;
			DisplSize = displSize;
			IsBroadcast = isBroadcast;
		}

	}
}
