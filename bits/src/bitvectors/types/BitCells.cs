//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;    

    public readonly ref struct BitCells<T>
        where T : unmanaged
    {
        /// <summary>
        /// The bitvector content, indexed via a bitmap
        /// </summary>
        readonly Block256<T> data;
    
        /// <summary>
        /// Correlates linear bit positions and storage segments
        /// </summary>
        readonly BitCellIndex<T>[] BitMap;

        /// <summary>
        /// The maximum number of bits that can be represented by the vector
        /// </summary>
        readonly int MaxBitCount;

        /// <summary>
        /// The actual number of bits that are represented by the vector
        /// </summary>
        readonly int BitCount;

        /// <summary>
        /// The number of bits represented by a segment, save the last
        /// </summary>
        readonly int SegLength;
        
        /// <summary>
        /// The maximum number of bits that can be placed a single segment segment
        /// </summary>
        public static int CellCapacity => bitsize<T>();

        public static BitCells<T> Zero => new BitCells<T>(DataBlocks.alloc<T>(n256));

        /// <summary>
        /// Creates a bitvector defined by a single cell or portion thereof
        /// </summary>
        /// <param name="src">The source cell</param>
        [MethodImpl(Inline)]
        public static BitCells<T> FromCell(T src, int n)
            => new BitCells<T>(src,n);
        /// <summary>
        /// Loads an bitvector of minimal size from a source bitstring
        /// </summary>
        /// <param name="src">The bitstring source</param>
        [MethodImpl(Inline)]
        public static BitCells<T> From(BitString src)
            => BitCells.loadbytes<T>(src.ToPackedBytes(), src.Length);

        [MethodImpl(Inline)]
        public static implicit operator BitCells<T>(Span<T> src)
            => new BitCells<T>(src, bitsize<T>());

        [MethodImpl(Inline)]
        public static implicit operator BitCells<T>(T src)
            => new BitCells<T>(src, bitsize<T>());

        /// <summary>
        /// Computes the bitwias AND between the operands
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static BitCells<T> operator &(in BitCells<T> x, in BitCells<T> y)
            => Zero;

        /// <summary>
        /// Computes the bitwias AND between the operands
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static BitCells<T> operator |(in BitCells<T> x, in BitCells<T> y)
            => Zero;

        /// <summary>
        /// Computes the bitwise XOR between the operands
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static BitCells<T> operator ^(in BitCells<T> x, in BitCells<T> y)
            => Zero;

        [MethodImpl(Inline)]
        public static bit operator %(in BitCells<T> x, in BitCells<T> y)
            => BitCells.dot(x,y);

        /// <summary>
        /// Computes the bitwise complement of the operand
        /// </summary>
        /// <param name="x">The source operand</param>
        [MethodImpl(Inline)]
        public static BitCells<T> operator ~(in BitCells<T> src)
            => default;

        /// <summary>
        /// Returns true if the source vector is nonzero, false otherwise
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static bool operator true(in BitCells<T> src)
            => src.Nonempty;

        /// <summary>
        /// Returns false if the source vector is the zero vector, false otherwise
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static bool operator false(in BitCells<T> src)
            => !src.Nonempty;

        [MethodImpl(Inline)]
        public static bool operator ==(in BitCells<T> x, in BitCells<T> y)
            => x.Equals(y);

        [MethodImpl(Inline)]
        public static bool operator !=(in BitCells<T> x, in BitCells<T> y)
            => !x.Equals(y);

        [MethodImpl(Inline)]
        internal BitCells(T src, int n)
        {            
            this.data = DataBlocks.alloc<T>(n256);
            head(this.data) = src;
            this.MaxBitCount = CellCapacity;
            this.SegLength = MaxBitCount;
            this.BitCount = n;
            this.BitMap = BitSize.BitMap<T>(MaxBitCount);
        }

        [MethodImpl(Inline)]
        internal BitCells(Span<T> src, int n)
        {            
            this.data = DataBlocks.safeload(n256,src);
            this.MaxBitCount = src.Length * CellCapacity;
            this.BitCount = n;
            this.SegLength = BitSize.Segments<T>(MaxBitCount);            
            this.BitMap = BitSize.BitMap<T>(MaxBitCount);
        }

        [MethodImpl(Inline)]
        internal BitCells(Block256<T> src)
        {            
            this.data = src;
            this.MaxBitCount = src.Length * CellCapacity;
            this.BitCount = src.BlockCount * 256;
            this.SegLength = BitSize.Segments<T>(MaxBitCount);            
            this.BitMap = BitSize.BitMap<T>(MaxBitCount);
        }

        /// <summary>
        /// The number of bits represented by the vector
        /// </summary>
        public readonly BitSize Length 
        {
            [MethodImpl(Inline)]
            get => BitCount;
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
        /// A bit-level accessor/manipulator
        /// </summary>
        public bit this[int index]
        {
            [MethodImpl(Inline)]
            get => Get(index);
            
            [MethodImpl(Inline)]
            set => Set(index, value);
        }

        /// <summary>
        /// Is true if no bits are enabled, false otherwise
        /// </summary>
        public bool Empty
        {
            [MethodImpl(Inline)]
            get => Pop() == 0;
        }

        /// <summary>
        /// Is true if the vector has at least one enabled bit; false otherwise
        /// </summary>
        public readonly bool Nonempty
        {
            [MethodImpl(Inline)]
            get => Pop() != 0;
        }


        /// <summary>
        /// The maximum number of bits that can be represented by the vector
        /// </summary>
        public readonly int Capacity
        {
            [MethodImpl(Inline)]
            get => data.Length * CellCapacity;
        }

        /// <summary>
        /// Reads a bit value
        /// </summary>
        /// <param name="pos">The bit position</param>
        [MethodImpl(Inline)]
        public readonly Bit Get(int pos)
        {
            ref readonly var loc = ref Location(pos);
            return gbits.test(data[loc.Segment], loc.Offset);
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
        /// Sets a bit value
        /// </summary>
        /// <param name="pos">The absolute bit position</param>
        /// <param name="value">The value the bit will receive</param>
        [MethodImpl(Inline)]
        public void Set(int pos, bit value)
        {
            ref readonly var loc = ref Location(pos);
            gbits.set(ref data[loc.Segment], (byte)loc.Offset, value);
        }

        /// <summary>
        /// Specifies a reference to the leading cell
        /// </summary>
        public ref T Head
        {
            [MethodImpl(Inline)]
            get => ref data.Head;
        }

        [MethodImpl(Inline)]
        public T SliceCell(int first, int last)
            => Extract(in Location(first), in Location(last));

        /// <summary>
        /// Extracts the represented data as a bitstring
        /// </summary>
        [MethodImpl(Inline)]
        public readonly BitString ToBitString()
            => BitString.from<T>(data, Length); 

        /// <summary>
        /// Counts the vector's enabled bits
        /// </summary>
        [MethodImpl(Inline)]
        public readonly uint Pop()
        {
            var count = 0u;
            for(var i=0; i< data.Length; i++)
                count += gbits.pop(data[i]);
            return count;
        }

        /// <summary>
        /// Counts the number of bits set up to and including the specified position
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="pos">The position of the bit for which rank will be calculated</param>
        public uint Pop(int pos)
        {
            var rank = 0u;
            var segments = Segments(pos);
            for(var i=0; i < segments.Length; i++)
                rank += (uint)gbits.pop(segments[i]);            
            return rank;
        }

        public int BlockCount
        {
            [MethodImpl(Inline)]
            get => data.BlockCount;
        }

        /// <summary>
        /// Gets the mapped bit location
        /// </summary>
        /// <param name="pos">The bit position</param>
        [MethodImpl(Inline)]
        readonly ref readonly BitCellIndex<T> Location(int pos)
            => ref BitMap[pos];

        /// <summary>
        /// Returns a reference to the segment in which a specified bit is defined
        /// </summary>
        /// <param name="pos">The segmented bit position</param>
        [MethodImpl(Inline)]
        public ref T Segment(in BitCellIndex<T> pos)
            => ref data[pos.Segment];

        /// <summary>
        /// Returns a reference to the segment in which a specified bit is defined
        /// </summary>
        /// <param name="pos">The segmented bit position</param>
        [MethodImpl(Inline)]
        public ref T Segment(int pos)
            => ref Segment(in Location(pos));

        /// <summary>
        /// Retrieves the segments up to and including an identified bit
        /// </summary>
        /// <param name="pos">The bit position</param>
        [MethodImpl(Inline)]
        readonly Span<T> Segments(int pos)
            => data.Slice(0, Location(pos).Segment - 1);

        T Extract(in BitCellIndex<T> first, in BitCellIndex<T> last, bool describe = false)
        {

            var sameSeg = first.Segment == last.Segment;
            var wantedCount = last - first;
            var firstCount = sameSeg ? wantedCount : CellCapacity - first.Offset;
            var lastCount = wantedCount - firstCount;
            
            if(wantedCount > CellCapacity)
                throw new ArgumentException($"The total count {wantedCount} exceeds segment capacity of {CellCapacity}");

            ref var seg1 = ref Segment(in first);
            var part1 = gbits.extract(seg1, first.Offset, firstCount);
            
            if(sameSeg)
                return part1;

            ref var seg2 = ref Segment(in last);
            var part2 = gbits.extract(seg2, 0, lastCount);            

            if(describe)
            {
                print($"first = {first}");
                print($"last = {last}");
                print($"totalCount = {wantedCount}");
                print($"firstCount = {firstCount}");
                print($"LastCount = {lastCount}");
            }
            part2 = gmath.sal(part2, firstCount);
            return gmath.or(part1, part2);              
        }

        public BitCells<T> Replicate(bool structureOnly = false)
            => new BitCells<T>(data.Replicate(structureOnly));
                    
        [MethodImpl(Inline)]
        public bool Equals(in BitCells<T> y)
            => ToBitString().Equals(y.ToBitString());

        [MethodImpl(Inline)]
        public string Format(bool tlz = false, bool specifier = false, int? blockWidth = null)
            => ToBitString().Format(tlz, specifier, blockWidth);

        public override bool Equals(object obj)
            => throw new NotImplementedException();
        
        public override int GetHashCode()
            => throw new NotImplementedException();
    
        public override string ToString()
            => throw new NotImplementedException();
    }
}
