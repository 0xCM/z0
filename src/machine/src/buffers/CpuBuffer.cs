//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machine
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;
    using static Memories;

    public readonly struct CpuBuffer
    {
        readonly byte[] Data;

        [MethodImpl(Inline)]
        public static CpuBuffer<N,W,T> Alloc<N,W,T>()
            where N : unmanaged, ITypeNat
            where W : unmanaged, ITypeWidth
            where T : unmanaged
                => new CpuBuffer<N,W,T>(new T[value<N>()]);

        [MethodImpl(Inline)]
        public static CpuBuffer<N,W,T> Init<N,W,T>(T[] data)
            where N : unmanaged, ITypeNat
            where W : unmanaged, ITypeWidth
            where T : unmanaged
                => new CpuBuffer<N,W,T>(data);

        [MethodImpl(Inline)]
        public static CpuBuffer Init(byte[] data)
            => new CpuBuffer(data);

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
        internal CpuBuffer(byte[] data)
        {
            Data = data;
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
}