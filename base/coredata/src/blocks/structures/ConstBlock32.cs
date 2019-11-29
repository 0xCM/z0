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

    /// <summary>
    /// Encapsulates a readonly span that can be evenly partitioned into 32-bit blocks
    /// </summary>
    public readonly ref struct ConstBlock32<T>
        where T : unmanaged
    {
        readonly ReadOnlySpan<T> data;

        /// <summary>
        /// The natural block width
        /// </summary>
        public static N32 N => default;

        /// <summary>
        /// The number of cells per block
        /// </summary>
        public static int BlockLength => DataBlocks.blocklen<T>(N);

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<T>(in ConstBlock32<T> src)
            => src.data;

        [MethodImpl(Inline)]
        public static bool operator == (in ConstBlock32<T> lhs, in ConstBlock32<T> rhs)
            => lhs.data == rhs.data;

        [MethodImpl(Inline)]
        public static bool operator != (in ConstBlock32<T> lhs, in ConstBlock32<T> rhs)
            => lhs.data != rhs.data;
        
        [MethodImpl(Inline)]
        internal ConstBlock32(ReadOnlySpan<T> src)
        {
            data = src;
        }

        [MethodImpl(Inline)]
        internal ConstBlock32(in Block32<T> src)
        {
            data = src;
        }

        public ReadOnlySpan<T> Data
        {
            [MethodImpl(Inline)]
            get => data;
        }

        public ref readonly T Head
        {
            [MethodImpl(Inline)]
            get => ref MemoryMarshal.GetReference(data);
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
        /// The number of covered blocks
        /// </summary>
        public int BlockCount 
        {
            [MethodImpl(Inline)]
            get => data.Length / BlockLength; 
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

        public ref readonly T this[int ix] 
        {
            [MethodImpl(Inline)]
            get => ref data[ix];
        }

        [MethodImpl(Inline)]
        public ref readonly T BlockSeek(int index)
            => ref Unsafe.Add(ref Unsafe.AsRef(in Head), index*BlockLength);  

        /// <summary>
        /// Extracts a block-relative slice
        /// </summary>
        /// <param name="offset">The block-relative offset at which to begin extraction</param>
        /// <param name="count">The number of blocks to extract</param>
        [MethodImpl(Inline)]
        public ConstBlock32<T> BlockSlice(int offset, int count)
            => new ConstBlock32<T>(data.Slice(offset*BlockLength, BlockLength * count));

        [MethodImpl(Inline)]
        public ReadOnlySpan<T> Slice(int start)
            => data.Slice(start);

        [MethodImpl(Inline)]
        public ReadOnlySpan<T> Slice(int start, int length)
            => data.Slice(start,length);

        [MethodImpl(Inline)]
        public Span<T> ToSpan()
            => data.ToSpan();

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
        public ConstBlock32<S> As<S>()                
            where S : unmanaged
                => new ConstBlock32<S>(MemoryMarshal.Cast<T,S>(data));                    
            
        public override string ToString() 
            => data.ToString();

        public override bool Equals(object rhs) 
            => throw new NotSupportedException();

       public override int GetHashCode() 
            => throw new NotSupportedException();        
    }
}