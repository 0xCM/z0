//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;    
    using static As;

    /// <summary>
    /// A data structure that covers and arbitrary number of 256-bit blocks of packed bits
    /// </summary>
    public readonly ref struct BitBlock<T>
        where T : unmanaged
    {
        /// <summary>
        /// The bitvector content
        /// </summary>
        readonly Block256<T> data;

        /// <summary>
        /// The actual number of bits that are represented by the vector
        /// </summary>
        public readonly int BitCount;
        
        /// <summary>
        /// The maximum number of bits that can be placed a single segment segment
        /// </summary>
        public static int CellWidth => bitsize<T>();

        [MethodImpl(Inline)]
        public static implicit operator BitBlock<T>(Span<T> src)
            => new BitBlock<T>(src, bitsize<T>());

        [MethodImpl(Inline)]
        public static implicit operator BitBlock<T>(T src)
            => new BitBlock<T>(src, bitsize<T>());

        [MethodImpl(Inline)]
        public static bit operator %(in BitBlock<T> x, in BitBlock<T> y)
            => BitBlocks.dot(x,y);

        /// <summary>
        /// Computes the bitwise complement of the operand
        /// </summary>
        /// <param name="x">The source operand</param>
        [MethodImpl(Inline)]
        public static BitBlock<T> operator ~(in BitBlock<T> src)
            => default;

        /// <summary>
        /// Returns true if the source vector is nonzero, false otherwise
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static bool operator true(in BitBlock<T> src)
            => src.NonEmpty;

        /// <summary>
        /// Returns false if the source vector is the zero vector, false otherwise
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static bool operator false(in BitBlock<T> src)
            => !src.NonEmpty;

        [MethodImpl(Inline)]
        public static bool operator ==(in BitBlock<T> x, in BitBlock<T> y)
            => x.Equals(y);

        [MethodImpl(Inline)]
        public static bool operator !=(in BitBlock<T> x, in BitBlock<T> y)
            => !x.Equals(y);

        [MethodImpl(Inline)]
        internal BitBlock(T src, int bitcount)
        {            
            this.data = DataBlocks.single<T>(n256);
            head(data) = src;
            this.BitCount = bitcount;
        }

        [MethodImpl(Inline)]
        internal BitBlock(Span<T> src, int n)
        {            
            this.data = DataBlocks.safeload(n256,src);
            this.BitCount = n;
        }

        [MethodImpl(Inline)]
        internal BitBlock(Block256<T> src)
        {            
            this.data = src;
            this.BitCount = src.BlockCount * 256;
        }

        /// <summary>
        /// The underlying cell data
        /// </summary>
        public Span<T> Data
        {
            [MethodImpl(Inline)]
            get => data;
        }

        /// <summary>
        /// Specifies a reference to the leading cell
        /// </summary>
        public ref T Head
        {
            [MethodImpl(Inline)]
            get => ref data.Head;
        }

        /// <summary>
        /// Presents the represented data as a span of bytes
        /// </summary>
        public readonly Span<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => data.Bytes;
        }

        /// <summary>
        /// Is true if no bits are enabled, false otherwise
        /// </summary>
        public bit IsEmpty
        {
            [MethodImpl(Inline)]
            get => Pop() == 0;
        }

        /// <summary>
        /// Is true if at least one enabled bit; false otherwise
        /// </summary>
        public readonly bit NonEmpty
        {
            [MethodImpl(Inline)]
            get => Pop() != 0;
        }

        /// <summary>
        /// The number of allocated blocks
        /// </summary>
        public int BlockCount
        {
            [MethodImpl(Inline)]
            get => data.BlockCount;
        }

        /// <summary>
        /// The number of allocated cells
        /// </summary>
        public int CellCount
        {
            [MethodImpl(Inline)]
            get => data.CellCount;
        }

        /// <summary>
        /// Gets the mapped bit location
        /// </summary>
        /// <param name="index">The bit position</param>
        [MethodImpl(Inline)]
        public readonly BitPos<T> Pos(int index)
            => BitPos.FromBitIndex<T>((uint)index);

        /// <summary>
        /// A bit-level accessor/manipulator
        /// </summary>
        public bit this[int index]
        {
            [MethodImpl(Inline)]
            get 
            {
                var loc = Pos(index);
                return BitMask.testbit(data[loc.CellIndex], loc.BitOffset);
            }
            
            [MethodImpl(Inline)]
            set
            {
                var loc = Pos(index);
                data[loc.CellIndex] = gbits.set(data[loc.CellIndex], (byte)loc.BitOffset, value);
            }
        }

        /// <summary>
        /// Retrieves, at most, one cell's worth of bits defined by an inclusive bit index range
        /// </summary>
        /// <param name="first">The linear index of the first bit</param>
        /// <param name="last">The linear index of the last bit</param>
        [MethodImpl(Inline)]
        public T Slice(int first, int last)
            => Extract(Pos(first), Pos(last));

        /// <summary>
        /// Retrieves, at most, one cell's worth of bits defined by an inclusive bit index range
        /// </summary>
        /// <param name="first">The linear index of the first bit</param>
        /// <param name="last">The linear index of the last bit</param>
        public T this[int first, int last]
        {
            [MethodImpl(Inline)]
            get => Slice(first,last);
        }

        /// <summary>
        /// Extracts the represented data as a bitstring
        /// </summary>
        [MethodImpl(Inline)]
        public readonly BitString ToBitString()
            => BitString.scalars<T>(data, BitCount); 

        /// <summary>
        /// Counts the enabled bits
        /// </summary>
        [MethodImpl(Inline)]
        public readonly uint Pop()
        {
            var count = 0u;
            for(var i=0; i< data.CellCount; i++)
                count += gbits.pop(data[i]);
            return count;
        }

        /// <summary>
        /// Counts the number of bits set up to and including an index-identified bit
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="index">The 0-based linear bit index</param>
        public uint Pop(int index)
        {
            var rank = 0u;
            var segments = Cells(index);
            for(var i=0; i < segments.Length; i++)
                rank += (uint)gbits.pop(segments[i]);            
            return rank;
        }

        /// <summary>
        /// Returns a reference to the cell in which a specified bit is defined
        /// </summary>
        /// <param name="pos">The segmented bit position</param>
        [MethodImpl(Inline)]
        public ref T Cell(BitPos<T> pos)
            => ref data[pos.CellIndex];

        /// <summary>
        /// Retrieves the cells up to and including an index-identified bit
        /// </summary>
        /// <param name="index">The bit position</param>
        [MethodImpl(Inline)]
        public readonly Span<T> Cells(int index)
            => data.Slice(0, Pos(index).CellIndex - 1);

        [MethodImpl(Inline)]
        T Extract(BitPos<T> first, BitPos<T> last)
        {
            var wantedCount = last - first;
            if(wantedCount > CellWidth)
                return gmath.maxval<T>();

            var sameSeg = first.CellIndex == last.CellIndex;
            var firstCount = uint8(sameSeg ? wantedCount : CellWidth - first.BitOffset);
            var lastCount = uint8(wantedCount - firstCount);
            var part1 = gbits.bitslice(Cell(first), (byte)first.BitOffset, firstCount);
            
            if(sameSeg)
                return part1;

            var part2 = gmath.sal(gbits.bitslice(Cell(last), 0, lastCount), firstCount);
            return gmath.or(part1, part2);              
        }

        public BitBlock<T> Replicate()
            => new BitBlock<T>(data.Replicate());
                    
        [MethodImpl(Inline)]
        public bool Equals(in BitBlock<T> y)
            => data.Identical(y.data);

        [MethodImpl(Inline)]
        public string Format(BitFormat? fmt = null)
            => ToBitString().Format(fmt);

        public override bool Equals(object obj)
            => throw new NotImplementedException();
        
        public override int GetHashCode()
            => throw new NotImplementedException();
    
        public override string ToString()
            => throw new NotImplementedException();
    }
}
