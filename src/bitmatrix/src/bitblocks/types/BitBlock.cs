//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed; 
    using static Memories;

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
            this.data = Blocks.single<T>(n256);
            this.data.Head = src;
            this.BitCount = bitcount;
        }

        [MethodImpl(Inline)]
        internal BitBlock(Span<T> src, int n)
        {            
            this.data = Blocks.safeload(n256,src);
            this.BitCount = n;
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
        /// Presents the represented data as a span of bytes
        /// </summary>
        public readonly Span<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => data.Bytes;
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
        /// A bit-level accessor/manipulator
        /// </summary>
        public bit this[int index]
        {
            [MethodImpl(Inline)]
            get => gbits.testbit(data,index);
            
            [MethodImpl(Inline)]
            set => gbits.setbit(data, index,value);
        }

        /// <summary>
        /// Retrieves, at most, one cell's worth of bits defined by an inclusive bit index range
        /// </summary>
        /// <param name="first">The linear index of the first bit</param>
        /// <param name="last">The linear index of the last bit</param>
        [MethodImpl(Inline)]
        public T TakeScalarBits(int first, int last)
            => gbits.bitseg(data, first,last);

        /// <summary>
        /// Extracts the represented data as a bitstring
        /// </summary>
        [MethodImpl(Inline)]
        public readonly BitString ToBitString()
            => data.ToBitString(BitCount);

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
                                        
        [MethodImpl(Inline)]
        public bool Equals(in BitBlock<T> y)
            => data.Identical(y.data);

        [MethodImpl(Inline)]
        public string Format(BitFormatConfig? fmt = null)
            => ToBitString().Format(fmt);

        public override bool Equals(object obj)
            => throw new NotImplementedException();
        
        public override int GetHashCode()
            => throw new NotImplementedException();
    
        public override string ToString()
            => throw new NotImplementedException();
    }
}
