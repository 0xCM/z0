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

    /// <summary>
    /// Encapsulates a span that can be evenly partitioned into 256-bit blocks
    /// </summary>
    public readonly ref struct Block256<T>
        where T : unmanaged
    {
        readonly Span<T> data;

        public static N256 N => default;

        /// <summary>
        /// The number of cells in the block
        /// </summary>
        public static int BlockLength => Vector256<T>.Count;

        /// <summary>
        /// The size, in bytes, of a block 
        /// </summary>
        /// <typeparam name="T">The primitive type</typeparam>
        /// <remarks>Should always be 16 irrespective of the cell type</remarks>
        public static int BlockSize => Unsafe.SizeOf<T>() * BlockLength; 

        /// <summary>
        /// The size, in bytes, of a constituent block cell
        /// </summary>
        /// <typeparam name="T">The primitive type</typeparam>
        public static int CellSize => BlockSize / BlockLength;

        [MethodImpl(Inline)]
        public static implicit operator Span<T>(Block256<T> src)
            => src.data;

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<T> (Block256<T> src)
            => src.data;

        [MethodImpl(Inline)]
        public static implicit operator ConstBlock256<T> (Block256<T> src)
            => ConstBlock256<T>.Load(src);

        [MethodImpl(Inline)]
        public static bool operator == (Block256<T> lhs, Block256<T> rhs)
            => lhs.data == rhs.data;

        [MethodImpl(Inline)]
        public static bool operator != (Block256<T> lhs, Block256<T> rhs)
            => lhs.data != rhs.data;
        
        [MethodImpl(Inline)]
        public static bool Aligned(int length)
            => length % BlockLength == 0;
        
        
        [MethodImpl(NotInline)]
        public static Block256<T> AllocBlocks(int blocks, T? fill = null)
        {
            var dst = new Block256<T>(new T[blocks * BlockLength]);
            if(fill.HasValue)
                dst.data.Fill(fill.Value);
            return dst;
        }
    
        [MethodImpl(Inline)]
        public static Block256<T> LoadAligned(Span<T> src, int offset = 0)
        {
            require(Aligned(src.Length - offset));
            var slice = src.Slice(offset);
            return new Block256<T>(slice);
        }

        [MethodImpl(Inline)]
        internal Block256(ref T src, int length)
        {
            data = MemoryMarshal.CreateSpan(ref src, length);
        }

        [MethodImpl(Inline)]
        internal Block256(T[] src)
        {
            data = src;
        }                

        [MethodImpl(Inline)]
        internal Block256(Span<T> src)
        {
            this.data = src;
        }

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
        /// The total number of available cells 
        /// </summary>
        public int Length 
        {
            [MethodImpl(Inline)]
            get => data.Length;
        }

        /// <summary>
        /// The number of covered blocks
        /// </summary>
        public int BlockCount 
        {
            [MethodImpl(Inline)]
            get => data.Length / BlockLength; 
        }

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
        /// <param name="blockIndex">The index of the desired block</param>
        [MethodImpl(Inline)]
        public ref T BlockHead(int blockIndex)
            => ref Unsafe.Add(ref Head, blockIndex * BlockLength);

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
        public Block256<T> Block(int blockIndex)
        {
            var slice = data.Slice(blockIndex * BlockLength, BlockLength); 
            return new Block256<T>(slice);
        }
            
        [MethodImpl(Inline)]
        public Block256<T> Blocks(int blockIndex, int blockCount)
            => Block256<T>.LoadAligned(Slice(blockIndex * BlockLength, blockCount * BlockLength));
            
        /// <summary>
        /// Presents the allocated data as a blocked read-only span
        /// </summary>
        [MethodImpl(Inline)]
        public ConstBlock256<T> ReadOnly()
            => (ConstBlock256<T>)data;

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