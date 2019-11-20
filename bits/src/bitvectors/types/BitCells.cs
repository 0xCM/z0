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
        readonly Span256<T> data;
    
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

        public static BitCells<T> Zero => new BitCells<T>(BlockedSpan.alloc<T>(n256));

        public static int StepSize => 256 / bitsize<T>();

        /// <summary>
        /// Computes the number of cells required to hold a specified number of bits
        /// </summary>
        /// <param name="len">The number of bits to store</param>
        /// <typeparam name="T">The primal storage type</typeparam>
        [MethodImpl(Inline)]
        public static int CellCount(int len)
        {
            var q = Math.DivRem(len, CellCapacity, out int r);            
            return r == 0 ? q : q + 1;
        }

        /// <summary>
        /// Creates a bitvector defined by a single cell or portion thereof
        /// </summary>
        /// <param name="src">The source cell</param>
        [MethodImpl(Inline)]
        public static BitCells<T> FromCell(T src, int n)
            => new BitCells<T>(src,n);

        /// <summary>
        /// Creates a bitvector from a cell span
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="n">The bitvector length</param>
        [MethodImpl(Inline)]
        public static BitCells<T> FromCells(Span<T> src, int n)
            => new BitCells<T>(src,n);
        
        /// <summary>
        /// Creates a bitvector from a cell array, subject to a specified bitsize
        /// </summary>
        /// <param name="n">The length of the bitvector</param>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]
        public static BitCells<T> From(T[] src, int n)
            => new BitCells<T>(src, n);

        /// <summary>
        /// Creates a bitvector from a span of bytes
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="n">The bitvector length</param>
        public static BitCells<T> FromBytes(Span<byte> src, int n)
        {
            var q = Math.DivRem(src.Length, size<T>(), out int r);
            var cellcount = r == 0 ? q : q + 1;
            var capacity = CellCapacity/8;
            
            var cells = new T[cellcount];
            for(int i=0, offset = 0; i< cellcount; i++, offset += capacity)
                cells[i] = src.Slice(offset).TakeScalar<T>();
            return From(cells,n);
        }

        /// <summary>
        /// Loads an bitvector of minimal size from a source bitstring
        /// </summary>
        /// <param name="src">The bitstring source</param>
        [MethodImpl(Inline)]
        public static BitCells<T> From(BitString src)
            => FromBytes(src.ToPackedBytes(), src.Length);

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
            => dot(x,y);

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
        BitCells(T src, int n)
        {            
            this.data = BlockedSpan.alloc<T>(n256);
            head(this.data) = src;
            this.MaxBitCount = CellCapacity;
            this.SegLength = MaxBitCount;
            this.BitCount = n;
            this.BitMap = BitSize.BitMap<T>(MaxBitCount);
        }

        [MethodImpl(Inline)]
        BitCells(Span<T> src, int n)
        {            
            this.data = BlockedSpan.loadu(n256,src);
            this.MaxBitCount = src.Length * CellCapacity;
            this.BitCount = n;
            this.SegLength = BitSize.Segments<T>(MaxBitCount);            
            this.BitMap = BitSize.BitMap<T>(MaxBitCount);
        }

        [MethodImpl(Inline)]
        internal BitCells(Span256<T> src)
        {            
            this.data = src;
            this.MaxBitCount = src.Length * CellCapacity;
            this.BitCount = src.BlockCount * 256;
            this.SegLength = BitSize.Segments<T>(MaxBitCount);            
            this.BitMap = BitSize.BitMap<T>(MaxBitCount);
        }


        /// <summary>
        /// Computes the scalar product between this vector and another of identical length
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(NotInline)]
        static bit dot(in BitCells<T> x, in BitCells<T> y)
        {
            require(x.Length == y.Length);

            var result = bit.Off;
            for(var i=0; i<x.Length; i++)
                result ^= x[i] & y[i];
            return result;
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
        /// Tests the status of an identified bit
        /// </summary>
        /// <param name="pos">The position of the bit to test</param>
        [MethodImpl(Inline)]
        public bool Test(int pos)
            => Get(pos);

        /// <summary>
        /// Enables an identified bit
        /// </summary>
        /// <param name="pos">The position of the bit to enable</param>
        [MethodImpl(Inline)]
        public void Enable(int pos)
            => Set(pos, bit.On);

        /// <summary>
        /// Disables an identified bit
        /// </summary>
        /// <param name="pos">The position of the bit to disable</param>
        [MethodImpl(Inline)]
        public void Disable(int pos)
        {
            ref readonly var cell = ref BitMap[pos];
            gbits.disable(ref data[cell.Segment], (byte)cell.Offset);
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
        public void Toggle(int pos)
        {         
            ref readonly var loc = ref Location(pos);
            BitMaskG.toggle(ref data[loc.Segment],  (byte)loc.Offset);
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

        /// <summary>
        /// Sets all the bits to align with the source value
        /// </summary>
        /// <param name="value">The source value</param>
        [MethodImpl(Inline)]
        public void Fill(bit value)
        {
            var primal = PrimalInfo.Get<T>();
            if(value)
                data.Fill(primal.MaxVal);
            else
                data.Fill(primal.Zero);
        }

        /// <summary>
        /// Counts the number of bits set up to and including the specified position
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="pos">The position of the bit for which rank will be calculated</param>
        [MethodImpl(Inline)]
        public uint Rank(int pos)
            => Pop(pos);

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
            var part1 = gbits.extract(seg1, (byte)first.Offset, (byte)firstCount);
            
            if(sameSeg)
                return part1;

            ref var seg2 = ref Segment(in last);
            var part2 = gbits.extract(seg2, 0, (byte)lastCount);            

            if(describe)
            {
                print($"first = {first}");
                print($"last = {last}");
                print($"totalCount = {wantedCount}");
                print($"firstCount = {firstCount}");
                print($"LastCount = {lastCount}");
            }
            gmath.sal(ref part2, firstCount);
            return gmath.or(ref part1, part2);              
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
