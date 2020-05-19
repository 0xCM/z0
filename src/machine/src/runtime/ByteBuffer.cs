//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;
    using static Memories;

    public readonly struct ByteBuffer
    {
        readonly byte[] Data;

        [MethodImpl(Inline)]
        public static ByteBuffer<T> Init<T>(T[] data)
            where T : unmanaged
                => new ByteBuffer<T>(data);

        [MethodImpl(Inline)]
        public static ByteBuffer Init(byte[] data)
            => new ByteBuffer(data);

        /// <summary>
        /// The number of bytes covered by the buffer
        /// </summary>
        public const int BufferSize = 64;

        /// <summary>
        /// The number of 16-bit elements covered by the buffer
        /// </summary>
        public const int Buffer16 = BufferSize/2;

        /// <summary>
        /// The number of 32-bit elements covered by the buffer
        /// </summary>
        public const int Buffer32 = BufferSize/4;

        /// <summary>
        /// The number of 64-bit elements covered by the buffer
        /// </summary>
        public const int Buffer64 = BufferSize/8;

        /// <summary>
        /// The number of 128-bit elements covered by the buffer
        /// </summary>
        public const int Buffer128 = BufferSize/16;

        /// <summary>
        /// The number of 256-bit elements covered by the buffer
        /// </summary>
        public const int Buffer256 = BufferSize/32;

        /// <summary>
        /// The number of 512-bit elements covered by the buffer
        /// </summary>
        public const int Buffer512 = BufferSize/64;        

        [MethodImpl(Inline)]
        internal ByteBuffer(byte[] data)
        {
            Data = data;
        }

        public byte this[int index]        
        {
            [MethodImpl(Inline)]
            get => Data[index];
            
            [MethodImpl(Inline)]
            set => Data[index] = value;
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        public Span<byte> Content
        {
            [MethodImpl(Inline)]
            get => Data;
        }
        
        [MethodImpl(Inline)]
        public void Clear(W16 w)
        {
            head(Content.As<byte,ushort>()) = Zero16u;
        }

        [MethodImpl(Inline)]
        public void Clear(W32 w)
        {
            head(Content.As<byte,uint>()) = Zero32u;
        }

        [MethodImpl(Inline)]
        public void Clear(W64 w)
        {
            head(Content.As<byte,ulong>()) = Zero64u;
        }

        [MethodImpl(Inline)]
        public void Clear(W128 w)
        {
            head(Content.As<byte,Fixed128>()) = Fixed128.Empty;
        }        
    }
    
    public readonly struct ByteBuffer<T>
        where T : unmanaged
    {
        readonly T[] Data;

        [MethodImpl(Inline)]
        internal ByteBuffer(T[] data)
        {
            Data = data;
        }

        public T this[int index]        
        {
            [MethodImpl(Inline)]
            get => Data[index];
            
            [MethodImpl(Inline)]
            set => Data[index] = value;
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        public Span<T> Content
        {
            [MethodImpl(Inline)]
            get => Data;
        }        

        [MethodImpl(Inline)]
        public void Clear(W16 w)
        {
            head(Content.As<T,ushort>()) = Zero16u;
        }

        [MethodImpl(Inline)]
        public void Clear(W32 w)
        {
            head(Content.As<T,uint>()) = Zero32u;
        }

        [MethodImpl(Inline)]
        public void Clear(W64 w)
        {
            head(Content.As<T,ulong>()) = Zero64u;
        }

        [MethodImpl(Inline)]
        public void Clear(W128 w)
        {
            head(Content.As<T,Fixed128>()) = Fixed128.Empty;
        }
    }
}