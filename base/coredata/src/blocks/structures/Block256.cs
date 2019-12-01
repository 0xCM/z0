//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.InteropServices;    
    using System.Runtime.Intrinsics;    
        
    using static zfunc;
    using static DataBlocks;

    /// <summary>
    /// Encapsulates a span that can be evenly partitioned into 256-bit blocks
    /// </summary>
    public readonly ref struct Block256<T>
        where T : unmanaged
    {
        readonly Span<T> data;

        public static N256 N => default;

        /// <summary>
        /// The number of cells in a block
        /// </summary>
        public static int BlockLength => blocklen<T>(N);

        [MethodImpl(Inline)]
        public static implicit operator Span<T>(in Block256<T> src)
            => src.data;

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<T>(in Block256<T> src)
            => src.data;

        [MethodImpl(Inline)]
        public static implicit operator ConstBlock256<T>(in Block256<T> src)
            => new ConstBlock256<T>(src.data);

        [MethodImpl(Inline)]
        public static bool operator == (in Block256<T> lhs, in Block256<T> rhs)
            => lhs.data == rhs.data;

        [MethodImpl(Inline)]
        public static bool operator != (in Block256<T> lhs, in Block256<T> rhs)
            => lhs.data != rhs.data;
        
        [MethodImpl(Inline)]
        internal Block256(T[] src)
            => this.data = src;

        [MethodImpl(Inline)]
        internal Block256(Span<T> src)
            => this.data = src;

        /// <summary>
        /// The leading storage cell
        /// </summary>
        public ref T Head
        {
            [MethodImpl(Inline)]
            get => ref MemoryMarshal.GetReference(data);
        }

        /// <summary>
        /// Reads/Writes an index-identified cell
        /// </summary>
        public ref T this[int ix] 
        {
            [MethodImpl(Inline)]
            get => ref Unsafe.Add(ref Head, ix);
        }

        /// <summary>
        /// The encapsulated storage
        /// </summary>
        public Span<T> Data
        {
            [MethodImpl(Inline)]
            get => data;
        }

        /// <summary>
        /// The encapsulated storage presented as a span of bytes
        /// </summary>
        public Span<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => data.AsBytes();
        }

        /// <summary>
        /// The number of allocated cells 
        /// </summary>
        public int CellCount 
        {
            [MethodImpl(Inline)]
            get => data.Length;
        }

        /// <summary>
        /// The number of allocated bits
        /// </summary>
        public int BitCount 
        {
            [MethodImpl(Inline)]
            get => bitcount<T>(CellCount);
        }

        /// <summary>
        /// The number of allocated bytes
        /// </summary>
        public int ByteCount 
        {
            [MethodImpl(Inline)]
            get => bytecount<T>(CellCount);
        }

        /// <summary>
        /// The number of covered blocks
        /// </summary>
        public int BlockCount 
        {
            [MethodImpl(Inline)]
            get => blockcount<T>(N,CellCount);
        }

        /// <summary>
        /// The bit width of a cell
        /// </summary>
        public int CellWidth 
        {
            [MethodImpl(Inline)]
            get => cellwidth<T>();
        }

        /// <summary>
        /// The bit width of a block
        /// </summary>
        public int BlockWidth => N;

        /// <summary>
        /// The number of cells per block, synonymous with block length
        /// </summary>
        public int BlockCells
        {
            [MethodImpl(Inline)]
            get => BlockLength;
        }

        /// <summary>
        /// True if no capacity exists, false otherwise
        /// </summary>
        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => data.IsEmpty;
        }

        /// <summary>
        /// Returns a reference to the leading cell of an index-identified block
        /// </summary>
        /// <param name="block">The index of the desired block</param>
        [MethodImpl(Inline)]
        public ref T BlockRef(int block)
            => ref Unsafe.Add(ref Head, block * BlockLength);

        /// <summary>
        /// Slices an elementwise span from the source
        /// </summary>
        /// <param name="start">The index of the start element (not the block!)</param>
        [MethodImpl(Inline)]
        public Span<T> Slice(int start)
            => data.Slice(start);

        /// <summary>
        /// Slices an elementwise span from the source
        /// </summary>
        /// <param name="start">The index of the start element (not the block!)</param>
        /// <param name="length">The length of the desired span</param>
        [MethodImpl(Inline)]
        public Span<T> Slice(int start, int length)
            => data.Slice(start,length);

        [MethodImpl(Inline)]
        public T[] ToArray()
            => data.ToArray();   

        [MethodImpl(Inline)]
        public void Fill(T value)
            => data.Fill(value);

        [MethodImpl(Inline)]
        public Span<T>.Enumerator GetEnumerator()
            => data.GetEnumerator();

        [MethodImpl(Inline)]
        public ref T GetPinnableReference()
            => ref data.GetPinnableReference();

        [MethodImpl(Inline)]
        public void CopyTo(Span<T> dst)
            => data.CopyTo(dst);

        [MethodImpl(Inline)]
        public bool TryCopyTo(Span<T> dst)
            => data.TryCopyTo(dst);
                
        [MethodImpl(Inline)]
        public Block256<S> As<S>()                
            where S : unmanaged
                => new Block256<S>(MemoryMarshal.Cast<T,S>(data)); 

            
        public override bool Equals(object rhs) 
            => throw new NotSupportedException();

        public override int GetHashCode() 
            => throw new NotSupportedException();                
    }
}