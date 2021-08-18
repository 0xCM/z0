//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    [ApiHost]
    public readonly struct BitPos
    {
        const NumericKind Closure = UnsignedInts;

		[MethodImpl(Inline)]
        public static ref BitPos32 add(ref BitPos32 pos, uint bitindex)
        {
            var newindex = pos.LinearIndex + bitindex;
            pos.CellIndex = linear(pos.CellWidth,newindex);
            pos.BitOffset = offset(pos.CellWidth, newindex);
            return ref pos;
        }

		[MethodImpl(Inline), Op, Closures(Closure)]
        public static ref BitPos<T> add<T>(ref BitPos<T> pos, uint bitindex)
            where T : unmanaged
        {
            var newindex = pos.LinearIndex + bitindex;
            pos.CellIndex = linear(pos.CellWidth,newindex);
            pos.BitOffset = offset(pos.CellWidth, newindex);
            return ref pos;
        }

		[MethodImpl(Inline), Op]
        public static ref BitPos32 sub(ref BitPos32 pos, uint bitindex)
        {
            var newIndex = pos.LinearIndex - bitindex;
            if(newIndex > 0)
			{
				pos.CellIndex = linear(pos.CellWidth, bitindex);
				pos.BitOffset = offset(pos.CellWidth, bitindex);
			}
            else
            {
				pos.CellIndex = 0;
				pos.BitOffset = 0;
			}

            return ref pos;
        }

		[MethodImpl(Inline), Op, Closures(Closure)]
        public static ref BitPos<T> sub<T>(ref BitPos<T> pos, uint bitindex)
            where T : unmanaged
        {
            var newIndex = pos.LinearIndex - bitindex;
            if(newIndex > 0)
			{
				pos.CellIndex = linear(pos.CellWidth, bitindex);
				pos.BitOffset = offset(pos.CellWidth, bitindex);
			}
            else
            {
				pos.CellIndex = 0;
				pos.BitOffset = 0;
			}

            return ref pos;
        }

		[MethodImpl(Inline), Op]
        public static ref BitPos32 dec(ref BitPos32 pos)
        {
            if(pos.BitOffset > 0)
                --pos.BitOffset;
            else
            {
                if(pos.CellIndex != 0)
                {
                    pos.BitOffset = pos.CellWidth - 1;
                    --pos.CellIndex;
                }
            }

            return ref pos;
        }

		[MethodImpl(Inline), Op, Closures(Closure)]
        public static ref BitPos<T> dec<T>(ref BitPos<T> pos)
            where T : unmanaged
        {
            if(pos.BitOffset > 0)
                --pos.BitOffset;
            else
            {
                if(pos.CellIndex != 0)
                {
                    pos.BitOffset = pos.CellWidth - 1;
                    --pos.CellIndex;
                }
            }

            return ref pos;
        }

		[MethodImpl(Inline), Op]
        public static ref BitPos32 inc(ref BitPos32 pos)
        {
            if(pos.BitOffset < pos.CellWidth - 1)
                pos.BitOffset++;
            else
            {
                pos.CellIndex++;
                pos.BitOffset = 0;
            }

            return ref pos;
        }

		[MethodImpl(Inline), Op, Closures(Closure)]
        public static ref BitPos<T> inc<T>(ref BitPos<T> pos)
            where T : unmanaged
        {
            if(pos.BitOffset < pos.CellWidth - 1)
                pos.BitOffset++;
            else
            {
                pos.CellIndex++;
                pos.BitOffset = 0;
            }

            return ref pos;
        }

		[MethodImpl(Inline), Op]
        public static bool eq(in BitPos32 a, in BitPos32 b)
			=> a.CellIndex == b.CellIndex
            && a.BitOffset == b.BitOffset
			&& a.CellWidth == b.CellWidth;

		[MethodImpl(Inline), Op, Closures(Closure)]
        public static bool eq<T>(in BitPos<T> a, in BitPos<T> b)
            where T : unmanaged
			=> a.CellIndex == b.CellIndex
            && a.BitOffset == b.BitOffset;

        public static string format(in BitPos32 src)
            => string.Format("({0},{1}/{2})", src.LinearIndex, src.CellIndex, src.BitOffset);

		[MethodImpl(Inline), Op, Closures(Closure)]
		public static uint count<T>(in BitPos<T> src, in BitPos<T> dst)
            where T : unmanaged
			    => (uint)math.abs((long)src.LinearIndex - (long)dst.LinearIndex) + 1;

		/// <summary>
		/// Computes the order-invariant absolute distance between two positions
		/// </summary>
		/// <param name="a">The left position</param>
		/// <param name="b">The right position</param>
		[MethodImpl(Inline), Op]
		public static uint delta(BitPos32 a, BitPos32 b)
			=> ScalarCast.uint32(core.abs((long)a.LinearIndex - (long)b.LinearIndex));

        /// <summary>
        /// Computes the cell index of a linear bit index
        /// </summary>
        /// <param name="w">The width of a storage cell</param>
        /// <param name="index">The linear bit index</param>
		[MethodImpl(Inline)]
        public static uint linear(uint w, uint index)
			=> index/w;

		/// <summary>
		/// Computes a linear bit index from a cell index and cell-relative offset
		/// </summary>
		/// <param name="w">The cell width</param>
		/// <param name="cellindex">The cell index</param>
		/// <param name="offset">The cell-relative offset of the bit</param>
		[MethodImpl(Inline), Op]
		public static uint linear(uint w, uint cellindex, uint offset)
			=> cellindex*w + offset;

		[MethodImpl(Inline), Op]
        public static uint linear(in BitPos32 src)
            => linear(src.CellWidth, src.CellIndex, src.BitOffset);

        /// <summary>
        /// Computes the offset of a linear bit index over storage cells of specified width
        /// </summary>
        /// <param name="w">The cell width</param>
        /// <param name="index">The linear bit index</param>
		[MethodImpl(Inline), Op]
        public static byte offset(uint w, uint index)
			=> ScalarCast.uint8(index % w);

		/// <summary>
		/// Defines a bit position predicated on the width of a storage cell and the 0-based linear bit index
		/// </summary>
        /// <param name="w">The storage cell width</param>
		/// <param name="index">The linear bit index</param>
		[MethodImpl(Inline), Op]
		public static BitPos32 init(uint w, uint index)
			=> new BitPos32(w, linear(w, index), offset(w, index));

		/// <summary>
		/// Defines a bit position predicated on the width and container-relative index of a storage cell and a cell-relative bit offset
		/// </summary>
        /// <param name="w">The storage cell width</param>
		/// <param name="cellindex">The container-relative cell index</param>
		/// <param name="offset">The cell-relative bit offset</param>
		[MethodImpl(Inline), Op]
		public static BitPos32 FromCellIndex(uint w, uint cellindex, uint offset)
			=> new BitPos32(w, cellindex, offset);

		/// <summary>
		/// Defines a bit position predicated on a parametric cell type and a cell-relative bit offset
		/// </summary>
		/// <param name="cellindex">The container-relative cell index</param>
		/// <param name="offset">The cell-relative bit offset</param>
		[MethodImpl(Inline), Op, Closures(Closure)]
		public static BitPos<T> FromCellIndex<T>(uint cellindex, uint offset)
			where T : unmanaged
				=> new BitPos<T>(cellindex, offset);

        /// <summary>
        /// Defines a bit position, relative to a T-valued sequence, predicated on a linear index
        /// </summary>
        /// <param name="index">The sequence-relative index of the target bit</param>
        /// <typeparam name="T">The sequence element type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static BitPos<T> position<T>(uint index)
            where T : unmanaged
				=> new BitPos<T>(linear(width<T>(), index), offset(width<T>(), index));

        /// <summary>
        /// Defines a bit position, relative to a T-valued sequence, predicated on a linear index
        /// </summary>
		/// <param name="index">The linear index</param>
        /// <param name="cell">The cell index</param>
        /// <param name="offset">The cell-relative offset</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
		public static void bitpos<T>(uint index, out uint cell, out uint offset)
            where T : unmanaged
        {
            var w = width<T>(w16);
			cell = linear(w, index);
            offset = BitPos.offset(w, index);
        }
    }
}