//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using static zfunc;

	/// <summary>
	/// Corelates a linear index (position) with a segment + offset pair 
	/// </summary>
	/// <remarks>
	/// The data satisfy the invariant pos = segment * capacity + offset, where capacity
	/// is predicated on the bit width of the parametric type specifed when the
	/// cell index is created
	/// </remarks>
	public readonly struct CellIndex
	{
		/// <summary>
		/// The container-relative 0-based storage segment
		/// </summary>
		public readonly ushort Segment;

		/// <summary>
		/// The segment-relative offset
		/// </summary>
		public readonly ushort Offset;

		/// <summary>
		/// The zero-based linear position
		/// </summary>
		public readonly uint Position;

		public static CellIndex Zero => default;
		
		/// <summary>
		/// Defines a cell index
		/// </summary>
		/// <param name="segment">The container-relative and 0-based element index</param>
		/// <param name="offset">The segment relative 0-based offset</param>
		/// <param name="capacity">The capacity of each segment</param>
		[MethodImpl(Inline)]
		public static CellIndex Define(ushort segment, ushort offset, uint pos)
			=> new CellIndex(segment, offset, pos);

		/// <summary>
		/// Defines a cell index predicated on supplied segment, offset and a parametric type from
		/// which segment capacity is calculated
		/// </summary>
		/// <param name="segment">The container-relative and 0-based element index</param>
		/// <param name="offset">The segment relative 0-based offset</param>
		/// <typeparam name="T">The type that determines segment capacity</typeparam>
		[MethodImpl(Inline)]
		public static CellIndex Define<T>(ushort segment, ushort offset)
			where T : unmanaged
				=> new CellIndex(segment, offset, CalcPosition<T>(segment, offset));

		/// <summary>
		/// Computes the prededing cell index, if nonzero; otherwise, returns 0
		/// </summary>
		/// <param name="src">The source index</param>
		/// <typeparam name="T">The type that determines segment capacity</typeparam>
		[MethodImpl(Inline)]
        public static CellIndex Prior<T>(CellIndex src)
			where T : unmanaged
        {
            if(src.Offset > 0)
                return Define<T>(src.Segment, (ushort)(src.Offset - 1));
            else if(src.Segment != 0)
				return Define<T>((ushort)(SegCapacity<T>() - 1),(ushort)( src.Segment -1));
			else 
				return Zero;
        }

		[MethodImpl(Inline)]
        public static CellIndex Next<T>(CellIndex src)
			where T : unmanaged
        {
            if(src.Offset < SegCapacity<T>() - 1)
                return Define<T>(src.Segment, (ushort)(src.Offset + 1));
            else
				return Define<T>(0,(ushort)(src.Segment + 1));
        }

		[MethodImpl(Inline)]
		public static bool operator ==(CellIndex lhs, CellIndex rhs)
			=> lhs.Equals(rhs);

		[MethodImpl(Inline)]
		public static bool operator !=(CellIndex lhs, CellIndex rhs)
			=> !lhs.Equals(rhs);

		[MethodImpl(Inline)]
		public static bool operator <(CellIndex lhs, CellIndex rhs)		
			=> lhs.Position < rhs.Position;		

		[MethodImpl(Inline)]
		public static bool operator <=(CellIndex lhs, CellIndex rhs)
			=> lhs.Position <= rhs.Position;

		[MethodImpl(Inline)]
		public static bool operator >(CellIndex lhs, CellIndex rhs)
			=> lhs.Position > rhs.Position;

		[MethodImpl(Inline)]
		public static bool operator >=(CellIndex lhs, CellIndex rhs)
			=> lhs.Position >= rhs.Position;


		[MethodImpl(Inline)]
		public CellIndex(ushort segment, ushort offset, uint position)
		{
			this.Segment = segment;
			this.Offset = offset;
			this.Position = position;
		}

		[MethodImpl(Inline)]
		public int CountTo(CellIndex other)
			=>  (int)(Math.Abs(Position - other.Position) + 1);

		[MethodImpl(Inline)]
		public bool Equals(CellIndex rhs)
			=> this.Position == rhs.Position;

		public string Format()
			=> string.Format("({0},{1}:{2})", this.Position, this.Segment, this.Offset);

		public override string ToString()
			=> Format();

		public override int GetHashCode()
			=> Position.GetHashCode();

		public override bool Equals(object rhs)
            => rhs is CellIndex x && Equals(x);

		[MethodImpl(Inline)]
		static uint SegCapacity<T>() 
			where T : unmanaged
				=> bitsize<T>();			

		[MethodImpl(Inline)]
		static uint CalcPosition(ushort segment, ushort offset, uint capacity)
			=> (uint)(segment * capacity + offset - 1);

		[MethodImpl(Inline)]
		static uint CalcPosition<T>(ushort segment, ushort offset)
			where T : unmanaged
				=> CalcPosition(segment, offset, SegCapacity<T>());
	}
}