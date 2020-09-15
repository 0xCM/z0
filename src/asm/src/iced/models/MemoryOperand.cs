//-----------------------------------------------------------------------------
// Taken from Iced:https://github.com/0xd4d/iced
// License: See the accompanying license file
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
	/// <summary>
	/// Memory operand
	/// </summary>
	public readonly struct MemoryOperand
    {
		/// <summary>
		/// Segment override or <see cref="IceRegister.None"/>
		/// </summary>
		public readonly IceRegister SegmentPrefix;

		/// <summary>
		/// Base register or <see cref="IceRegister.None"/>
		/// </summary>
		public readonly IceRegister Base;

		/// <summary>
		/// Index register or <see cref="IceRegister.None"/>
		/// </summary>
		public readonly IceRegister Index;

		/// <summary>
		/// Index register scale (1, 2, 4, or 8)
		/// </summary>
		public readonly MemoryScale Scale;

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
		/// <param name="base">Base register or <see cref="IceRegister.None"/></param>
		/// <param name="index">Index register or <see cref="IceRegister.None"/></param>
		/// <param name="scale">Index register scale (1, 2, 4, or 8)</param>
		/// <param name="displacement">Memory displacement</param>
		/// <param name="displSize">0 (no displ), 1 (16/32/64-bit, but use 2/4/8 if it doesn't fit in a <see cref="sbyte"/>), 2 (16-bit), 4 (32-bit) or 8 (64-bit)</param>
		/// <param name="isBroadcast">true if it's broadcasted memory (EVEX instructions)</param>
		/// <param name="prefixSegment">Segment override or <see cref="IceRegister.None"/></param>
		public MemoryOperand(IceRegister @base, IceRegister index, int scale, int displacement, int displSize, bool isBroadcast, IceRegister prefixSegment) {
			SegmentPrefix = prefixSegment;
			Base = @base;
			Index = index;
			Scale = scale;
			Displacement = displacement;
			DisplSize = displSize;
			IsBroadcast = isBroadcast;
		}

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="base">Base register or <see cref="IceRegister.None"/></param>
		/// <param name="index">Index register or <see cref="IceRegister.None"/></param>
		/// <param name="scale">Index register scale (1, 2, 4, or 8)</param>
		/// <param name="isBroadcast">true if it's broadcasted memory (EVEX instructions)</param>
		/// <param name="prefixSegment">Segment override or <see cref="IceRegister.None"/></param>
		public MemoryOperand(IceRegister @base, IceRegister index, int scale, bool isBroadcast, IceRegister prefixSegment) {
			SegmentPrefix = prefixSegment;
			Base = @base;
			Index = index;
			Scale = scale;
			Displacement = 0;
			DisplSize = 0;
			IsBroadcast = isBroadcast;
		}

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="base">Base register or <see cref="IceRegister.None"/></param>
		/// <param name="displacement">Memory displacement</param>
		/// <param name="displSize">0 (no displ), 1 (16/32/64-bit, but use 2/4/8 if it doesn't fit in a <see cref="sbyte"/>), 2 (16-bit), 4 (32-bit) or 8 (64-bit)</param>
		/// <param name="isBroadcast">true if it's broadcasted memory (EVEX instructions)</param>
		/// <param name="prefixSegment">Segment override or <see cref="IceRegister.None"/></param>
		public MemoryOperand(IceRegister @base, int displacement, int displSize, bool isBroadcast, IceRegister prefixSegment) {
			SegmentPrefix = prefixSegment;
			Base = @base;
			Index = IceRegister.None;
			Scale = 1;
			Displacement = displacement;
			DisplSize = displSize;
			IsBroadcast = isBroadcast;
		}

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="index">Index register or <see cref="IceRegister.None"/></param>
		/// <param name="scale">Index register scale (1, 2, 4, or 8)</param>
		/// <param name="displacement">Memory displacement</param>
		/// <param name="displSize">0 (no displ), 1 (16/32/64-bit, but use 2/4/8 if it doesn't fit in a <see cref="sbyte"/>), 2 (16-bit), 4 (32-bit) or 8 (64-bit)</param>
		/// <param name="isBroadcast">true if it's broadcasted memory (EVEX instructions)</param>
		/// <param name="prefixSegment">Segment override or <see cref="IceRegister.None"/></param>
		public MemoryOperand(IceRegister index, int scale, int displacement, int displSize, bool isBroadcast, IceRegister prefixSegment) {
			SegmentPrefix = prefixSegment;
			Base = IceRegister.None;
			Index = index;
			Scale = scale;
			Displacement = displacement;
			DisplSize = displSize;
			IsBroadcast = isBroadcast;
		}

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="base">Base register or <see cref="IceRegister.None"/></param>
		/// <param name="displacement">Memory displacement</param>
		/// <param name="isBroadcast">true if it's broadcasted memory (EVEX instructions)</param>
		/// <param name="prefixSegment">Segment override or <see cref="IceRegister.None"/></param>
		public MemoryOperand(IceRegister @base, int displacement, bool isBroadcast, IceRegister prefixSegment) {
			SegmentPrefix = prefixSegment;
			Base = @base;
			Index = IceRegister.None;
			Scale = 1;
			Displacement = displacement;
			DisplSize = 1;
			IsBroadcast = isBroadcast;
		}

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="base">Base register or <see cref="IceRegister.None"/></param>
		/// <param name="index">Index register or <see cref="IceRegister.None"/></param>
		/// <param name="scale">Index register scale (1, 2, 4, or 8)</param>
		/// <param name="displacement">Memory displacement</param>
		/// <param name="displSize">0 (no displ), 1 (16/32/64-bit, but use 2/4/8 if it doesn't fit in a <see cref="sbyte"/>), 2 (16-bit), 4 (32-bit) or 8 (64-bit)</param>
		public MemoryOperand(IceRegister @base, IceRegister index, int scale, int displacement, int displSize) {
			SegmentPrefix = IceRegister.None;
			Base = @base;
			Index = index;
			Scale = scale;
			Displacement = displacement;
			DisplSize = displSize;
			IsBroadcast = false;
		}

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="base">Base register or <see cref="IceRegister.None"/></param>
		/// <param name="index">Index register or <see cref="IceRegister.None"/></param>
		/// <param name="scale">Index register scale (1, 2, 4, or 8)</param>
		public MemoryOperand(IceRegister @base, IceRegister index, int scale) {
			SegmentPrefix = IceRegister.None;
			Base = @base;
			Index = index;
			Scale = scale;
			Displacement = 0;
			DisplSize = 0;
			IsBroadcast = false;
		}

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="base">Base register or <see cref="IceRegister.None"/></param>
		/// <param name="displacement">Memory displacement</param>
		/// <param name="displSize">0 (no displ), 1 (16/32/64-bit, but use 2/4/8 if it doesn't fit in a <see cref="sbyte"/>), 2 (16-bit), 4 (32-bit) or 8 (64-bit)</param>
		public MemoryOperand(IceRegister @base, int displacement, int displSize) {
			SegmentPrefix = IceRegister.None;
			Base = @base;
			Index = IceRegister.None;
			Scale = 1;
			Displacement = displacement;
			DisplSize = displSize;
			IsBroadcast = false;
		}

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="index">Index register or <see cref="IceRegister.None"/></param>
		/// <param name="scale">Index register scale (1, 2, 4, or 8)</param>
		/// <param name="displacement">Memory displacement</param>
		/// <param name="displSize">0 (no displ), 1 (16/32/64-bit, but use 2/4/8 if it doesn't fit in a <see cref="sbyte"/>), 2 (16-bit), 4 (32-bit) or 8 (64-bit)</param>
		public MemoryOperand(IceRegister index, int scale, int displacement, int displSize) {
			SegmentPrefix = IceRegister.None;
			Base = IceRegister.None;
			Index = index;
			Scale = scale;
			Displacement = displacement;
			DisplSize = displSize;
			IsBroadcast = false;
		}

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="base">Base register or <see cref="IceRegister.None"/></param>
		/// <param name="displacement">Memory displacement</param>
		public MemoryOperand(IceRegister @base, int displacement) {
			SegmentPrefix = IceRegister.None;
			Base = @base;
			Index = IceRegister.None;
			Scale = 1;
			Displacement = displacement;
			DisplSize = 1;
			IsBroadcast = false;
		}

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="base">Base register or <see cref="IceRegister.None"/></param>
		public MemoryOperand(IceRegister @base) {
			SegmentPrefix = IceRegister.None;
			Base = @base;
			Index = IceRegister.None;
			Scale = 1;
			Displacement = 0;
			DisplSize = 0;
			IsBroadcast = false;
		}

	}
}
