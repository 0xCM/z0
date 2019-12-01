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
    using static DataBlocks;

    /// <summary>
    /// Encapsulates a readonly span that can be evenly partitioned into 256-bit blocks
    /// </summary>
    public readonly ref struct ConstBlock256<T>
        where T : unmanaged
    {
        readonly ReadOnlySpan<T> data;

        /// <summary>
        /// The natural block width
        /// </summary>
        public static N256 N => default;


        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<T>(in ConstBlock256<T> xb)
            => xb.data;

        [MethodImpl(Inline)]
        public static bool operator == (in ConstBlock256<T> xb, in ConstBlock256<T> yb)
            => xb.data == yb.data;

        [MethodImpl(Inline)]
        public static bool operator != (in ConstBlock256<T> xb, in ConstBlock256<T> yb)
            => xb.data != yb.data;
                        
        [MethodImpl(Inline)]
        internal ConstBlock256(Span<T> src)        
            => this.data = src;

        [MethodImpl(Inline)]
        internal ConstBlock256(ReadOnlySpan<T> src)
            => this.data = src;

        [MethodImpl(Inline)]
        internal ConstBlock256(in Block256<T> src)
            => this.data = src.Data;

        /// <summary>
        /// Provides access to the underlying storage
        /// </summary>
        public ReadOnlySpan<T> Data
        {
            [MethodImpl(Inline)]
            get => data;
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
        /// The number of cells in a block
        /// </summary>
        public int BlockLength
        {
            [MethodImpl(Inline)]
            get => blocklen<T>(N);
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

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => data.IsEmpty;
        }
            
        public ref T Head
        {
            [MethodImpl(Inline)]
            get => ref MemoryMarshal.GetReference<T>(data);
        }            
        
        public ref readonly T this[int ix] 
        {
            [MethodImpl(Inline)]
            get => ref Unsafe.Add(ref Head, ix);
        }
     
        [MethodImpl(Inline)]
        public ref readonly T BlockSeek(int index)
            => ref Unsafe.Add(ref Head, index*BlockLength);

        [MethodImpl(Inline)]
        public ReadOnlySpan<T> Slice(int start)
            => data.Slice(start);

        [MethodImpl(Inline)]
        public ReadOnlySpan<T> Slice(int start, int length)
            => data.Slice(start,length);

        [MethodImpl(Inline)]
        public T[] ToArray()
            => data.ToArray();   

        [MethodImpl(Inline)]
        public ReadOnlySpan<T>.Enumerator GetEnumerator()
            => data.GetEnumerator();

        [MethodImpl(Inline)]
        public ref readonly T GetPinnableReference()
            => ref data.GetPinnableReference();

        [MethodImpl(Inline)]
        public void CopyTo(Span<T> dst)
            => data.CopyTo(dst);

        [MethodImpl(Inline)]
        public bool TryCopyTo(Span<T> dst)
            => data.TryCopyTo(dst);
                
        [MethodImpl(Inline)]
        public ConstBlock256<S> As<S>()                
            where S : unmanaged
                => new ConstBlock256<S>(MemoryMarshal.Cast<T,S>(data));
             
        public override string ToString() 
            => data.ToString();

        public override bool Equals(object rhs) 
            => throw new NotSupportedException();

        public override int GetHashCode() 
            => throw new NotSupportedException();        
    }
}